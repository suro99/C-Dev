using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary
{
    class Mindteck
    {
        public string name;
        public double basic;
        public double TA, DA, HRA, PF;
    }
    class Employee : Mindteck
    {
        double gross;
        public void cal_sal()
        {
            TA = (basic * 10) / 1000;
            DA = (basic * 10) / 100;
            HRA = (basic * 5) / 100;
            PF = (basic * 12) / 100;
            gross = (basic + TA + DA + HRA - PF);
        }
        public void display()
        {
            Console.WriteLine("The Basic Salary of " + name + " is " + basic);
            Console.WriteLine("The TA of " + name + " is " + TA);
            Console.WriteLine("The DA Salary of " + name + " is " + DA);
            Console.WriteLine("The HRA Salary of " + name + " is " + HRA);
            Console.WriteLine("The PF Salary of " + name + " is " + PF);
            Console.WriteLine("The gross Salary of " + name + " is " + gross);
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee m1 = new Employee();
            Employee m2 = new Employee();
            Console.WriteLine("The Employee1 Name: ");
            m1.name = Console.ReadLine();
            Console.WriteLine("The Employee1 Basic Salary: ");
            m1.basic = (Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("The Employee2 Name: ");
            m2.name = Console.ReadLine();
            Console.WriteLine("The Employee2 Basic Salary: ");
            m2.basic = (Convert.ToDouble(Console.ReadLine()));
            m1.cal_sal();
            m1.display();
            m2.cal_sal();
            m2.display();
            Console.ReadLine();
        }
    }
}
