using System;
using LogicUnit.Common.Vertexes;
using LogicUnit.Common.Vertexes.Base;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean a = true;
            Boolean b = false;
            Boolean c = true;

            
            Vertex logicA = new LogicValue(a);
            Vertex logicB = new LogicValue(b);
            Vertex logicC = new LogicValue(c);

            Vertex disjuction = new Disjunction(logicA, logicB);
            Vertex consecution = new Consecution(disjuction, logicC);
            Vertex equivalence = new Equivalence(consecution, logicA);

            Console.WriteLine(equivalence.GetResult());

            Console.ReadKey();

        }
    }
}
