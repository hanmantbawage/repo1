using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstarctDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Abstractclass a = new Abstractclass();  we cannot create instance of abstract class 
            Derived d = new Derived();
            d.fun1();//fun of abstract class can access by derived class 

            d.fun2();//fun of abstract class can access by derived class 
            d.fun3();
            Console.ReadLine();
        }
    }
    public abstract class Abstractclass
    {
        public void fun1()
        {
            Console.WriteLine("in .net abstract class can contain 0 abstarct method ");
        }
        public void fun2()
        {
            Console.WriteLine("abstact class contain 0 or multiple function with body  ");
        }
    }
    public class Derived : Abstractclass
    {
        public void fun3()
        {
            Console.WriteLine("from derived class we can access the methods of abstract class");
        }
    }

    public abstract class AbstractClass1
    {
        public abstract void show();
        public abstract void display();
    }
    public class derived1 : AbstractClass1
    {
        public override void show()
        {

        }

        public override void display()
        {

        }
    }
}
