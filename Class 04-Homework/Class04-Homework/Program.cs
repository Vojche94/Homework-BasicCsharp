using System;

namespace Class04_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {


            while (true)
            {
                Console.WriteLine("Please insert your birth year in this format yyyy,mm,dd");
                if (!DateTime.TryParse(Console.ReadLine(), out DateTime bday))
                { 
                    Console.WriteLine("Please insert correct format");
                    continue;
                }

                int res = AgeCalculator(bday);
                Console.WriteLine($"Your current age is {res}");
                break;


            }

        }
        
        public static int AgeCalculator(DateTime userInput)
        {
            DateTime now=DateTime.Today;
            int age = now.Year - userInput.Year;
            if (userInput > now.AddYears(-age))
                age--;
            return age;
        }
    }

    
}
