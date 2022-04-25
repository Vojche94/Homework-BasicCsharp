using System;

namespace Class03_HomeworkTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] group1 = new string[5] { "Marc", "Jack", "Jessica", "Marco", "Maya" };
            string[] group2 = new string[5] { "Jennifer", "Kate", "Isabell", "John", "Mary" };

            while (true)
            {
                Console.WriteLine("Please insert a number between 1 or 2");
                string input = Console.ReadLine();
                if (input == "1")
                {
                    Console.WriteLine("The students in group 1 are: ");
                    for (int i = 0; i < group1.Length; i++)
                    {
                        Console.WriteLine((i + 1) + "-" +  group1[i]);
                    }
                    break;
                }
                else if (input == "2")
                {
                    Console.WriteLine("The students in group 2 are: ");
                    for (int i = 0; i < group2.Length; i++)
                    {
                        Console.WriteLine((i + 1) + "-" + group2[i]);
                    }
                    break;
                }
                else
                    Console.WriteLine("Please enter a valid option");
                continue;
            }
        }
    }
}
