using System;

namespace LogicUnit.Common.Vertexes
{
    public class LogicValueVertex : Base.Vertex
    {
        public override Int32 ChildCount
        {
            get { return 0; }
        }

        private Boolean _logicValue;
        public LogicValueVertex(Boolean value)
        {
            _logicValue = value;
        }

        public override Boolean GetResult()
        {
            return _logicValue;
        }

        public override string ToString()
        {
            return _logicValue.ToString();
        }
    }
}
