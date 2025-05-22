using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaSdeCSharpLibrary.Logger
{
    /// <summary>
    /// Provides functionality to log messages to the console.
    /// </summary>
    public class ConsoleLogger : ILogger
    {
        private static readonly Lazy<ConsoleLogger> _instance = new(() => new ConsoleLogger());

        /// <summary>
        /// Gets the singleton instance of the ConsoleLogger.
        /// </summary>
        public static ConsoleLogger Instance => _instance.Value;

        // Private constructor to prevent external instantiation
        private ConsoleLogger() { }

        /// <summary>
        /// Writes a log message with a new line to the console.
        /// </summary>
        /// <param name="message">The message to log.</param>
        public void LogWriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
    
}
