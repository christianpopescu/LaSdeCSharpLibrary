using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaSdeCSharpLibrary.Logger
{
    /// <summary>
    /// Defines a logger interface for writing log messages.
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Writes a log message with a new line.
        /// </summary>
        /// <param name="message">The message to log.</param>
        void LogWriteLine(string message);
    }
}
