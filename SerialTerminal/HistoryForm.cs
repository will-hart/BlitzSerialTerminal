using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialTerminal
{
    internal partial class HistoryForm : Form
    {
        List<TransmissionRecord> transmissions;

        internal HistoryForm(List<TransmissionRecord> transmissions)
        {
            InitializeComponent();

            this.transmissions = transmissions;

            // populate the list boxes
            foreach (var transmission in transmissions)
            {
                var op = transmission.ToString();
                var ep = "";
                this.SentListBox.Items.Add(transmission.Sent ? op : ep);
                this.ReceivedListBox.Items.Add(transmission.Sent ? ep : op);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            if (this.SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var writer = new StreamWriter(this.SaveFileDialog.FileName);
                foreach (var transmission in this.transmissions) {
                    writer.WriteLine(transmission.ToString());
                }
                writer.Close();
            }
        }

        private void SentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ReceivedListBox.SelectedIndex = this.SentListBox.SelectedIndex;
        }

        private void ReceivedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SentListBox.SelectedIndex = this.ReceivedListBox.SelectedIndex;
        }

        private void SentListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            this.ReceivedListBox.TopIndex = this.SentListBox.TopIndex;
        }

        private void ReceivedListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            this.SentListBox.TopIndex = this.ReceivedListBox.TopIndex;
        }
    }
}
