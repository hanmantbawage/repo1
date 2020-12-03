using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceEX2
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass b1 = new Derived();
            BaseClass b3 = new subDerived();

            BaseClass b2 = new Derived1();
            BaseClass b4 = new subDerived1();
            BaseClass b5 = new subsubDerived1();
            BaseClass b6 = new subsubDerived2();
            b1.Display3();
            b2.Display3();
            b3.Display3();
            b4.Display3();
            b5.Display3();
            b6.Display3();

            Console.ReadLine();
        }
        static void Main1(string[] args)
        {
            //BaseClass b1 = new BaseClass();
            // b1.Display1(25);
            //Derived d1 = new Derived();
            // d1.Display1(25);


            BaseClass b = new BaseClass();
            b.Display2();
            b.Display3();

            BaseClass c = new Derived();
            c.Display2();//it is at early binding...mathod not search at Derived class
            c.Display3();//it is late binding...base class method is virtual ....due to which it call derived class method

            BaseClass d = new subDerived1();
            d.Display3();
            BaseClass e = new subDerived();
            e.Display3();

            Console.ReadLine();
        }
    }
    class BaseClass
    {
        public void Display1() {
            Console.WriteLine("Base Display 1");
        }
        public void Display2()
        {
            Console.WriteLine("BASE Display 2 ");
        }
        public virtual void Display3()
        {
            Console.WriteLine("BASE Display 3 ");
        }
    }
    class Derived:BaseClass
    {
        public void Display1(int x)//overloaded with different signiture
        {
            Console.WriteLine("DERIVED CLASS  Display 01");
        }
        public new void Display2()//Hiding thebase class method 
        {
            Console.WriteLine("DERIVED CLASS Display 02");
        }

        public override void Display3()
        {
            Console.WriteLine("DERIVED CLASS Display 03");
        }
    }
    class Derived1 : BaseClass
    {
        public void Display1(int x)//overloaded with different signiture
        {
            Console.WriteLine("DERIVED CLASS  Display 01");
        }
        public new void Display2()//Hiding thebase class method 
        {
            Console.WriteLine("DERIVED CLASS Display 02");
        }

        public override  void Display3()
        {
            Console.WriteLine("DERIVED1 CLASS Display 03");
        }
    }
    
    class subDerived : Derived
    {
        public override sealed void Display3()
        {
            Console.WriteLine("SUBDERIVED CLASS Display 03");
        }
    }
    class subDerived1 : Derived1
    {
        public override void Display3()
        {
            Console.WriteLine("SUBDERIVED1 CLASS Display 03");
        }
    }
    class subsubDerived1 : subDerived1
    {
        public override void Display3()
        {
            Console.WriteLine("subSUBDERIVED1 CLASS Display 03");
        }
    }
    class subsubDerived2 : Derived
    {
        public override void Display3()
        {
            Console.WriteLine("subSUBDERIVED1 CLASS Display 03");
        }
    }


}
