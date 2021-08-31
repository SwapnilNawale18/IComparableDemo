using System;
using System.Collections.Generic;

namespace IComparableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, empSalary;
            string empName;
            List<Employee> lst = new List<Employee>();
            Console.WriteLine("Enter number of employees");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter name of employee {0}: ", i + 1);
                empName = Console.ReadLine();
                Console.Write("Enter Salary of employee {0}: ", i + 1);
                empSalary = Convert.ToInt32(Console.ReadLine());
                lst.Add(new Employee { Name = empName, Salary = empSalary });
            }
            lst.Sort();
            foreach (var i in lst)
            {
                Console.WriteLine(i);
            }
        }
    }
}
