using System;
using System.Collections.Generic;
using System.Text;

namespace LogicUnit.Common.Vertexes.Base
{
    public abstract class Vertex
    {
        public abstract Int32 ChildCount { get; }

        //TODO: Modify access for further actions
        protected List<Vertex> ChildList;

        public Vertex()
        {
            ChildList = new List<Vertex>();
        }

        public void AddChild(Vertex child)
        {
            if (ChildCount == 0)
            {
                throw new Exception("Trying to add an child to vertex which can't hold childs");
            }
            if (ChildList.Count >= ChildCount)
            {
                throw new Exception("Trying to add an extra child to vertex");
            }
            ChildList.Add(child);
        }

        public abstract Boolean GetResult();
    }
}
