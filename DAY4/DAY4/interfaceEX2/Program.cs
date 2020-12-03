using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceEX2
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public interface IDBfunction
    {
        void insert();
        void update();
        void delete();
    }

    public interface IDBfunction1
    {
        void close();
        void delete();
      
    }
    class class1 : IDBfunction,IDBfunction1
    {
        public void close()
        {
            throw new NotImplementedException();
        }
        void IDBfunction.delete()
        {
            throw new NotImplementedException();
        }


        public void insert()
        {
            Console.WriteLine("IDBfunction :insert method");
        }

        public void update()
        {
            Console.WriteLine("IDBfunction :update method");
        }
       

        void IDBfunction1.delete()
        {
            throw new NotImplementedException();
        }
    }
}
