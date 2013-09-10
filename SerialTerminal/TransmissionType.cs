using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialTerminal
{
    enum TransmissionType
    {
        /// <summary>
        /// Messages sent to an expansion board
        /// </summary>
        SentMessage = 0,

        /// <summary>
        /// Messages received from an expansion board
        /// </summary>
        ReceivedMessage = 1,

        /// <summary>
        /// Messages logged by the application
        /// </summary>
        ApplicationMessage = 2,

        /// <summary>
        /// Errors logged by the application
        /// </summary>
        ApplicationError = 3
    }
}
