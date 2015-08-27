using System.Runtime.Remoting.Messaging;
using LogicUnit.Common.Tokens.Base;
using LogicUnit.Common.Vertexes;
using LogicUnit.Common.Vertexes.Base;

namespace LogicUnit.Common.Tokens
{
    sealed class ConjunctionToken : BinaryOperatorToken
    {
        public override string ToString()
        {
            return "&";
        }

        public override int Priority { get; protected set; }

        public ConjunctionToken()
        {
            Priority = 5;
        }

        public override Vertex GenerateVertex()
        {
            return new ConjunctionVertex();
        }
    }
}
