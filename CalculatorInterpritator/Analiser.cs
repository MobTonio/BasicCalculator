using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorInterpritator
{
    public class Token
    {
        public int Code { get; }
        public string Value { get; }

        public Token(int code, string value)
        {
            Code = code;
            Value = value;
        }
    }

    public class Analiser
    {
        public Dictionary<string, int> Operators { get; set; }

        public Dictionary<string, int> Functions { get; set; }

        public Analiser()
        {
            Operators = new Dictionary<string, int>()
            {
                ["+"] = 1,
                ["-"] = 2,
                ["*"] = 3,
                ["/"] = 4,
                ["^"] = 5,
                ["("] = 11,
                [","] = 13
            };

            Functions = new Dictionary<string, int>()
            {
                ["!"] = 6,
                ["Min"] = 7,
                ["Max"] = 8,
                ["Cos"] = 9,
                ["Sin"] = 10,
                [")"] = 12,
                ["!"] = 13
            };
        }

        string _expr;

        public List<Token> Analise(string expr)
        {
            var tokens = new List<Token>();
            _expr = expr;

            expr = expr.Replace("+-", "-");
            expr = expr.Replace("-+", "-");
            expr = expr.Replace("--", "+");

            for (var i = 0; i < expr.Length; i++)
            {
                var ch = expr[i];

                if (char.IsWhiteSpace(ch)) continue;

                if (char.IsLetter(ch))
                {
                    if (i != 0 && (char.IsDigit(expr[i - 1]) || expr[i - 1] == ')'))
                    {
                        tokens.Add(new Token(3, "Multiplication"));
                    }

                    tokens.Add(LetterAnalyse(ref i));

                    continue;
                }

                if (char.IsDigit(ch) || ch == '.')
                {
                    if (i != 0 && expr[i - 1] == ')')
                    {
                        tokens.Add(new Token(3, "Multiplication"));
                    }

                    tokens.Add(DigitAnalise(ref i));

                    continue;
                }

                if (ch == '[')
                {
                    if (i != 0 && expr[i - 1] == ')')
                    {
                        tokens.Add(new Token(3, "Multiplication"));
                    }

                    tokens.Add(MatrixAnalise(ref i));

                    continue;
                }

                if (ch == '<')
                {
                    if (i != 0 && expr[i - 1] == ')')
                    {
                        tokens.Add(new Token(3, "Multiplication"));
                    }

                    tokens.Add(FunctionAnalise(ref i));

                    continue;
                }

                if (i + 1 < expr.Length &&
                    ch == '-' &&
                    char.IsDigit(expr[i + 1]) &&
                    (i == 0 || i + 1 < expr.Length && Operators.ContainsValue(tokens.Last().Code) || i - 1 > 0 && expr[i - 1] == '('))
                {
                    tokens.Add(DigitAnalise(ref i));

                    continue;
                }

                switch (ch)
                {
                    case '+': tokens.Add(new Token(1, "Addition")); break;
                    case '-': tokens.Add(new Token(2, "Subtraction")); break;
                    case '*': tokens.Add(new Token(3, "Multiplication")); break;
                    case '/': tokens.Add(new Token(4, "Division")); break;
                    case '^': tokens.Add(new Token(5, "Power")); break;
                    case '(': tokens.Add(new Token(11, "(")); break;
                    case ')': tokens.Add(new Token(12, ")")); break;
                    case ',': tokens.Add(new Token(13, ",")); break;
                    case '!': tokens.Add(new Token(14, "Factorial")); break;
                    default: throw new Exception("Unexpected variable");
                }
            }

            return tokens;
        }


        private Token LetterAnalyse(ref int i)
        {
            var tokenVal = _expr[i] + "";

            while (i + 1 < _expr.Length && char.IsLetterOrDigit(_expr[i + 1]))
            {
                tokenVal += _expr[++i];
            }

            if (Functions.ContainsKey(tokenVal)) 
                return new Token(Functions.First(x => x.Key.Equals(tokenVal)).Value, tokenVal);
            else 
                throw new Exception("Incorrect input of operator");
            
        }

        private Token DigitAnalise(ref int i)
        {
            var tokenVal = _expr[i] + "";

            while (i + 1 < _expr.Length && (char.IsDigit(_expr[i + 1]) || _expr[i + 1] == '.'))
            {
                tokenVal += _expr[++i];
            }

            return new Token(0, tokenVal);
        }

        private Token MatrixAnalise(ref int i)
        {
            var tokenVal = _expr[i] + "";
            int bracketcount = 1;
            try
            {
                do
                {
                    tokenVal += _expr[++i];
                    if (_expr[i] == ']') bracketcount--;
                    if (_expr[i] == '[') bracketcount++;
                } while (bracketcount > 0);
            } catch (Exception e)
            {
                throw new Exception("incorrect matrix creation");
            }

            return new Token(0, tokenVal);
        }

        private Token FunctionAnalise(ref int i)
        {
            throw new NotImplementedException();
        }
    }
}


