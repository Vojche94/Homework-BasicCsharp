using System;
using System.Collections.Generic;
using System.Text;

namespace Class07_Homework.Models
{
    public class CEO : Employee
    {

        public Employee[] Employees { get; set; }
        public int Shares { get; set; }
        private double SharePrice { get; set; }

        public CEO(string firstname, string lastname, double salary, Employee[] employees, int shares, double shareprice)
        : base(firstname, lastname, Roles.CEO, salary)
        {
            Employees = employees;
            Shares = shares;
            SharePrice = shareprice;
        }

        public void AddSharePrice(double ammount)
        {
            SharePrice += ammount;
        }

        public void PrintEmployees()
        {
            foreach (Employee employee in Employees)
            {
                Console.WriteLine(employee.GetInfo());
            }
        }

        public override double GetSalary()
        {
            return Salary + Shares * SharePrice;
        }
    }

}
