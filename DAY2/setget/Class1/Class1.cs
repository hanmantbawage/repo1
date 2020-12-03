using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    public class Class2
    {
        private int p1;//everywhere
        public int p2;// accessible in same class

        protected int p3;// accessible in same class && Derived Class
        internal int p4;//accessible in ssame class and same assembly
        protected internal int p5;// same class, derived class,same assembly
    
    
    }
}
