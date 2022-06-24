using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using MathOperations;
using System;

namespace CalculatorUnitTests
{
    [TestClass]
    public class MathOperationsUnitTest
    {
        [TestMethod]
        public void TestMethodAddition()
        {
            List<object> input = new List<object>()
            {
                (double)5,
                (double)7
            };
            double expected = 12;

            var result = MathOp.Execute("Addition", input);


            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethodCosinus()
        {
            List<object> input = new List<object>()
            {
                (double)Math.PI
            };
            double expected = -1;

            var result = MathOp.Execute("Cosinus", input);


            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethodDivision()
        {
            List<object> input = new List<object>()
            {
                (double)12,
                (double)5
            };
            double expected = 2.4;

            var result = MathOp.Execute("Division", input);


            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethodFactorial()
        {
            List<object> input = new List<object>()
            {
                5
            };
            double expected = 120;

            var result = MathOp.Execute("Factorial", input);


            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethodMaximum()
        {
            List<object> input = new List<object>()
            {
                (double)5,
                (double)7,
                (double)8,
                (double)12,
                (double)15
            };
            double expected = 15;

            var result = MathOp.Execute("Maximum", input);


            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethodMinimum()
        {
            List<object> input = new List<object>()
            {
                (double)5,
                (double)7,
                (double)8,
                (double)12,
                (double)15
            };
            double expected = 5;

            var result = MathOp.Execute("Minimum", input);


            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethodMultiplication()
        {
            List<object> input = new List<object>()
            {
                (double)5,
                (double)7
            };
            double expected = 35;

            var result = MathOp.Execute("Multiplication", input);


            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethodPower()
        {
            List<object> input = new List<object>()
            {
                (double)5,
                (double)7
            };
            double expected = 78125;

            var result = MathOp.Execute("Power", input);


            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethodSinus()
        {
            List<object> input = new List<object>()
            {
                (double)Math.PI
            };
            double expected = 0;

            var result = MathOp.Execute("Sinus", input);


            Assert.IsTrue(Math.Abs(expected - (double)result) < 0.00000001);
        }

        [TestMethod]
        public void TestMethodSubtraction()
        {
            List<object> input = new List<object>()
            {
                (double)12.4,
                (double)5.21
            };
            double expected = 7.19;

            var result = MathOp.Execute("Subtraction", input);


            Assert.AreEqual(expected, result);
        }
    }
}
