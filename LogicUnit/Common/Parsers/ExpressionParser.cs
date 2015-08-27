using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LogicUnit.Common.Tokens;
using LogicUnit.Common.Tokens.Base;
using LogicUnit.Common.Vertexes;
using LogicUnit.Common.Vertexes.Base;

namespace LogicUnit.Common.Parsers
{
    //TODO: Bug with !=
    public static class ExpressionParser
    {

        private static List<Token> _tokenList; 

        public static Vertex Parse(String inputString)
        {
            _tokenList = Tokenizer.Tokenize(inputString);

            Int32 equalityCount = _tokenList.Count(token => token is EqualityToken);
            
            //TODO: Move check below away from here
            //if (equalityCount != 1)
            //{
            //    throw new Exception("Expression must have one =");
            //}

            MakeRPN();
            //var sb = new StringBuilder();
            //foreach (var token in _tokenList)
            //{
            //    sb.Append(token);
            //}
            //Console.WriteLine("RPN: {0}", sb);
            return Parse();
        }

        private static void MakeRPN()
        {
            var opStack = new Stack<Token>();
            var newList = new List<Token>();

            foreach (var token in _tokenList)
            {
                if (token is VariableToken || token is LogicValueToken)
                {
                    newList.Add(token);
                    continue;
                }

                if (token is OperatorToken)
                {
                    var current = token as OperatorToken;
                    var currentPriority = current.Priority;

                    OperatorToken peek = null;
                    if (opStack.Count > 0)
                    {
                        peek = opStack.Peek() as OperatorToken;
                    }
                    while (opStack.Count > 0 && peek != null && peek.Priority >= currentPriority)
                    {
                        newList.Add(opStack.Pop());
                        peek = (opStack.Count > 0) ? opStack.Peek() as OperatorToken : null;
                        
                    }
                    opStack.Push(token);
                    continue;
                }

                if (token is OpenParenthesisToken)
                {
                    opStack.Push(token);
                    continue;
                }

                if (token is CloseParenthesisToken)
                {
                    while (opStack.Count > 0 && !(opStack.Peek() is OpenParenthesisToken))
                    {
                        newList.Add(opStack.Pop());
                    }
                    if (opStack.Count == 0)
                    {
                        throw new Exception("RPN: Unpaired parentheses");                        
                    }
                    opStack.Pop();
                    continue;
                }

                throw new Exception("RPN: Unsupported token");
            }

            newList.AddRange(opStack);
            _tokenList = newList;
        }

        private static Vertex Parse()
        {
            var myStack = new Stack<Vertex>();

            foreach (var token in _tokenList)
            {
                if (token is VariableToken)
                {
                    var varToken = (VariableToken)token;
                    var varVertex = new VariableVertex(varToken.Name);
                    myStack.Push(varVertex);
                    continue;
                }

                if (token is LogicValueToken)
                {
                    var logicToken = (LogicValueToken)token;
                    var logicVertex = new LogicValueVertex(logicToken.Value);
                    myStack.Push(logicVertex);
                    continue;
                }

                if (token is OperatorToken)
                {
                    var opToken = (OperatorToken)token;
                    var vertex = opToken.GenerateVertex();

                    if (myStack.Count < vertex.ChildCount)
                    {
                        throw new Exception("Parser: Invalid expression (stack is too small)");
                    }
                    
                    for (var i = 0; i < vertex.ChildCount; i++)
                    {
                        vertex.AddChild(myStack.Pop());
                    }
                    myStack.Push(vertex);

                    continue;
                }

                if (token is OpenParenthesisToken || token is CloseParenthesisToken)
                {
                    throw new Exception("Parser: Parenthesis occured"); 
                }

                throw new Exception("Parser: Unsupported token");
            }

            if (myStack.Count != 1)
            {
                throw new Exception("Parser: Invalid expression (vertex stack count != 1)");
            }

            return myStack.Pop();
        }

    }
}
