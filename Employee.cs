using System;
namespace IComparableDemo
{
    internal class Employee : IComparable<Employee>
    {
        public string Name { get; set; }
        public int Salary { get; set; }

        public int CompareTo(Employee emp)
        {
            if (this.Salary == emp.Salary)
            {
                this.Name.CompareTo(emp.Name);
            }
            //LOW to HIGH salary
            //return this.Salary.CompareTo(emp.Salary);
            //HIGH to LOW salary
            return emp.Salary.CompareTo(this.Salary);
        }
        public override string ToString()
        {
            //return base.ToString();
            return this.Name + "\t" + this.Salary.ToString();
        }
    }
}