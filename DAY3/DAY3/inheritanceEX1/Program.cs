using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceEX1
{
    class Program
    {
        static void Main(string[] args)
        {

            //BaseClass o = new BaseClass();
          //  o.Display();
            DerivedClass o1 = new DerivedClass(25);
            o1.Display();

            int x = int.Parse(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = x + y;
            Console.WriteLine(z);
            Console.ReadLine();




        }
    }
    class BaseClass {

        public BaseClass(){
            Console.WriteLine("Base Class  construcor" );
        }
        public BaseClass(int i)
        {
            Console.WriteLine("Base Class  construcor with param" );
        }
        public int a = 5;
        public int b = 10;
        public void Display()
        {
            //Console.WriteLine("Base Class "+a + b);
        }
    
    }
    class DerivedClass : BaseClass
    {

        public DerivedClass()
        {
            Console.WriteLine("DerivedClass  construcor");
        }
        public DerivedClass(int i) : base(25)
        {
            Console.WriteLine("DerivedClass  construcor with param");
        }
        public new void Display()
        {
           
           // Console.WriteLine("Derived Class ");
        }

    }
}
