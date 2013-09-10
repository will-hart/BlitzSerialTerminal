using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialTerminal
{
    internal partial class MessageDecoderForm : Form
    {
        private MessageDecoder message;

        internal MessageDecoderForm(TransmissionRecord logged)
        {
            InitializeComponent();
        }
    }
}
