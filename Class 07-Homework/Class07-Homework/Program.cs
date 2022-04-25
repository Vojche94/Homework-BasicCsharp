using Class07_Homework.Models;
using System;


namespace Class07_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager1 = new Manager("Bob", "Bobsky", 2245,"WebDesign");
            manager1.AddBonus(2000, 3);
            Manager manager2 = new Manager("Jill", "Dawson", 3444,"WebDev");
            manager2.AddBonus(3500, 4);

            Contractor contractor1 = new Contractor("John", "Wayne", 60,manager2);
            contractor1.WorkHours(2);
            contractor1.WorkHours(8);
            Console.WriteLine(contractor1.CurrentPosition());

            Contractor contractor2 = new Contractor("Ana ", "White", 55,manager1);
            contractor2.WorkHours(4);
            contractor2.WorkHours(10);
            Console.WriteLine(contractor2.CurrentPosition());

            SalesPerson salesPerson = new SalesPerson("Merry", "Kate");
            salesPerson.SalesBonus(450);
            salesPerson.SalesBonus(1800);
            salesPerson.SalesBonus(3200);
            

            Employee[] Company = new Employee[] {
                manager1,
                manager2,
                contractor1,
                contractor2,
                salesPerson
            };

            CEO JohnyBravo = new CEO("Johnny", "Bravo", 125000, Company, 350, 68);

            Console.WriteLine(JohnyBravo.GetInfo());
            Console.WriteLine($"The salary of {JohnyBravo.FullName} is : {JohnyBravo.GetSalary()}");
            Console.WriteLine("Employees : ");
            JohnyBravo.PrintEmployees();


            CEO JohntraVolta = new CEO("Johntra", "Volta", 45000, Company, 324, 77);

            Console.WriteLine(JohntraVolta.GetInfo());
            Console.WriteLine($"The salary of {JohntraVolta.FullName} is : {JohntraVolta.GetSalary()}");
            Console.WriteLine("Employees : ");
            JohntraVolta.PrintEmployees();
        }
    }
}
