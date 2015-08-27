using LogicUnit.Common.Parsers;
using Vertexes = LogicUnit.Common.Vertexes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicUnit.Common.Exceptions;

namespace LogicUnit
{
    public sealed class Class1
    {
        private Dictionary<String, Vertexes.Base.Vertex> _expressions { get; set; }

        public List<String> Expressions
        {
            get
            {
                return _expressions.Select(e => e.Key).ToList();
            }
            set
            {
                _expressions = value
                    .Distinct()
                    .Select(e => new { Key = e, Value = ExpressionParser.Parse(e) })
                    .ToDictionary(item => item.Key, item => item.Value);
            }
        }
        
        public Class1()
        {
            _expressions = new Dictionary<string, Vertexes.Base.Vertex>();
            VariablesStorage.CreateStorage();
        }

        public Boolean CalculateExpressions(Int32? index = null)
        {
            VariablesStorage.Instance.Variables.Clear();

            List<Boolean> calculateResults = _expressions.Select(e => e.Value.GetResult()).ToList();

            return (index.HasValue) ? calculateResults[(Int32)index] : calculateResults.Last();
        }

        public Dictionary<String, Boolean> ForceCalculateExpressions()
        {
            VariablesStorage.Instance.Variables.Clear();
            Dictionary<String, Boolean> calculatedExpressions = new Dictionary<String, Boolean>();

            Int32 calculatedExpressionsCount;

            do
            {
                calculatedExpressionsCount = calculatedExpressions.Count;
                foreach (String expression in _expressions.Where(e => !calculatedExpressions.ContainsKey(e.Key)).Select(e => e.Key))
                {
                    try
                    {
                        calculatedExpressions.Add(expression, ExpressionParser.Parse(expression).GetResult());
                    }
                    catch (NullVariableException)
                    {
                        continue;
                    }
                }

            } while (calculatedExpressions.Count != calculatedExpressionsCount);

            return calculatedExpressions;
        }

        public void AddExpression(String expression)
        {
            if (_expressions.ContainsKey(expression))
            {
                throw new Exception("Expression already present on key list");
            }

            _expressions.Add(expression, ExpressionParser.Parse(expression));
        }

        public Boolean DeleteExpression(String expression)
        {
            return _expressions.Remove(expression);
        }

        public List<String> GetVariableList()
        {
            return new List<String>(VariablesStorage.Instance.Variables.Keys);
        }

        public Dictionary<String, Boolean> GetVariables()
        {
            return VariablesStorage.Instance.Variables;
        }
    }
}
