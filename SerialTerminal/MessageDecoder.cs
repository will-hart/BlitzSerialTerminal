using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialTerminal
{
    internal class MessageDecoder
    {        
        /// <summary>
        /// Constructs a new message object, taking a logged message
        /// from the transmission history
        /// </summary>
        /// <param name="loggedMessage"></param>
        internal MessageDecoder(TransmissionRecord loggedMessage)
        {
            // decode the message, setting form properties
            this.Flags = new List<bool> { false, false, false, false, false };
            var len = loggedMessage.Message.Length;
            var msg = loggedMessage.Message;

            // sort out ID
            if (len >= 2)
            {
                this.ID = "0x" + msg[0] + msg[1];
            }

            // sort out type and flags
            if (len >= 4)
            {
                var meta = Convert.ToInt16(msg[2].ToString() + msg[3].ToString(), 16);
                this.TypeOfMessage = (MessageType)(meta >> 5);
                
                // if it is an instruction get the type before we bust up the flags
                if (this.TypeOfMessage == MessageType.Instruction)
                {
                    this.TypeOfInstruction = (InstructionType)(meta & 0x1F);
                }
                else if (this.TypeOfMessage == MessageType.Error)
                {
                    this.TypeOfError = (ErrorType)(meta & 0x1F);
                }
                else
                {
                    this.TypeOfInstruction = InstructionType.None;
                    this.TypeOfError = ErrorType.None;
                }
                
                for (var i = 4; i >= 0; --i)
                {
                    this.Flags[i] = (meta & 1) == 1;
                    meta >>= 1;
                }

            }

            // get the timestamp
            if (len >= 12)
            {
                this.Timestamp = (long)Convert.ToInt64(msg.Substring(4, 8), 16);
            }

            // and the rest is payload
            if (len > 12)
            {
                this.Payload = msg.Substring(12);
            } else {
                this.Payload = "empty";
            }
        }

        /// <summary>
        /// The ID of the message in hex format (e.g. 0x08)
        /// </summary>
        internal string ID
        {
            get;
            set;
        }

        /// <summary>
        /// The type of messge that was sent
        /// </summary>
        internal MessageType TypeOfMessage
        {
            get;
            set;
        }

        /// <summary>
        /// The flags that were set in the message
        /// </summary>
        internal List<bool> Flags
        {
            get;
            set;
        }

        /// <summary>
        /// The board timestamp when the message was logged
        /// </summary>
        internal long Timestamp
        {
            get;
            set;
        }

        /// <summary>
        /// The message payload
        /// </summary>
        internal string Payload
        {
            get;
            set;
        }

        /// <summary>
        /// If this is an instruction, what type is it???
        /// </summary>
        internal InstructionType TypeOfInstruction
        {
            get;
            set;
        }

        /// <summary>
        /// If this is an error, what type is it???
        /// </summary>
        internal ErrorType TypeOfError
        {
            get;
            set;
        }
    }

}
