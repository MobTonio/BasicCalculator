using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using CalculatorInterpritator;

namespace CalculatorUnitTests
{
    [TestClass]
    public class CalculatorInterpritatorUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Parser parser = new Parser();
            var input = "Min(23 + 40, 65 + 12, 4 * 12 + 17) - 5";
            var expected = "Subtraction Min Addition 23 40 Addition 65 12 Addition Multiplication 4 12 17 5";
            var tree_output = parser.Parce(input);
            var output = tree_output.Log();

            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void TestMethodAnalize()
        {
            Analiser analiser = new Analiser();
            var input = "Min(23 + 40, 65 + 12, 4 * 12 + 17) - 5";
            var expected = new List<Token>()
            {
                new Token(0,"Min"),
                new Token(0,"("),
                new Token(0,"23"), new Token(0,"Addition"), new Token(0,"40"),
                new Token(0,","),
                new Token(0,"65"), new Token(0,"Addition"), new Token(0,"12"),
                new Token(0,","),
                new Token(0,"4"), new Token(0,"Multiplication"),
                new Token(0,"12"), new Token(0,"Addition"), new Token(0,"17"),
                new Token(0,")"), new Token(0,"Subtraction"), new Token(0,"5")
            };
            var output = analiser.Analise(input);

            for (int i = 0; i < expected.Count; i++)
            Assert.AreEqual(expected[i].Value, output[i].Value);
        }
    }
}
