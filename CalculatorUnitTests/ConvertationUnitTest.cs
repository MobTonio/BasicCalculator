using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Convertation;

namespace CalculatorUnitTests
{
    [TestClass]
    public class ConvertationUnitTest         
    {
        [TestMethod]
        public void TestMethod1()
        {
            uint A = 3;
            Assert.AreEqual(A, Convertation.Convertation.ConvertToNumber(A));
        }
    }
}
