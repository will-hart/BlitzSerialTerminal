using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        /// <param name="message"></param>
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

            this.messageHistory.Add("");

            this.appendNewline = this.AppendNewlineCheckbox.Checked;
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
            this.LogMessage(" - Newlines will " + (this.appendNewline ? "now" : "not") + " be appended to messages");
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
                this.serialPort.DtrEnable = !this.serialPort.DtrEnable; // toggle DTR for a reset 
                this.serialPort.DtrEnable = !this.serialPort.DtrEnable;

                // update the UI
                this.ConnectButton.Text = "Disconnect";
                this.LogMessage(" - Connected to serial port on " + this.ComPortComboBox.SelectedItem.ToString() + " @ " + this.BaudRateTextBox.Text);

                // clear the transaction record from the last session
                this.transmissionHistory.Clear();

                this.ComPortComboBox.Enabled = false;
                this.SendButton.Enabled = true;
                this.InputTextBox.Focus();
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

                this.LogMessage(" - Disconnected from serial port");
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

                // send the message
                if (this.appendNewline)
                {
                    this.serialPort.WriteLine(message);
                }
                else
                {
                    this.serialPort.Write(message);
                }

                // log the sent message
                this.transmissionHistory.Add(new TransmissionRecord(true, message));
                this.LogMessage(" > " + message);

                // empty the text box
                this.InputTextBox.Text = "";
            }
            else
            {
                this.LogMessage(" ! Unable to send serial - no serial connection");
            }

            this.InputTextBox.Focus();
        }

        /// <summary>
        /// Logs a message to the terminal box
        /// </summary>
        /// <param name="message"></param>
        void LogMessage(string message)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new StringDelegate(this.LogMessage), message);
                return;
            }

            // add the message to the UI
            this.TerminalListBox.Items.Add("[" + DateTime.Now.ToShortTimeString() + "] " + message);
            this.TerminalListBox.SelectedIndex = this.TerminalListBox.Items.Count - 1;
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
                new string[] {Environment.NewLine },
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
                this.LogMessage(" < " + s);
                this.transmissionHistory.Add(new TransmissionRecord(false, s));
            }
        }
        
        /// <summary>
        /// Invalidate the list box when an item is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TerminalListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TerminalListBox.Invalidate();
        }

        /// <summary>
        /// Show the history form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HistoryButton_Click(object sender, EventArgs e)
        {
            var history = new HistoryForm(this.transmissionHistory);
            history.ShowDialog();
        }
    }
}
