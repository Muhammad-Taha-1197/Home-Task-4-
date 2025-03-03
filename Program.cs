using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scanerio_2
{
    class Employee
    {
        public int ID;
        public string FullName;
        public string Dept;
        public double Salary;

        public Employee(int id, string fullName, string dept, double salary)
        {
            ID = id;
            FullName = fullName;
            Dept = dept;
            Salary = salary;
        }

        void ShowDetails()
        {
            Console.WriteLine($"{ID,-10} | {FullName,-15} | {Dept,-10} | {Salary} PKR");
        }

        void RaiseSalary(double amount)
        {
            Salary += amount;
            Console.WriteLine($"\nUpdated Salary after increment: {Salary} PKR");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("====================================");
            Console.WriteLine("        Employee Management System   ");
            Console.WriteLine("====================================\n");
            Console.WriteLine("Employee Details:");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("ID         | Name            | Department | Salary");
            Console.WriteLine("------------------------------------------------------------");

            Employee emp1 = new Employee(1001, "Ahmed Khan", "IT", 55000);
            emp1.ShowDetails();
            emp1.RaiseSalary(7500);
        }
    }
}


