using System;
using System.Collections.Generic;
using System.Text;

namespace Class07_Homework.Models
{
    public class Manager : Employee
    {
        public double Bonus { get; set; }
        public string Department { get; set; }


        public Manager(string firstname, string lastname, double salary,string department)
        : base(firstname, lastname, Roles.Manager, salary)
        {
            Bonus = 0;
            Department = department;

        }

        public void AddBonus(double bonus, int level)
        {
            Bonus = bonus * level;
        }


        public override double GetSalary()
        {
            return Salary + Bonus;
        }
    }
}
