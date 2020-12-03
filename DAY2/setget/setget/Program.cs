using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace setget
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 o = new Class1();
            o.i = 10;
            Console.WriteLine(o.Display());

            o.set(25);
            Console.WriteLine(o.get());
            Console.ReadLine();

        }
    }
    class Class1
    {
        public int i;
        private int z;

        public int Display()
        {
            return i;
        }
        public void set(int x) {
            z = x;
        }
        public int get()
        {
            return z;
        }

    }
}
