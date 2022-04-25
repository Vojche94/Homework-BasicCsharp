using System;
using System.Collections.Generic;

namespace Class08_Homework_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> nums = new Queue<int>();

            while (true)
            {
                Console.Write("Please enter a number : ");
                if (!int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine("Input is not valid");
                    Console.Read();
                    continue;
                }
                nums.Enqueue(number);
                Console.WriteLine("Choose from the options for a diffrent num (y/n) ? ");
                string input = Console.ReadLine();
                if (input.ToLower() == "n")
                {
                    break;
                }
                continue;
            }

            while (nums.TryDequeue(out int number))
            {
                Console.WriteLine($"The inputed numbers are {number}");
            }
        }
    }
    
}
