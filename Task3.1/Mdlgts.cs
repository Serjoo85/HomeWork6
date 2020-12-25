using System;
using System.Collections.Generic;
using System.Linq;

namespace Task3._1
{
    public class Mdlgts
    {        
        internal Func<Student, Student, int> f = null;
        private readonly List<Func<Student, Student, int>> delList;
        public Mdlgts(List<Func<Student, Student, int>> delList)
        {
            this.delList = delList;
        }

        internal int Add(int x)
        {
            f += delList[x - 1];
            x = f.GetInvocationList().ToList().Count();
            return x;
        }

        internal void Remove(int x)
        {
            f -= delList[x - 1];            
        }

        internal void Reset()
        {
            f = null;
        }
    }
}
