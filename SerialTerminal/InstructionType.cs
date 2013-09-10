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

        Status_Request = 8,

        Status_Response = 9,

        Id_Request = 16,

        Id_Response = 17,

        Unknown_Instruction = 31
    }
}
