using System;
using System.Text;

namespace LogicUnit.Common.Vertexes
{
    public class ComplementVertex : Base.Vertex
    {
        public override Int32 ChildCount
        {
            get { return 1; }
        }

        public ComplementVertex()
        {
            //Console.WriteLine("test");
            //Console.WriteLine(this);
            //Console.WriteLine(ChildList.Capacity);
            //ChildList.Add(new LogicValueVertex(false));
        }

        public override Boolean GetResult()
        {
            //throw new NotImplementedException();
            return !ChildList[0].GetResult();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("!");
            sb.Append("(");
            sb.Append(ChildList[0]);
            sb.Append(")");
            return sb.ToString();
        }
    }
}
