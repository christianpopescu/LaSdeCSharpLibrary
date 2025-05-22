using LaSdeCSharpLibrary.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaSdeCSharpLibrary.FilesAndFolders
{
    /// <summary>
    /// This class is used to compose files (concatenate files, split files, extract content, etc.)
    /// </summary>
    public class FileCompositionHelper
    {
        private ILogger _logger;

        /// <summary>
        /// Constructor to initialize FileCompositionHelper with a logger.
        /// </summary>
        /// <param name="logger">The logger instance to use.</param>
        public FileCompositionHelper(ILogger logger)
        {
            _logger = logger ?? new NullLogger();
        }

        /// <summary>
        /// Default constructor that initializes with a NullLogger.
        /// </summary>
        public FileCompositionHelper() : this(new NullLogger())
        {
        }

        /// <summary>
        /// This method is used to concatenate files.
        /// </summary>
        /// <param name="files">The list of files to concatenate.</param>
        /// <param name="outputFile">The output file.</param>
        public void ConcatenateFiles(List<string> files, string outputFile)
        {
            using (var outputStream = new FileStream(outputFile, FileMode.Create))
            {
                foreach (var file in files)
                {
                    using (var inputStream = new FileStream(file, FileMode.Open))
                    {
                        inputStream.CopyTo(outputStream);
                        _logger.LogWriteLine($"Concatenated {file} to {outputFile}.");
                    }
                }
            }
        }
    }
}
