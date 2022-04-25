using System;
using System.Collections.Generic;
using System.Text;

namespace Class07_Homework.Models
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public Roles Role { get; set; }
        protected double Salary { get; set; }

        public Employee(string firstname, string lastname, Roles role, double salary)
        {
            FirstName = firstname;
            LastName = lastname;
            Role = role;
            Salary = salary;

        }

        public virtual double GetSalary()
        {
            return Salary;
        }

        public string GetInfo()
        {
            return $"{FullName}({Role}) - {GetSalary()}";
        }


    }
}
