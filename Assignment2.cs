﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Manager("sr manager","hanamnt",10000,9);
           

            Employee e2= new GeneralManager("","sr manager", "AMOL", 10000, 9);
            

            Employee e3 = new CEO( "Sanjyot", 20000,8);
            Console.WriteLine(e3.CalcNetSalary());
            Console.WriteLine(e2.CalcNetSalary());
            Console.WriteLine(e1.CalcNetSalary());
            Console.ReadLine();
           
        }
    }
 public abstract   class  Employee
    {
        string Name;
        int empNo;
        public static int lastEmpNo = 0;
        short DeptNo;
         decimal Basic;
       // decimal Salary;
        public  abstract decimal CalcNetSalary();
        public Employee(String Name, decimal Basic, short DeptNo)
        {
            empNo = ++lastEmpNo;
            this.NAME = Name;
            this.Basic = Basic;                              
            this.DEPTNO = DeptNo;
          
        }
      
        public int EmpNo
        {
            private set
            {
                empNo = value;
            }
             get
            {
                return empNo;
            }
        }

        public String NAME
        {
            set
            {
                if (value == "")
                {
                    Console.WriteLine("Invalid Data..!!!!!!!");
                }
                else
                {
                    Name = value;

                }
            }
            get
            {
                return Name;
            }
        }
       
        public short DEPTNO
        {
            set
            {
                if (value > 0)
                {
                    DeptNo = value;
                }
                else
                {
                    Console.WriteLine("Invalid DeptNO..!!!!!!!");
                }
            }

        }
    }
    

    public  class Manager : Employee
    {
        string Designation;
        Decimal salary;

        public Manager(string Designation,string Name = "noname", decimal Basic = 10000, short DeptNo = 10):base(Name, Basic, DeptNo)
        {
            this.Designation = Designation;
            salary = Basic;
        }
        public override decimal CalcNetSalary() {

            salary = salary * (decimal)1.5;
                return salary;
        }

    }
    public  class GeneralManager : Manager
    {
        string Perks;
        decimal salary;
        public GeneralManager(string Perks, string Designation, string Name = "noname", decimal Basic = 10000, short DeptNo = 10) :base(Designation, Name, Basic, DeptNo)
        {
            this.Perks = Perks;
            salary = Basic;

        }
        public override decimal CalcNetSalary()
        {

            salary = salary * (decimal)1.6;
            return salary;
        }
    }
    public  class CEO : Employee {

        decimal salary;
        public CEO(string Name = "noname", decimal Basic = 10000, short DeptNo = 10) : base(Name, Basic, DeptNo)
        {
            salary = Basic;
        }
        public sealed override decimal CalcNetSalary()
        {

            salary = salary *2;
            return salary;
        }
    }
}
