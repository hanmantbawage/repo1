using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            A a1 = new A();
            B b1 = new B();
            a1.Display();
            Console.WriteLine("=====================================");
            b1.Display();
            Console.WriteLine("=====================================");
            b1.Display1();
            Console.ReadLine();

        }
    }
    class A
    {
        public int a=40;
        public int b = 50;
        
        public void Display (){
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
        }
    }
    class B : A
    {
        public int D = 60;
        public int E = 70;

        public void Display1()
        {
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
            Console.WriteLine("d=" + D);
            Console.WriteLine("e=" + E);
        }
    }
}
