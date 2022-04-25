using System;

namespace Homework_Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the first number");
            string input1 = Console.ReadLine();
            bool success1 = double.TryParse(input1, out double num1);
            if (!success1)
            {
                Console.WriteLine("Please a valid number");
                return;
            }

            Console.WriteLine("Please input the second number");
            string input2 = Console.ReadLine();
            bool success2 = double.TryParse(input2, out double num2);
            if (!success2)
            {
                Console.WriteLine("Please a valid number");
                return;
            }


            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;


            Console.WriteLine("The value of the first number is " + num1);
            Console.WriteLine("The value of the second number is " + num2);
        }
    }
}
