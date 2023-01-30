using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaSdeCSharpLibrary.FileRepository;

namespace LaSdeCSharpLibraryTest.FileRepository
{
    [TestFixture]
    internal class FileElementTest
    {
        [Test]
        public void TestExceptionBadInitialization()
        {
            
            Assert.Throws<FileRepositoryException>(() => FileElement.BuildFileElement("",""));
        }
    }

}
