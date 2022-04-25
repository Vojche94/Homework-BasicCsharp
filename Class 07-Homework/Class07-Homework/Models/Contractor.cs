using System;
using System.Collections.Generic;
using System.Text;

namespace Class07_Homework.Models
{
    public class Contractor : Employee
    {
        private double WorkingHours { get; set; }
        private int ByHourPay { get; set; }
        public Manager Responsible { get; set; }

        public Contractor(string firstname, string lastname, int byhourpay,Manager responsible)
        : base(firstname, lastname, Roles.Contractor, 0)
        {
            WorkingHours = 0;
            ByHourPay = byhourpay;
            Responsible = responsible;

        }

        public override double GetSalary()
        {
            Salary = WorkingHours * ByHourPay;
            return Salary;
        }

        public void WorkHours(int hours)
        {
            WorkingHours += hours;
        }

        public string CurrentPosition()
        {
            return $"The manager {Responsible.FullName} from the department {Responsible.Department} is responsible for {FullName}";
        }
    }
}
