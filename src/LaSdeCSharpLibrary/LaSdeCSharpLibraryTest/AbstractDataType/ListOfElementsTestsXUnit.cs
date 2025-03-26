using System;
using System.IO;
using System.Collections.Generic;
using Xunit;
using LaSdeCSharpLibrary.AbstractDataType;

namespace LaSdeCSharpLibrary.Tests
{
    public class ListOfElementsTests
    {
        [Fact]
        public void Constructor_InitializesEmptyList()
        {
            // Arrange & Act
            var listOfElements = new ListOfElements();

            // Assert
            Assert.NotNull(listOfElements.Elements);
            Assert.Empty(listOfElements.Elements);
        }

        [Fact]
        public void LoadLines_TextReader_AddsLinesToList()
        {
            // Arrange
            var listOfElements = new ListOfElements();
            var text = "Line1\nLine2\nLine3";
            using (var reader = new StringReader(text))
            {
                // Act
                listOfElements.LoadLines(reader);
            }

            // Assert
            Assert.Equal(3, listOfElements.Elements.Count);
            Assert.Equal("Line1", listOfElements.Elements[0]);
            Assert.Equal("Line2", listOfElements.Elements[1]);
            Assert.Equal("Line3", listOfElements.Elements[2]);
        }

        [Fact]
        public void LoadLines_String_AddsLinesToList()
        {
            // Arrange
            var listOfElements = new ListOfElements();
            var text = "Line1\nLine2\nLine3";

            // Act
            listOfElements.LoadLines(text);

            // Assert
            Assert.Equal(3, listOfElements.Elements.Count);
            Assert.Equal("Line1", listOfElements.Elements[0]);
            Assert.Equal("Line2", listOfElements.Elements[1]);
            Assert.Equal("Line3", listOfElements.Elements[2]);
        }

        [Fact]
        public void LoadLines_TextReader_Null_ThrowsArgumentNullException()
        {
            // Arrange
            var listOfElements = new ListOfElements();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => listOfElements.LoadLines((TextReader)null));
        }

        [Fact]
        public void LoadLines_String_Null_ThrowsArgumentNullException()
        {
            // Arrange
            var listOfElements = new ListOfElements();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => listOfElements.LoadLines((string)null));
        }
    }
}
