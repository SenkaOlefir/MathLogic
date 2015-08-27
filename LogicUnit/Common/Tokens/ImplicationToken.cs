using System;
using LogicUnit.Common.Tokens.Base;
using LogicUnit.Common.Vertexes;
using LogicUnit.Common.Vertexes.Base;

namespace LogicUnit.Common.Tokens
{
    sealed class ImplicationToken : BinaryOperatorToken
    {
        public override string ToString()
        {
            return "->";
        }

        public override int Priority { get; protected set; }

        public ImplicationToken()
        {
            Priority = 3;
        }

        public override Vertex GenerateVertex()
        {
            return new ImplicationVertex();
        }
    }
}
