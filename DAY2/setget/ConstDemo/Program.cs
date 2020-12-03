using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 o1 = new Class1();
            Class1 o = new Class1(25);

            Console.ReadLine();
        }
    }
    class Class1
    {
        public Class1() {
            Console.WriteLine("Constuctor get called");
        }
        public Class1(int x){
            Console.WriteLine("Constuctor get called"+x);

        }


    }
}
