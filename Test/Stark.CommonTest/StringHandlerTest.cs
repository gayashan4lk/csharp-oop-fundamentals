using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stark.Common;
using System;

namespace Stark.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {
            // Arrange
            var source = "IngcoScrewdriver";
            var expected = "Ingco Screwdriver";
            //var handler = new StringHandler();

            // Act
            //var actual = StringHandler.InsertSpaces(source);
            var actual = source.InsertSpaces();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertSpacesTestWithExistingSpace()
        {
            // Arrange
            var source = "Ingco Screwdriver";
            var expected = "Ingco Screwdriver";
            //var handler = new StringHandler();

            // Act
            //var actual = StringHandler.InsertSpaces(source);
            var actual = source.InsertSpaces();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
