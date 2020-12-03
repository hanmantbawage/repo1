using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClassComcepts
{
    class Program
    {
        static void Main(string[] args)
        {
           System.Console.WriteLine("Hello world");
            //Console.ReadLine();
            Class1 o = new Class1();
            o.Display();
          //  string s = Console.ReadLine();
            o.Display("hii");

            Console.WriteLine(o.Add(45, 62));
            Console.WriteLine(o.Add(45));



           // Console.WriteLine(o.Add2(d: 40));
            //Console.WriteLine(o.Add2(a: 40));
            Console.WriteLine(o.Add2(d: 40, c: 30, a: 20, b: 10));
            Console.ReadLine();
        }
    }
    public class Class1
    {
        public void Display() {
            Console.WriteLine("Displayed");
            // Console.ReadLine();

        }
        public void Display(string s)
        {
            Console.WriteLine("Displayed  string  " + s);
            //Console.ReadLine();

        }

        public int  Add(int a, int b){
            return a + b;
            }
        public int Add(int a=5, int b=0,int c=0)
        {
            return a + b;
        }
        public int Add(int p, int r,int a = 5, int b = 0, int c = 0)
        {
            System.Console.WriteLine("Done");
            return a + b+p+r+c;
        }

        public int Add2(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }

    }
}
