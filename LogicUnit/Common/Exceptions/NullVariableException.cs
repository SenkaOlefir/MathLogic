using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicUnit.Common.Exceptions
{
    public class NullVariableException : Exception
    {
        public NullVariableException() : base() { }
        public NullVariableException(String message) : base(message) { }
    }
}
