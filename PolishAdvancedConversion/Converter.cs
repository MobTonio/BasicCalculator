using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolishAdvancedConversion
{
    public class Token
    {
        public string Code { get; }
        public TokenType Value { get; }

        public int Priority { get; private set; }

        public Token(string code, TokenType value)
        {
            Code = code;
            Value = value;
        }

        public void SetPriority(int val)
        {
            Priority = val;
        }
    }

    public struct ConvertedPart
    {
        public int start;
        public int end;
    }
    
    public static class Converter
    {
        public readonly static int BracketAddedPriority = 6;
        public readonly static Dictionary<TokenType, int> priorities = new Dictionary<TokenType, int>()
        {
            [TokenType.Level1Operator] = 0,
            [TokenType.Level2Operator] = 1,
            [TokenType.Level3Operator] = 2,
            [TokenType.Level4Operator] = 3,
            [TokenType.Modifier] = 4,
            [TokenType.Function] = 5
        };

        /// <summary>
        /// Приводит выражение в систематизированный вид по типу польской записи 
        /// Отличие от обычной польской записи в том что у операций тут может быть неопределенное число операндов
        /// Пример вводных данных : Min(23 + 40, 65 + 12, 4 * 12 + 17) - 5
        /// Пример выходных данных : -( Min( +(23, 40) , +(65, 12) , +( *(4,12) , 17) ) , 5)
        /// </summary>
        public static List<Token> Convert(List<Token> tokens)
        {
            SetPriorities(tokens);
            return ConvertPart(tokens,0,tokens.Count);
        }

        public static void SetPriorities(List<Token> tokens)
        {
            int braketBasedPriority = 0;
            for (int i = 0; i < tokens.Count; i++)
            {
                if (priorities.ContainsKey(tokens[i].Value))
                {
                    tokens[i].SetPriority(GetOperatorPriority(tokens[i].Value) + braketBasedPriority);
                    continue;
                }
                tokens[i].SetPriority(-1);
                switch (tokens[i].Value)
                {
                    case TokenType.Value: continue;
                    case TokenType.Comma: continue;
                    case TokenType.OpeningBracket: braketBasedPriority += BracketAddedPriority; break;
                    case TokenType.ClosingBracket: 
                        braketBasedPriority -= BracketAddedPriority;
                        if (braketBasedPriority < 0) throw new Exception("Unexpected closing bracket");
                        break;
                    default: throw new Exception("Unundentified token type");
                }
            }
        }

        private static int GetOperatorPriority(TokenType type)
        {
            return priorities.First(x => x.Key == type).Value;
        }


        public static List<Token> ConvertPart(List<Token> tokens, int st, int end)
        {
            List<Token> result = new List<Token>();
            int operations = 0;
            int lowestPriority = 1000000000;
            int lowestOpIndex = -1;

            if (st + 1 == end)
            {
                result.Add(tokens[st]);
                return result;
            }

            for (int i = st; i < end; i++)
            {
                if (tokens[i].Priority >= 0)
                {
                    operations++;
                    if (tokens[i].Priority < lowestPriority)
                    {
                        lowestPriority = tokens[i].Priority;
                        lowestOpIndex = i;
                    }
                }
            }

            if (lowestOpIndex == -1)
            {
                var unlistedVals = tokens
                                        .GetRange(st,end - st)
                                        .FindAll(x => x.Value == TokenType.Value);

                //if (unlistedVals.Count != 1) throw new Exception($"expeted 1 valuble got {unlistedVals.Count}, -> {st} {end}");
                result.AddRange(unlistedVals);
                return result;
            }

            if (tokens[lowestOpIndex].Value == TokenType.Function)
            {
                result.Add(tokens[lowestOpIndex]);
                result.Add(new Token("(", TokenType.OpeningBracket));
                
                List<ConvertedPart> parts = GetParts(tokens, lowestOpIndex + 2);
                
                for (int i = 0; i < parts.Count; i++)
                {
                    var tkns = ConvertPart(tokens, parts[i].start, parts[i].end);
                    result.AddRange(tkns);

                    result.Add(new Token(",",TokenType.Comma));
                }
                result.RemoveAt(result.Count - 1);
                
                result.Add(new Token(")", TokenType.ClosingBracket));
                return result;
            }

            if ((lowestPriority % BracketAddedPriority) == GetOperatorPriority(TokenType.Modifier))
            {
                result.Add(tokens[lowestOpIndex]);
                result.Add(new Token("(", TokenType.OpeningBracket));

                var tkns = ConvertPart(tokens, st, lowestOpIndex);
                result.AddRange(tkns);

                result.Add(new Token(")", TokenType.ClosingBracket));
                return result;
            }
            else
            {
                result.Add(tokens[lowestOpIndex]);
                result.Add(new Token("(", TokenType.OpeningBracket));

                var leftTokens = ConvertPart(tokens, st, lowestOpIndex);
                result.AddRange(leftTokens);

                result.Add(new Token(",", TokenType.Comma));

                var rightTokens = ConvertPart(tokens, lowestOpIndex + 1, end);
                result.AddRange(rightTokens);
                
                result.Add(new Token(")", TokenType.ClosingBracket));
                return result;
            }
        }

        private static List<ConvertedPart> GetParts(List<Token> tokens, int i)
        {
            List<ConvertedPart> parts = new List<ConvertedPart>();
            ConvertedPart part = new ConvertedPart();
            part.start = i;
              
            do {
                i++;
                if (tokens[i].Value == TokenType.OpeningBracket) i = FindEndBraket(tokens, i) + 1;
                if (tokens[i].Value == TokenType.Comma)
                {
                    part.end = i;
                    parts.Add(new ConvertedPart() 
                    { 
                        start = part.start, 
                        end = part.end 
                    });
                    part = new ConvertedPart();
                    part.start = i + 1;
                }
            } while (i < tokens.Count && tokens[i].Value != TokenType.ClosingBracket) ;
            parts.Add(new ConvertedPart()
            {
                start = part.start,
                end = i
            });
            return parts;
        }

        private static int FindEndBraket(List<Token> tokens, int openingBraket)
        {
            int bracketLevel = 1;
            int result = openingBraket;
            do {
                result++;
                if (tokens[result].Value == TokenType.OpeningBracket) bracketLevel++;
                if (tokens[result].Value == TokenType.ClosingBracket) bracketLevel--;
            } while (result < tokens.Count && bracketLevel > 0);
            return result;
        }
    }

    public enum TokenType
    {
        /// <summary>
        /// Функция принимающая в себя один или более значений 
        /// Пример: Min(Value , Value , ... , Value)
        /// </summary>
        Function,
        Value,
        /// <summary>
        /// Функция принимающая в себя ровно два значения слева и справа 1ого уровня
        /// Пример: Value + Value
        /// </summary>
        Level1Operator,
        /// <summary>
        /// Функция принимающая в себя ровно два значения слева и справа 2ого уровня
        /// Пример: Value * Value
        /// </summary>
        Level2Operator,
        /// <summary>
        /// Функция принимающая в себя ровно два значения слева и справа 3ого уровня
        /// Пример: Value ^ Value
        /// </summary>
        Level3Operator,
        Level4Operator,
        /// <summary>
        /// Открывающая скобка
        /// </summary>
        OpeningBracket,
        /// <summary>
        /// Запятая
        /// </summary>
        Comma,
        /// <summary>
        /// Закрывающая скобка
        /// </summary>
        ClosingBracket,
        /// <summary>
        /// Функция принимающая в себя ровно одно значение
        /// Пример: Value!
        /// </summary>
        Modifier
    }
}
