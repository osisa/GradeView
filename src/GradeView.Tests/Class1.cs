using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FluentAssertions;

namespace GradeView.Tests
{
    [TestClass]
    public class GradeViewBasicTest
    {
        [TestMethod]
        public void Test1()
        {
            // arrange
            var argument1 = 2;

            //act
            var result = argument1 * 3;

            //assert
            Assert.AreEqual(6, result);
        }
    }
}
