using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaSdeCSharpLibrary.FileRepository
{
    internal interface IDataRepository
    {
        FileElement GetFileElementByLogicalId(string logicalId);
        int AddFileElement(FileElement fileElement);

        int DeleteFileElement(FileElement fileElement);

        int UpdateFileElement(FileElement fileElement);

        IList<FileElement> GetFileElements(Predicate<FileElement> filterCondition);
    }
}
