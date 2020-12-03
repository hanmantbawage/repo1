using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace property
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Property!!!!!!!!!!");
            Class1 o = new Class1();
            o.P1 = 1000;
            // o.P2 = o.P1 + o.P1;
            Console.WriteLine(o.S);




            Console.ReadLine();
        }
    }
    class Class1
    {
        private int p1=100;
        private int p2 = 0;

        public int P2
        {
            set
            {
                p2 = value;
            }
            get
            {
                Console.WriteLine(p2);
                return p2;   
            }
        }

        public int P1 {

             set
            {
                if (value > 80)
                {
                    p1 = value;
                    Console.WriteLine("Valid Data");
                }
            
                else
                {
                    Console.WriteLine("Invalid Data");
                }
            }
             get
            {
                return p1;
            }
        
        }
        private string s = "read only property....";
        public string S
        {
            get
            {
                return s;
            }
        }

    }
}
