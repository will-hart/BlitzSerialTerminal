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
            this.RawMessage = message;
            this.Message = null;
            this.Recorded = DateTime.Now;

            if (typeOfTransmission == TransmissionType.ReceivedMessage ||
                typeOfTransmission == TransmissionType.SentMessage)
            {
                try
                {
                    this.Message = new MessageDecoder(this.RawMessage);
                }
                catch (Exception)
                {
                    this.TypeOfTransmission = TransmissionType.ApplicationError;
                    this.RawMessage = "Error parsing: " + this.RawMessage;
                }
            }
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
        /// The message that was sent or received
        /// </summary>
        internal string RawMessage
        {
            get;
            set;
        }

        /// <summary>
        /// When the message was created
        /// </summary>
        internal DateTime Recorded
        {
            get;
            set;
        }

        internal MessageDecoder Message
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
            var output = "[" + this.Recorded.ToString("HH:mm.ss") + "] ";

            switch (this.TypeOfTransmission)
            {
                case TransmissionType.SentMessage:
                    output += " > ";
                    break;
                case TransmissionType.ReceivedMessage:
                    if (this.Message.TypeOfMessage == MessageType.Error)
                    {
                        output += "<! ";
                    }
                    else
                    {
                        output += " < ";
                    }
                    break;
                case TransmissionType.ApplicationMessage:
                    output += " - ";
                    break;
                case TransmissionType.ApplicationError:
                    output += " ! ";
                    break;
                default:
                    output += " ? ";
                    break;
            }
            
            return output + this.RawMessage;
        }
    }
}
