using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using LogicUnit.Common.Tokens;
using LogicUnit.Common.Tokens.Base;

namespace LogicUnit.Common.Parsers
{
    class Tokenizer
    {
        private static StringReader _reader;
        private static Token ParseWord()
        {
            var text = new StringBuilder();

            while (Char.IsLetter((char)_reader.Peek()))
            {
                text.Append((char)_reader.Read());
            }

            var word = text.ToString().ToUpper();

            switch (word)
            {
                case "TRUE":
                    return new LogicValueToken(true);
                case "FALSE":
                    return new LogicValueToken(false);
                default:
                    return new VariableToken(word);
                //throw new Exception("Unexpected keyword, expected boolean");
            }

        }

        private static String GetPotentialOperator(Int32 count)
        {
            String rest = _reader.ReadToEnd();
            if (String.IsNullOrEmpty(rest))
            {
                return null;
            }
            _reader = new StringReader(rest);

            var tmpReader = new StringReader(rest);
            var potentialBuilder = new StringBuilder();

            for (Int32 i = 0; i < count; i++)
            {
                if (tmpReader.Peek() == -1)
                {
                    break;
                }
                potentialBuilder.Append((Char)tmpReader.Read());
            }

            return potentialBuilder.ToString();
        }

        public static List<Token> Tokenize(String input)
        {
            if (String.IsNullOrEmpty(input))
            {
                throw new ArgumentException("Tokenizer: input string is null or empty");
            }

            _reader = new StringReader(input);
            var tokens = new List<Token>();

            while (_reader.Peek() != -1)
            {
                while (Char.IsWhiteSpace((Char)_reader.Peek()))
                {
                    _reader.Read();
                }

                if (_reader.Peek() == -1)
                {
                    break;
                }

                var c = (Char)_reader.Peek();
                Int32 potentialLength;
                String potentialToken;
                switch (c)
                {
                    case '!':
                        tokens.Add(new ComplementToken());
                        _reader.Read();
                        break;
                    case '=':
                        tokens.Add(new EqualityToken());
                        _reader.Read();
                        break;
                    case '(':
                        tokens.Add(new OpenParenthesisToken());
                        _reader.Read();
                        break;
                    case ')':
                        tokens.Add(new CloseParenthesisToken());
                        _reader.Read();
                        break;
                    case '|':
                        tokens.Add(new DisjunctionToken());
                        _reader.Read();
                        break;
                    case '&':
                        tokens.Add(new ConjunctionToken());
                        _reader.Read();
                        break;
                    case '-':
                        potentialLength = 2;
                        potentialToken = GetPotentialOperator(potentialLength);
                        if (potentialToken == "->")
                        {
                            tokens.Add(new ImplicationToken());
                            for (var i = 0; i < potentialLength; i++)
                            {
                                _reader.Read();
                            }
                            break;
                        }
                        throw new Exception(String.Format("Unknown symbol {0}", c));
                    case '<':
                        potentialLength = 3;
                        potentialToken = GetPotentialOperator(potentialLength);
                        if (potentialToken == "<=>")
                        {
                            tokens.Add(new EquivalenceToken());
                            for (var i = 0; i < potentialLength; i++)
                            {
                                _reader.Read();
                            }
                            break;
                        }
                        throw new Exception(String.Format("Unknown symbol {0}", c));
                    default:
                        if (Char.IsLetter(c))
                        {
                            var token = ParseWord();
                            tokens.Add(token);
                        }
                        else
                        {
                            throw new Exception(String.Format("Unknown symbol {0}", c));
                        }
                        break;
                }
            }

            return tokens;
        }
    }
}
