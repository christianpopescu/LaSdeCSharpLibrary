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
        public void TestExceptionBadInitializationBothVariables()
        {

            FileRepositoryException ex = Assert.Throws<FileRepositoryException>(() => FileElement.BuildFileElement("",""));
            Assert.That(ex.Message, Is.EqualTo("File logical key is null or empty,File path is null or empty"));
        }

        [Test]
        public void TestExceptionBadInitializationFirstVariable()
        {

            FileRepositoryException ex = Assert.Throws<FileRepositoryException>(() => FileElement.BuildFileElement("xxxx", ""));
            Assert.That(ex.Message, Is.EqualTo("File path is null or empty"));
        }

        [Test]
        public void TestExceptionBadInitializationSecondVariable()
        {
            FileRepositoryException ex = Assert.Throws<FileRepositoryException>(() => FileElement.BuildFileElement("","xxxx"));
            Assert.That(ex.Message, Is.EqualTo("File logical key is null or empty"));
        }

        [Test]
        public void TestExceptionBadInitializationClassField()
        {
            FileRepositoryException ex = Assert.Throws<FileRepositoryException>(() => FileElement.BuildFileElement("", "xxxx"));
            Assert.That(ex.ClassName, Is.EqualTo("FileElement"));
        }

    }

}
