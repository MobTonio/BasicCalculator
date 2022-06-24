using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CalculatorInterpritator
{
    public class OperationTree
    {
        public string Operation;
        public List<OperationTree> nodes;

        public OperationTree() : this("") { }
        public OperationTree(string operation)
        {
            Operation = operation;
            nodes = new List<OperationTree>();
        }

        public string Log()
        {
            string output = Operation;
            foreach (OperationTree node in nodes)
                output+= " " + node.Log();
            return output;
        }
    }

    public interface IParser
    {
        OperationTree Parce(string expr);
    }

    public class Parser : IParser
    {
        public Dictionary<string, int> Operators { get; set; }

        public Parser()
        {
            Operators = new Dictionary<string, int>()
            {
                ["+"] = 1,
                ["-"] = 2,
                ["*"] = 3,
                ["/"] = 4,
                ["^"] = 5,
                ["Min"] = 6,
                ["Max"] = 7,
                ["Cos"] = 8,
                ["Sin"] = 9,
                ["("] = 10,
                [")"] = 11
            };
        }

        public OperationTree Parce(string expr)
        {
            var analiser = new Analiser();
            var tokens = TokenConversion(analiser.Analise(expr));

            var polishedTokens = PolishAdvancedConversion
                                                    .Converter
                                                    .Convert(tokens);


            int i = 0;
            return PlaceOnTree(polishedTokens, ref i);
        }

        private List<PolishAdvancedConversion.Token> TokenConversion(List<Token> tokens)
        {
            List<PolishAdvancedConversion.Token> convertedTokens = new List<PolishAdvancedConversion.Token>();
            
            foreach (var token in tokens)
            {
                PolishAdvancedConversion.TokenType type;

                switch (token.Code)
                {
                    case 0: type = PolishAdvancedConversion.TokenType.Value; break;

                    case 1: type = PolishAdvancedConversion.TokenType.Level1Operator; break;
                    case 2: type = PolishAdvancedConversion.TokenType.Level1Operator; break;

                    case 3: type = PolishAdvancedConversion.TokenType.Level2Operator; break;
                    case 4: type = PolishAdvancedConversion.TokenType.Level2Operator; break;

                    case 5: type = PolishAdvancedConversion.TokenType.Level3Operator; break;

                    case 6: type = PolishAdvancedConversion.TokenType.Modifier; break;

                    case 7: type = PolishAdvancedConversion.TokenType.Function; break;
                    case 8: type = PolishAdvancedConversion.TokenType.Function; break;
                    case 9: type = PolishAdvancedConversion.TokenType.Function; break;
                    case 10: type = PolishAdvancedConversion.TokenType.Function; break;

                    case 11: type = PolishAdvancedConversion.TokenType.OpeningBracket; break;
                    case 12: type = PolishAdvancedConversion.TokenType.ClosingBracket; break;

                    case 13: type = PolishAdvancedConversion.TokenType.Comma; break;
                    case 14: type = PolishAdvancedConversion.TokenType.Modifier; break;

                    default: throw new Exception("unexpected token Code"); 
                }

                convertedTokens.Add(
                    new PolishAdvancedConversion
                                        .Token(token.Value, type));
            }

            return convertedTokens;
        }

        private OperationTree PlaceOnTree(List<PolishAdvancedConversion.Token> polishedTokens, ref int i)
        {
            OperationTree tree = new OperationTree(polishedTokens[i].Code);

            if (polishedTokens[i].Value == PolishAdvancedConversion.TokenType.Value)
            {
                i++;
                return tree;
            }
            if (polishedTokens[i].Value == PolishAdvancedConversion.TokenType.Comma 
                || polishedTokens[i].Value == PolishAdvancedConversion.TokenType.OpeningBracket
                || polishedTokens[i].Value == PolishAdvancedConversion.TokenType.ClosingBracket)
            {
                throw new Exception($"inexpected symbol {polishedTokens[i].Value} (Index - {i})");
            }
            else
            {                                                                                               // Пример :        Min ( Value , Value , + ( Value , Value ) )
                i++;                                                                                        // переходим на скопку ^
                do                                                                                          // Пример :        Min ( Value , Value , + ( Value , Value ) )
                {                                                                                           // Тело цикла вып. на  ^       ^       ^
                    i++;
                    OperationTree branch = PlaceOnTree(polishedTokens, ref i);
                    tree.nodes.Add(branch);
                } while ( i < polishedTokens.Count && polishedTokens[i].Value != PolishAdvancedConversion.TokenType.ClosingBracket);
                i++;
                return tree;
            }
        }
    }
}
