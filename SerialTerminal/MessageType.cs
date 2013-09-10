using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialTerminal
{
    enum MessageType
    {
        /// <summary>
        /// Instruct board to start logging
        /// </summary>
        Start = 0,

        /// <summary>
        /// Instruct board to stop logging
        /// </summary>
        Stop = 1,

        /// <summary>
        /// Message acknowledged
        /// </summary>
        Ack = 2,

        /// <summary>
        /// Error decoding or responding to message
        /// </summary>
        Error = 3,

        /// <summary>
        /// An instruction for the board to carry out
        /// </summary>
        Instruction = 4,

        /// <summary>
        /// A data message
        /// </summary>
        Data = 5,

        /// <summary>
        /// Instruction for board to transmit messages
        /// </summary>
        Transmit = 6,

        /// <summary>
        /// An extended data format with variable length payload
        /// </summary>
        Extended = 7
    }
}
