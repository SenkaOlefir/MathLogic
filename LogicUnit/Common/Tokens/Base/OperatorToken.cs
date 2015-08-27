using System;
using LogicUnit.Common.Vertexes.Base;

namespace LogicUnit.Common.Tokens.Base
{
    public abstract class OperatorToken : Token
    {
        public abstract Int32 Priority { get; protected set; }
        public abstract Vertex GenerateVertex();
    }
}
