using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ASP.NET._1607.Day1.Task1.Suhov.Tests
{
    [TestClass]
    public class SimpleCheckTest
    {
        [TestMethod]
        public void TestIsSimpleSimpleValues()
        {
            // Arrange
            var arr = new List<int>() { 2, 3, 5, 7, 11, 13 };
            // Act
            // Assert
            arr.ForEach(delegate (int numb) {
                Assert.IsTrue(SimpleCheck.IsSimple(numb));
            });
        }
        [TestMethod]
        public void TestIsSimpleNotSimpleValues()
        {
            // Arrange
            var arr = new List<int>() { 4, 6, 8, 9, 10, 14 };
            // Act
            // Assert
            arr.ForEach(delegate (int numb) {
                Assert.IsFalse(SimpleCheck.IsSimple(numb));
            });
        }

    }
}
