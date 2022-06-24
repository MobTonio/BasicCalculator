using Microsoft.VisualStudio.TestTools.UnitTesting;
using PolishAdvancedConversion;
using System.Collections.Generic;
using System;

namespace CalculatorUnitTests
{
    [TestClass]
    public class PolishAdvancedConversionUnitTest
    {
        /// Пример вводных данных : Min(23 + 40, 65 + 12, 4 * 12 + 17) - 5
        /// Пример выходных данных : -( Min( +(23, 40) , +(65, 12) , +( *(4,12) , 17) ) , 5)
        /// 

        [TestMethod]
        public void TestMethod0()
        {
            var input = new List<PolishAdvancedConversion.Token>()
            {
                new Token("23",TokenType.Value), 
                new Token("+",TokenType.Level1Operator), 
                new Token("40",TokenType.Value)
            };

            var expected = new List<PolishAdvancedConversion.Token>()
            {
                new Token("+",TokenType.Level1Operator),
                    new Token("(",TokenType.OpeningBracket),
                        new Token("23",TokenType.Value),
                        new Token(",",TokenType.Comma),
                        new Token("40",TokenType.Value),
                    new Token(")",TokenType.ClosingBracket)
            };

            var output = PolishAdvancedConversion.Converter.Convert(input);

            for (int i = 0; i < output.Count; i++)
            {
                Assert.AreEqual(expected[i].Code, output[i].Code);
            }
        }

        [TestMethod]
        public void TestMethod1()
        {
            var input = new List<PolishAdvancedConversion.Token>()
            {
                new Token("Min",TokenType.Function),
                new Token("(",TokenType.OpeningBracket),
                    new Token("1",TokenType.Value),
                    new Token(",",TokenType.Comma),
                    new Token("2",TokenType.Value),
                    new Token(",",TokenType.Comma),
                    new Token("3",TokenType.Value),
                    new Token(",",TokenType.Comma),
                    new Token("4",TokenType.Value),
                    new Token(",",TokenType.Comma),
                    new Token("5",TokenType.Value),
                new Token(")",TokenType.ClosingBracket)
            };

            var expected = new List<PolishAdvancedConversion.Token>()
            {
                new Token("Min",TokenType.Function),
                new Token("(",TokenType.OpeningBracket),
                    new Token("1",TokenType.Value),
                    new Token(",",TokenType.Comma),
                    new Token("2",TokenType.Value),
                    new Token(",",TokenType.Comma),
                    new Token("3",TokenType.Value),
                    new Token(",",TokenType.Comma),
                    new Token("4",TokenType.Value),
                    new Token(",",TokenType.Comma),
                    new Token("5",TokenType.Value),
                new Token(")",TokenType.ClosingBracket)
            };

            var output = PolishAdvancedConversion.Converter.Convert(input);
            var expectedString = "";
            var outputString = "";
            for (int i = 0; i < output.Count; i++)
            {
                outputString += output[i].Code + " ";
            }

            for (int i = 0; i < expected.Count; i++)
            {
                expectedString += expected[i].Code + " ";
            }

            Assert.AreEqual(expectedString, outputString);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var input = new List<PolishAdvancedConversion.Token>()
            {
                new Token("Min",TokenType.Function), 
                new Token("(",TokenType.OpeningBracket),
                new Token("23",TokenType.Value), new Token("+",TokenType.Level1Operator), new Token("40",TokenType.Value), 
                new Token(",",TokenType.Comma),
                new Token("65",TokenType.Value), new Token("+",TokenType.Level1Operator), new Token("12",TokenType.Value), 
                new Token(",",TokenType.Comma),
                new Token("4",TokenType.Value), new Token("*",TokenType.Level2Operator), 
                new Token("12",TokenType.Value), new Token("+",TokenType.Level1Operator), new Token("17",TokenType.Value), 
                new Token(")",TokenType.ClosingBracket), new Token("-",TokenType.Level1Operator), new Token("5",TokenType.Value)
            };

            var expected = new List<PolishAdvancedConversion.Token>()
            {
                new Token("-",TokenType.Level1Operator),
                    new Token("(",TokenType.OpeningBracket),
                        new Token("Min",TokenType.Function),
                            new Token("(",TokenType.OpeningBracket),
                                new Token("+",TokenType.Level1Operator),
                                    new Token("(",TokenType.OpeningBracket),
                                        new Token("23",TokenType.Value),
                                        new Token(",",TokenType.Comma),
                                        new Token("40",TokenType.Value),
                                    new Token(")",TokenType.ClosingBracket),
                                new Token(",",TokenType.Comma),
                                new Token("+",TokenType.Level1Operator),
                                    new Token("(",TokenType.OpeningBracket),
                                        new Token("65",TokenType.Value),
                                        new Token(",",TokenType.Comma),
                                        new Token("12",TokenType.Value),
                                    new Token(")",TokenType.ClosingBracket),
                                new Token(",",TokenType.Comma),
                                new Token("+",TokenType.Level1Operator),
                                    new Token("(",TokenType.OpeningBracket),
                                        new Token("*",TokenType.Level2Operator),
                                            new Token("(",TokenType.OpeningBracket),
                                                new Token("4",TokenType.Value),
                                                new Token(",",TokenType.Comma),
                                                new Token("12",TokenType.Value),
                                            new Token(")",TokenType.ClosingBracket),
                                            new Token(",",TokenType.Comma),
                                            new Token("17",TokenType.Value),
                                    new Token(")",TokenType.ClosingBracket),
                            new Token(")",TokenType.ClosingBracket),
                            new Token(",",TokenType.Comma),
                            new Token("5",TokenType.Value),
                    new Token(")",TokenType.ClosingBracket)
            };

            var output = PolishAdvancedConversion.Converter.Convert(input);

            var expectedString = "";
            var outputString = "";
            for (int i = 0; i < output.Count; i++)
            {
                outputString += output[i].Code + " ";
            }

            for (int i = 0; i < expected.Count; i++)
            {
                expectedString += expected[i].Code + " ";
            }

            Assert.AreEqual(expectedString, outputString);
        }
    }
}
