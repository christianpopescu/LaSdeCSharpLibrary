using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaSdeCSharpLibrary.Logger
{
    /// <summary>
    /// Logger that does nothing.
    /// </summary>
    class NullLogger : ILogger
    {
        public void LogWriteLine(string message)
        {
            return;
        }
    }
}
