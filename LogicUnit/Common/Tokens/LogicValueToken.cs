using System;
using LogicUnit.Common.Tokens.Base;

namespace LogicUnit.Common.Tokens
{
    sealed class LogicValueToken : Token
    {
        public override string ToString()
        {
            return Value.ToString();
        }

        private readonly Boolean _value;
        public LogicValueToken(Boolean value)
        {
            _value = value;
        }

        public Boolean Value
        {
            get { return _value; }
        }

    }
}
