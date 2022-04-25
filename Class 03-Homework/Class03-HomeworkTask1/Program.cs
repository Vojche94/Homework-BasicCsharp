using System;

namespace Class03_HomeworkTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[6];

            for (int i = 0; i < array.Length; i++)
            {
                while (true)
                {
                    Console.WriteLine("Please enter your " + (i+1) + " number");
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out int number))
                    {
                        Console.WriteLine("Please enter a valid number ");
                        continue;

                    }
                    array[i] = number;
                    break;
                }
            }
            int sumofEven = 0;

            foreach (int num in array)
            {
                if ( num % 2 != 0) 
                {
                    continue;
                }
                else
                sumofEven += num;
            }

            Console.WriteLine("The sum of the  even numbers is : " + sumofEven);

        }
    }
    
}
