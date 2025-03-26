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
                listOfElements.LoadLines(reader);
            }

            // Assert
            Assert.That(listOfElements.Elements.Count, Is.EqualTo(3));
            Assert.That(listOfElements.Elements[0], Is.EqualTo("Line1"));
            Assert.That(listOfElements.Elements[1], Is.EqualTo("Line2"));
            Assert.That(listOfElements.Elements[2], Is.EqualTo("Line3"));
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
                listOfElements.LoadLines(reader);
            }

            // Assert
            Assert.That(listOfElements.Elements.Count, Is.EqualTo(0));
        }
    }
}
