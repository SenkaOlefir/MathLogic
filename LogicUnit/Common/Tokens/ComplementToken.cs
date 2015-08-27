using LogicUnit.Common.Tokens.Base;
using LogicUnit.Common.Vertexes;
using LogicUnit.Common.Vertexes.Base;

namespace LogicUnit.Common.Tokens
{
    sealed class ComplementToken : UnaryOperatorToken
    {
        public override string ToString()
        {
            return "!";
        }

        public override int Priority { get; protected set; }

        public ComplementToken()
        {
            Priority = 6;
        }

        public override Vertex GenerateVertex()
        {
            return new ComplementVertex();
        }
    }
}
