using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialTerminal
{
    enum ErrorType
    {
        /// <summary>
        /// No error was found
        /// </summary>
        None = 0,

        /// <summary>
        /// The message received by the board was less than 4 chars, and hence too short to decode
        /// </summary>
        Message_Too_Short = 1,

        /// <summary>
        /// The board did not receive a newline before the serial buffer became full
        /// </summary>
        Serial_Buffer_Full = 2,

        /// <summary>
        /// The requested functionality is not implemented on this board
        /// </summary>
        Not_Implemented = 3,

        /// <summary>
        /// The message received by the board is of an unknown type
        /// </summary>
        Unknown_Message = 4,

        /// <summary>
        /// The instruction received by the board is unknown
        /// </summary>
        Unknown_Instruction = 5
    }
}
