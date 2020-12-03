using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceEX1
{
    class Program
    {
        static void Main(string[] args)
        {
            //method 1
            class1 o = new class1();
            
            o.insert();
            o.update();
            Console.ReadLine();

            //method 2
            class1 o1 = new class1();
            Ifilefunction f;
            f = o1;
            f.delete();//delete of ifilefunction

            //method 3
            class1 o4 = new class1();
            ((Ifilefunction)o4).delete();
            
        }
    }
    public interface IDBfunction {
        void insert();
        void update();
        void delete();
    }
    public interface Ifilefunction
    {
        void open();
        void close();
        void delete();
    }
    class class1 : IDBfunction, Ifilefunction
    {
         void IDBfunction.delete()
        {
            throw new NotImplementedException();
        }
        void Ifilefunction.delete()
        {
            throw new NotImplementedException();
        }

        public void insert()
        {
            throw new NotImplementedException();
        }

        public void update()
        {
            throw new NotImplementedException();
        }

        public void open()
        {
            throw new NotImplementedException();
        }

        public void close()
        {
            throw new NotImplementedException();
        }
    }
}
