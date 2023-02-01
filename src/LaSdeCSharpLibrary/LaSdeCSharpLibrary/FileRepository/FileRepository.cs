using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaSdeCSharpLibrary.FileRepository
{
    internal class FileRepository
    {
        public string Root { get; set; }
        
        public IList<FileElement> FileElements { get; set; }

        public FileRepository() 
        { 
            Root = string.Empty;    
            FileElements = new List<FileElement>();
        }
    }
}
