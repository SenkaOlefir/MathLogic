using LogicUnit.Common.Tokens.Base;
using LogicUnit.Common.Vertexes;
using LogicUnit.Common.Vertexes.Base;

namespace LogicUnit.Common.Tokens
{
    sealed class EqualityToken : BinaryOperatorToken
    {
        public override string ToString()
        {
            return "=";
        }

        public override int Priority { get; protected set; }

        public EqualityToken()
        {
            Priority = 1;
        }

        public override Vertex GenerateVertex()
        {
            return new EqualityVertex();
        }
    }
}
