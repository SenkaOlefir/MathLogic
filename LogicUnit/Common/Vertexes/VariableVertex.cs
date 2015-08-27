using LogicUnit.Common.Exceptions;
using System;
using System.Collections.Generic;

namespace LogicUnit.Common.Vertexes
{
    public class VariableVertex : Base.Vertex
    {
        public override Int32 ChildCount
        {
            get { return 0; }
        }

        private readonly String _name;
        private readonly Boolean? _value;

        public VariableVertex(String name, Boolean? value = null)
        {
            _name = name;
            _value = value;
        }

        public String Name
        {
            get { return _name; }
        }
        public Boolean? Value
        {
            get 
            {
                if (_value.HasValue)
                {
                    return _value;
                }
                else
                {
                    try
                    {
                        return VariablesStorage.Instance.Variables[_name];
                    }
                    catch (KeyNotFoundException)
                    {
                        return null;
                    }
                }
            }
        }

        public override Boolean GetResult()
        {
            if (Value != null)
            {
                return (Boolean) Value;
            }
            else
            {
                throw new NullVariableException(String.Format("Trying to calculate null value of {0} variable ", _name));
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
