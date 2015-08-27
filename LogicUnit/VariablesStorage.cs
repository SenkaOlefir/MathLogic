using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicUnit
{
    internal sealed class VariablesStorage
    {
        private static VariablesStorage _instance;
        private Dictionary<String, Boolean> _variables;

        public static VariablesStorage Instance
        {
            get { return _instance; }
        }

        private VariablesStorage()
        {
            _variables = new Dictionary<String, Boolean>();
        }

        public static void CreateStorage()
        {
            if (_instance != null) return;

            _instance = new VariablesStorage();
        }

        public Dictionary<String, Boolean> Variables { get { return _variables; } private set {} }

        public void AddToList(String key, Boolean value = false)
        {
            if (_variables.ContainsKey(key))
            { 
                throw new Exception("Key already present in keylist");
            }
            else
            {
                _variables.Add(key, value);
            }
        }
    }
}
