using System;
using LogicUnit.Common.Parsers;
using LogicUnit.Common.Vertexes.Base;
using LogicUnit;

namespace ParserDev
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter expression: ");

            String expression = null;
            Class1 cl = null;
            Class1 cl2 = null;
            try
            {
                //expression = "!A|B&C->TRUE=!(D<=>E)";
                //expression = "A&(B|C)=D";
                //expression = Console.ReadLine();

                //expression = "!FALSE -> FALSE = bla";
                //expression = "A = FALSE";
                
                cl = new Class1();
                cl2 = new Class1();

                cl.Expressions.AddRange(new String[]
                {
                    "A = false"
                });

                cl2.Expressions.AddRange(new String[]
                {
                    "B = true"
                });

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught while reading expression: {0}", e);
            }

            try
            {
                //Vertex result = ExpressionParser.Parse(expression);
                //Console.WriteLine("Output: {0}", result);
                //Console.WriteLine("Output Result: {0}", result.GetResult());
                cl.CalculateExpressions();
                cl2.CalculateExpressions();
                Console.WriteLine(cl.GetVariables());
            } catch (Exception e) {
                Console.WriteLine("Exception caught while parsing expression: {0}", e);
            }

            Console.ReadLine();
        }
    }
}
