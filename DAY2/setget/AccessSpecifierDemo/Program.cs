using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifierDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Derived d = new Derived();
            d.r1 = 10;// internal 
        }
    }
    class Derived : Class1.Class2
    {
        internal int r1;
       void add()
        {
            int s1=this.p2;//accessible becoz public
            int s2=this.p3;// bcoz  protected(Derived class)
            int s3 = this.p5;//bcoz protected internal(same class, derived class,same assembly)

            //int s4= this.p1//private
            // int s5= this.p4// internal same class same assembly
        }
        
    }
    
   
    
}
