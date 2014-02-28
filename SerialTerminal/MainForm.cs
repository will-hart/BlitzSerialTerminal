using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialTerminal
{
    public partial class MainForm : Form
    {

        /// <summary>
        /// A flag set to true when newlines should be appended to all serial transmissions
        /// </summary>
        private bool appendNewline = true;

        /// <summary>
        /// Sets whether the Arduino should be reset on connecting by toggling DTR enable
        /// </summary>
        private bool resetOnConnect = true;
        
        /// <summary>
        /// A serial port to use for communications
        /// </summary>
        private SerialPort serialPort = null;

        /// <summary>
        /// A history of messages sent
        /// </summary>
        private readonly List<string> messageHistory = new List<string>();

        /// <summary>
        /// A list of transmission and received values for maintaining a history
        /// </summary>
        private readonly List<TransmissionRecord> transmissionHistory = new List<TransmissionRecord>();

        /// <summary>
        /// The current history index
        /// </summary>
        private int historyIndex = 0;

        /// <summary>
        /// A delegate for updating the message log on the UI thread
        /// </summary>
        private delegate void LogMessageDelegate(string message, TransmissionType transmissionType);

        /// <summary>
        /// A delegate for sending on the UI thread
        /// </summary>
        private delegate void StringDelegate(string message);

        /// <summary>
        /// A buffer for holding serial messages until a newline is received
        /// </summary>
        private string serialBuffer;

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When the main form is loaded, populate the combo box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.PrepareSerialPorts();

            this.messageHistory.Add("");
            this.transmissionHistory.Add(new TransmissionRecord(TransmissionType.ApplicationMessage, "Starting terminal..."));

            this.appendNewline = this.AppendNewlineCheckbox.Checked;
            this.resetOnConnect = this.ResetOnConnectCheckbox.Checked;
        }

        /// <summary>
        /// Sets up the combo box with the available serial ports
        /// </summary>
        private void PrepareSerialPorts()
        {
            // clear existing items 
            this.ComPortComboBox.Items.Clear();

            // set com ports into combo box
            string[] ports = SerialPort.GetPortNames();
            foreach (var port in ports)
            {
                this.ComPortComboBox.Items.Add(port);
            }

            // if there are any items then select the first one
            if (this.ComPortComboBox.Items.Count > 0)
            {
                this.ComPortComboBox.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Called when the checkbox value changes and sets the private variable.
        /// If true, a newline "\n" will be appended to all serial transmission
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AppendNewlineCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            this.appendNewline = this.AppendNewlineCheckbox.Checked;
            this.LogMessage("Newlines will " + 
                (this.appendNewline ? "now" : "not") + " be appended to messages",
                TransmissionType.ApplicationMessage);
        }

        /// <summary>
        /// Creates a serial connection when the button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConnectButton_Click(object sender, EventArgs e)
        {
            this.DisconnectSerial();

            // check if we are connecting or disconnecting
            if (this.ConnectButton.Text == "Disconnect") {
                this.ConnectButton.Text = "Connect";
            } else {
                // check if we have a serial port selected 
                if (this.ComPortComboBox.SelectedIndex == -1)
                {
                    this.LogMessage("Unable to connect - no port specified!", TransmissionType.ApplicationError);
                    return;
                }

                // update the UI
                this.ConnectButton.Text = "Disconnect";

                // clear the transaction record from the last session
                this.transmissionHistory.Clear();
                this.transmissionHistory.Add(new TransmissionRecord(TransmissionType.ApplicationMessage, "Connecting..."));
                this.SentListBox.Items.Clear();
                this.SentListBox.Items.Add("Sent Messages");
                this.ReceivedListBox.Items.Clear();
                this.ReceivedListBox.Items.Add("Received Messages");

                // log the message
                this.LogMessage("Connected to serial port on " +
                        this.ComPortComboBox.SelectedItem.ToString() + " @ " +
                        this.BaudRateTextBox.Text,
                        TransmissionType.ApplicationMessage);

                // sort out the buttons
                this.ComPortComboBox.Enabled = false;
                this.SendButton.Enabled = true;
                this.InputTextBox.Focus();
                
                // open a new serial port
                this.serialPort = new SerialPort(this.ComPortComboBox.SelectedItem.ToString(), int.Parse(this.BaudRateTextBox.Text));

                try
                {
                    this.serialPort.Open();
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("Unable to connect to the serial port - it seems to be in use");
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error connecting to the serial port - " + ex.Message);
                    return;
                }
                this.serialPort.DataReceived += OnDataReceived;

                if (this.resetOnConnect)
                {
                    this.serialPort.DtrEnable = !this.serialPort.DtrEnable; // toggle DTR for a reset 
                    this.serialPort.DtrEnable = !this.serialPort.DtrEnable;
                }
            }
        }

        /// <summary>
        /// close an existing serial port if there is one
        /// </summary>
        private void DisconnectSerial()
        {
            if (this.serialPort != null)
            {
                if (this.serialPort.IsOpen)
                {
                    this.serialPort.Close();
                }

                this.serialPort = null;

                this.LogMessage("Disconnected from serial port", TransmissionType.ApplicationMessage);
            }

            this.ComPortComboBox.Enabled = true;
            this.SendButton.Enabled = false;
        }

        /// <summary>
        /// When enter is clicked in the termninal box, send a message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SendMessage(this.InputTextBox.Text);
            }
            else if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                var up = e.KeyCode == Keys.Up;

                // check if we are already at the limits in this direction
                if ((up && this.historyIndex >= this.messageHistory.Count - 1)
                     || (!up && this.historyIndex <= 0))
                {
                    return;
                }

                // change the index and apply 
                this.historyIndex += up ? 1 : -1;
                this.InputTextBox.Text = this.messageHistory[this.historyIndex];
                this.InputTextBox.SelectAll();
                this.InputTextBox.Focus();
                e.Handled = true;
            }
        }

        /// <summary>
        /// Send a message on the serial port
        /// </summary>
        void SendMessage(string message)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new StringDelegate(this.SendMessage), message);
                return;
            }

            // ignore empty messages
            if (this.InputTextBox.Text == "")
            {
                return;
            }
            
            // check if we have a serial port to send from
            if (this.serialPort != null && this.serialPort.IsOpen)
            {
                // log the sent message in the history
                this.messageHistory.Insert(1, message); // log at position 1 so blank text is always first
                this.historyIndex = 0;

                try
                {
                    // send the message
                    if (this.appendNewline)
                    {
                        this.serialPort.WriteLine(message);
                    }
                    else
                    {
                        this.serialPort.Write(message);
                    }
                }
                catch (IOException)
                {
                    this.LogMessage("Unable to send serial - the connection has closed", TransmissionType.ApplicationError);
                    this.DisconnectSerial();
                    return;
                }
                catch (Exception e)
                {
                    this.LogMessage("Error - " + e.Message + ". Please try again", TransmissionType.ApplicationError);
                    return;
                }

                // log the sent message
                this.LogMessage(message, TransmissionType.SentMessage);

                // empty the text box
                this.InputTextBox.Text = "";
            }
            else
            {
                this.LogMessage("Unable to send serial - no serial connection", TransmissionType.ApplicationError);
            }

            this.InputTextBox.Focus();
        }

        /// <summary>
        /// Logs a message to the terminal box
        /// </summary>
        /// <param name="message"></param>
        void LogMessage(string message, TransmissionType transmissionType)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new LogMessageDelegate(this.LogMessage), message, transmissionType);
                return;
            }

            // create a new transmission record
            var record = new TransmissionRecord(transmissionType, message);
            this.transmissionHistory.Add(record);

            // add the message to the UI
            var lb = transmissionType == TransmissionType.ReceivedMessage ? this.ReceivedListBox : this.SentListBox;
            var other = transmissionType == TransmissionType.ReceivedMessage ? this.SentListBox : this.ReceivedListBox;

            other.Items.Add("");
            lb.Items.Add(record.ToString());
            lb.SelectedIndex = lb.Items.Count - 1;
        }

        /// <summary>
        /// Ensure the serial port is closed when disconnecting
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DisconnectSerial();
        }

        /// <summary>
        /// Sends the serial message when the text box is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SendHexButton_Click(object sender, EventArgs e)
        {
            this.SendMessage(this.InputTextBox.Text);
        }

        /// <summary>
        /// Handles received serial data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var dataLength = this.serialPort.BytesToRead;
            var data = new byte[dataLength];
            if (this.serialPort.Read(data, 0, dataLength) == 0) return;
            var message = Encoding.ASCII.GetString(data, 0, dataLength);

            // put into the buffer
            this.serialBuffer += message;

            // if we haven't received a complete message yet, return
            if (!message.Contains(Environment.NewLine))
            {
                return;
            }

            // otherwise split into chunks and process
            var split = this.serialBuffer.Split(
                new string[] { Environment.NewLine },
                StringSplitOptions.RemoveEmptyEntries);

            // work out if we had a trailing newline and handle it
            if (this.serialBuffer.EndsWith(Environment.NewLine))
            {
                this.serialBuffer = "";
            }
            else
            {
                this.serialBuffer = split[split.Length - 1];
                split = split.Take(split.Length - 1).ToArray();
            }

            foreach (var s in split)
            {
                this.LogMessage(s, TransmissionType.ReceivedMessage);
            }
        }

        /**
         * Handlers for synchronising the two list boxes for side by side scrolling
         */
        private void SentListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            var idx = this.SentListBox.TopIndex;
            if (idx >= this.ReceivedListBox.Items.Count) return;
            this.ReceivedListBox.TopIndex = idx;
        }

        private void ReceivedListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            var idx = this.ReceivedListBox.TopIndex;
            if (idx >= this.SentListBox.Items.Count) return;
            this.SentListBox.TopIndex = idx;
        }

        private void SentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idx = this.SentListBox.SelectedIndex;
            if (idx >= this.ReceivedListBox.Items.Count) return;
            this.ReceivedListBox.SelectedIndex = idx;
            
            // also handle displaying message
            if (idx >= 0 &&
                this.transmissionHistory[idx].TypeOfTransmission != TransmissionType.ApplicationMessage &&
                this.transmissionHistory[idx].TypeOfTransmission != TransmissionType.ApplicationError)
            {
                var message = this.transmissionHistory[idx].Message;

                // populate
                this.IdLabel.Text = message.ID;
                this.TypeLabel.Text = message.TypeOfMessage.ToString(); 
                this.InstructionTypeLabel.Text = string.Empty;
                this.FlagsLabel.Text = string.Join(" ", message.Flags.Select(o => o ? "Y" : "N"));
                this.TimestampLabel.Text = message.Timestamp.ToString();
                this.PayloadLabel.Text = message.Payload;

                // update instruction label for specific message types
                if (message.TypeOfMessage == MessageType.Instruction)
                {
                    this.InstructionTypeLabel.Text = message.TypeOfInstruction.ToString().Replace("_", " ");
                }
                else if (message.TypeOfMessage == MessageType.Error)
                {
                    this.InstructionTypeLabel.Text = message.TypeOfError.ToString().Replace("_", " ");
                }
            }
            else
            {
                // clear the fields
                this.IdLabel.Text = string.Empty;
                this.TypeLabel.Text = string.Empty;
                this.InstructionTypeLabel.Text = string.Empty;
                this.FlagsLabel.Text = string.Empty;
                this.TimestampLabel.Text = string.Empty;
                this.PayloadLabel.Text = string.Empty;
            }
        }

        private void ReceivedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idx = this.ReceivedListBox.SelectedIndex;
            if (idx >= this.SentListBox.Items.Count) return;
            this.SentListBox.SelectedIndex = idx;
        }

        /// <summary>
        /// Exports the last session's data to the given file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExportSessionButton_Click(object sender, EventArgs e)
        {
            if (this.SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var writer = new StreamWriter(this.SaveFileDialog.FileName);
                foreach (var transmission in this.transmissionHistory)
                {
                    writer.WriteLine(transmission.ToString());
                }
                writer.Close();
            }
        }

        /// <summary>
        /// Goodbye cruel world
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Handles general message sending from the menu by exctracting the button tag
        /// and queueing it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InsertMessageToolBarItem_Click(object sender, EventArgs e)
        {
            this.QueueMessage(((ToolStripMenuItem)sender).Tag.ToString());
        }

        /// <summary>
        /// Queues a message for sending and focuses on the text box so you can hit enter to send
        /// </summary>
        /// <param name="insertText">The text to insert</param>
        private void QueueMessage(string insertText)
        {
            var selectionIndex = this.InputTextBox.SelectionStart;
            this.InputTextBox.Text = this.InputTextBox.Text.Insert(selectionIndex, insertText);
            this.InputTextBox.SelectionLength = insertText.Length;
            this.InputTextBox.Focus();
        }

        /// <summary>
        /// Handles toggling of the reset on connect checkbox.  This allows the user to automatically reset
        /// the Arduino on connection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetOnConnectCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            this.resetOnConnect = this.ResetOnConnectCheckbox.Checked;
        }

        /// <summary>
        /// Allows user to refresh the serial ports if they have just plugged a device in
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshSerialPortsMenuItem_Click(object sender, EventArgs e)
        {
            this.PrepareSerialPorts();
        }
    }
}
