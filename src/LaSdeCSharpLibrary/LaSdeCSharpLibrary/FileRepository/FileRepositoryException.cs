using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaSdeCSharpLibrary.FileRepository
{
    internal class FileRepositoryException : Exception
    {
        public FileRepositoryException() { }

        public FileRepositoryException(string message) : base(message) { }

        public string ClassName { get; set; }
    }
}
