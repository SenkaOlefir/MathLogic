using LogicUnit.Common.Tokens.Base;
using LogicUnit.Common.Vertexes;
using LogicUnit.Common.Vertexes.Base;

namespace LogicUnit.Common.Tokens
{
    sealed class DisjunctionToken : BinaryOperatorToken
    {
        public override string ToString()
        {
            return "|";
        }

        public override int Priority { get; protected set; }

        public DisjunctionToken()
        {
            Priority = 4;
        }

        public override Vertex GenerateVertex()
        {
            return new DisjunctionVertex();
        }
    }
}
