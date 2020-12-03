using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo.p = 25;
            Demo.s_Display();

            Demo.P1 = 100;
            Console.WriteLine( Demo.P1);
            Console.ReadLine();
        }
    }
    class Demo
    {
        public static int p;
        private static int p1;
        public static int  P1{
            set{
                p1 = value;
                
                }
            get
            {
                return p1;
            }
        }

         public static void s_Display()
        {
            Console.WriteLine(p);
        }
    }
}
