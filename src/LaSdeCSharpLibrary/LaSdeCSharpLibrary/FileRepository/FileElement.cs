using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaSdeCSharpLibrary.FileRepository
{
    /// <summary>
    ///  File element keeps the mapping between the logical key that identify the File and the physical
    ///  path to to the file
    /// </summary>
 
    internal class FileElement
    {
        #region Fields and Properties
        public string FileLogicalKey { get; set; }
        public string FilePath { get; set; }
        #endregion

        private FileElement() { } // does not allow FileElement creation with empty values

        public static FileElement BuildFileElement (string fileLogicalKey, string filePath)
        {
            FileElement aFileElement = new ();
            bool error = false;
            StringBuilder message= new StringBuilder();
            if (string.IsNullOrEmpty(fileLogicalKey))
            {
                message.Append("File logical key is null or empty");
                error = true;
            }
            if (string.IsNullOrEmpty(filePath)) 
            {
                message.Append(message.Length > 0 ? "," : "").Append("File path is null or empty");
                error = true;
            }
            if (error)
            {
                throw new FileRepositoryException(message.ToString()) { ClassName = "FileElement" };
            }

            return aFileElement;
        }
    }
}
