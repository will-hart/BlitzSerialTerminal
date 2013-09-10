using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialTerminal
{
    internal class TransmissionRecord
    {
        internal TransmissionRecord(TransmissionType typeOfTransmission, string message)
        {
            this.TypeOfTransmission = typeOfTransmission;
            this.Message = message;
            this.Recorded = DateTime.Now;
        }

        /// <summary>
        /// A flag indicating whether this message was sent or received
        /// </summary>
        internal TransmissionType TypeOfTransmission
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
            var output = "[" + this.Recorded.ToString("HH:mm.ss") + "]  ";

            switch (this.TypeOfTransmission)
            {
                case TransmissionType.SentMessage:
                    output += "> ";
                    break;
                case TransmissionType.ReceivedMessage:
                    output += "< ";
                    break;
                case TransmissionType.ApplicationMessage:
                    output += "- ";
                    break;
                case TransmissionType.ApplicationError:
                    output += "! ";
                    break;
                default:
                    output += "? ";
                    break;
            }
            
            return output + this.Message;
        }
    }
}
