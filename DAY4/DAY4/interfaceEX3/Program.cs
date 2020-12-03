using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Reference Type
//Value Type
namespace interfaceEX3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            i = 10;
            j = 20;
            i = j;
            j = 30;
            Console.WriteLine(i);
            Console.WriteLine(j);


            Class1 c1 = new Class1();
            Class1 c2 = new Class1();
            c1.i = 100;
            c2.i = 200;
            c1 = c2;//both Reference veriable are pointing to same memory location
            c1.i = 300;//c2.i=300------------for both same answer bcoz both are pointing and changing same memory
            c2.i = 500;//now value of i at that location become 500
             Console.WriteLine(c1.i);
            Console.WriteLine(c2.i);

            Console.ReadLine();



        }
    }
    class Class1
    {
        public int i;
    }
}
