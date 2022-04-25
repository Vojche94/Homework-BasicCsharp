using System;

namespace Homework_Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first  number");
            string input1 = Console.ReadLine();
            bool success1 = double.TryParse(input1, out double input1Parsed);
            if (!success1)
            {
                Console.WriteLine("Please a valid number");
                return;
            }

            Console.WriteLine("Please enter second  number");
            string input2 = Console.ReadLine();
            bool success2 = double.TryParse(input2, out double input2Parsed);
            if (!success2)
            {
                Console.WriteLine("Please a valid number");
                return;
            }

            Console.WriteLine("Please enter third  number");
            string input3 = Console.ReadLine();
            bool success3 = double.TryParse(input3, out double input3Parsed);
            if (!success3)
            {
                Console.WriteLine("Please a valid number");
                return;
            }

            Console.WriteLine("Please enter forth  number");
            string input4 = Console.ReadLine();
            bool success4 = double.TryParse(input4, out double input4Parsed);
            if (!success4)
            {
                Console.WriteLine("Please a valid number");
                return;
            }

            double result = (input1Parsed + input2Parsed + input3Parsed + input4Parsed) / 4;

            Console.WriteLine("The average from your numbers is " + result);
        }
    }
}
