using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialTerminal
{
    enum InstructionType
    {
        /// <summary>
        /// A null instruction
        /// </summary>
        None = 0,

        /// <summary>
        /// The terminal is requesting an ID from the board
        /// </summary>
        Id_Request = 1,

        /// <summary>
        /// The board is responding to an ID request
        /// </summary>
        Id_Response = 2,

        /// <summary>
        /// The terminal is requesting buffer status from the board
        /// </summary>
        Status_Request = 3,

        /// <summary>
        /// The board is responding with buffer information
        /// </summary>
        Status_Response = 4
    }
}
