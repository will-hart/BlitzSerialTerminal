using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialTerminal
{
    internal class TransmissionRecord
    {
        internal TransmissionRecord(bool sent, string message)
        {
            this.Sent = sent;
            this.Message = message;
            this.Recorded = DateTime.Now;
        }

        /// <summary>
        /// A flag indicating whether this message was sent or received
        /// </summary>
        internal bool Sent
        {
            get;
            set;
        }

        /// <summary>
        /// The message that was sent
        /// </summary>
        internal string Message
        {
            get;
            set;
        }

        internal DateTime Recorded
        {
            get;
            set;
        }

        /// <summary>
        /// Exports the transmission as a formatted string
        /// </summary>
        /// <returns></returns>
        internal new string ToString()
        {
            return "[" + this.Recorded.ToShortTimeString() + "]  " + 
                    (this.Sent ? "> " : "< ") + this.Message;
        }
    }
}
