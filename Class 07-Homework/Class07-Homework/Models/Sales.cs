using System;
using System.Collections.Generic;
using System.Text;

namespace Class07_Homework.Models
{
    public class SalesPerson : Employee
    {
        private double Sales { get; set; }

        public SalesPerson(string firstname, string lastname)
        : base(firstname, lastname, Roles.Sales, 450)
        {
            Sales = 0;
        }

        public void SalesBonus(double pay)
        {
            Sales += pay;
        }

        public override double GetSalary()
        {
            double bonus = 550;
            if (Sales > 1500)
            {
                bonus = 500;
            }
            else if (Sales > 3000)
            {
                bonus = 1500;
            }
            return Salary + bonus;
        }
    }
}
