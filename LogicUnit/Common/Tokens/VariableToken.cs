using System;
using LogicUnit.Common.Tokens.Base;

namespace LogicUnit.Common.Tokens
{
    sealed class VariableToken : Token
    {
        public override string ToString()
        {
            return Name;
        }

        private readonly String _name;

        public VariableToken(String name)
        {
            _name = name;
        }

        public String Name
        {
            get { return _name; }
        }

    }
}
