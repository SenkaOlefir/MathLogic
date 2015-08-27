using LogicUnit.Common.Tokens.Base;
using LogicUnit.Common.Vertexes;
using LogicUnit.Common.Vertexes.Base;

namespace LogicUnit.Common.Tokens
{
    sealed class EquivalenceToken : BinaryOperatorToken
    {
        public override string ToString()
        {
            return "<=>";
        }

        public override int Priority { get; protected set; }

        public EquivalenceToken()
        {
            Priority = 2;
        }

        public override Vertex GenerateVertex()
        {
            return new EquivalenceVertex();
        }
    }
}
