using System;
using System.Text;

namespace LogicUnit.Common.Vertexes
{
    public class EquivalenceVertex : Base.Vertex
    {
        public override Int32 ChildCount
        {
            get { return 2; }
        }
        public EquivalenceVertex() { }
        
        public override Boolean GetResult()
        {
            Base.Vertex left = ChildList[0];
            Base.Vertex right = ChildList[1];

            //throw new NotImplementedException();
            return (left.GetResult() == right.GetResult());
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("<=>");
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
