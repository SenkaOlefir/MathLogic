using System;
using System.Text;

namespace LogicUnit.Common.Vertexes
{
    public class EqualityVertex : Base.Vertex
    {
        public override Int32 ChildCount
        {
            get { return 2; }
        }
        public EqualityVertex()
        {
            //throw new NotImplementedException();
        }

        public override Boolean GetResult()
        {
            Base.Vertex left = ChildList[0];
            Base.Vertex right = ChildList[1];

            if (right is VariableVertex)
            {
                VariableVertex variableVertex = right as VariableVertex;
                VariablesStorage.Instance.Variables.Add(variableVertex.Name, left.GetResult());
                return left.GetResult();
            }

            if (left is VariableVertex)
            {
                VariableVertex variableVertex = left as VariableVertex;
                VariablesStorage.Instance.Variables.Add(variableVertex.Name, right.GetResult());
                return left.GetResult();
            }

            return false;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("=");
            sb.Append("(");
            for (var i = 0; i < ChildCount; i++)
            {
                sb.Append(ChildList[i]);
                if (i + 1 < ChildCount)
                {
                    sb.Append(", ");
                }
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}
