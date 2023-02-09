using LaSdeCSharpLibrary.FileRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaSdeCSharpLibraryTest.FileRepository
{
    /// <summary>
    /// Repository for Test
    /// </summary>
    internal class TestDataRepository : IDataRepository
    {
        public int AddFileElement(FileElement fileElement)
        {
            throw new NotImplementedException();
        }

        public int DeleteFileElement(FileElement fileElement)
        {
            throw new NotImplementedException();
        }

        public FileElement GetFileElementByLogicalId(string logicalId)
        {
            throw new NotImplementedException();
        }

        public IList<FileElement> GetFileElements(Predicate<FileElement> filterCondition)
        {
            throw new NotImplementedException();
        }

        public int UpdateFileElement(FileElement fileElement)
        {
            throw new NotImplementedException();
        }
    }
}
