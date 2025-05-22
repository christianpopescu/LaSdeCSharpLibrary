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
        /// <summary>
        /// This method is used to concatenate files.
        /// </summary>
        /// <param name="files">The list of files to concatenate.</param>
        /// <param name="outputFile">The output file.</param>
        public static void ConcatenateFiles(List<string> files, string outputFile)
        {
            using (var outputStream = new FileStream(outputFile, FileMode.Create))
            {
                foreach (var file in files)
                {
                    using (var inputStream = new FileStream(file, FileMode.Open))
                    {
                        inputStream.CopyTo(outputStream);
                    }
                }
            }
        }
    }
}
