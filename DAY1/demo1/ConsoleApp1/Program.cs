using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            float a;
            float b;
            a = Convert.ToInt32(System.Console.ReadLine());
           
            b = Convert.ToInt32(System.Console.ReadLine());
            float f = a / b;
            System.Console.WriteLine(f);
        }
    }
}
