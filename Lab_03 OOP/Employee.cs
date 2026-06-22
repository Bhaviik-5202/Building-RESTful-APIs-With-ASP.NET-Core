using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_03_OOP
{
    internal class Employee
    {
        public int id;
        public string name;
        public string department;
        public string designation;
        public double salary;

        public void GetEmpDetails()
        {
            Console.WriteLine("Enter Employee Id :");
            id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Employee Name :");
            name = Console.ReadLine();

            Console.WriteLine("Enter Employee Department :");
            department = Console.ReadLine();

            Console.WriteLine("Enter Employee Designation :");
            designation = Console.ReadLine();

            Console.WriteLine("Enter Employee Id :");
            salary = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayEmpDetails()
        {
            Console.WriteLine("\n Employee Detail :");
            Console.WriteLine("ID : " + id);
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Department : " + department);
            Console.WriteLine("Designation : " + designation);
            Console.WriteLine("Salary : " + salary);
        }
    }
}
