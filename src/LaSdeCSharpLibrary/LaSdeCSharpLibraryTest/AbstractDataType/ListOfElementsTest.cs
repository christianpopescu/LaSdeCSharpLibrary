using NUnit.Framework;
using LaSdeCSharpLibrary.AbstractDataType;
using System.IO;

namespace LaSdeCSharpLibraryTest.AbstractDataType
{
    [TestFixture]
    public class ListOfElementsTest
    {
        [Test]
        public void LoadLinesFromText_ShouldLoadAllLines()
        {
            // Arrange
            var listOfElements = new ListOfElements();
            string input = "Line1\nLine2\nLine3";
            using (var reader = new StringReader(input))
            {
                // Act
                listOfElements.LoadLinesFromText(reader);
            }

            // Assert
            Assert.AreEqual(3, listOfElements.Elements.Count);
            Assert.AreEqual("Line1", listOfElements.Elements[0]);
            Assert.AreEqual("Line2", listOfElements.Elements[1]);
            Assert.AreEqual("Line3", listOfElements.Elements[2]);
        }

        [Test]
        public void LoadLinesFromText_ShouldHandleEmptyInput()
        {
            // Arrange
            var listOfElements = new ListOfElements();
            string input = "";
            using (var reader = new StringReader(input))
            {
                // Act
                listOfElements.LoadLinesFromText(reader);
            }

            // Assert
            Assert.AreEqual(0, listOfElements.Elements.Count);
        }
    }
}
