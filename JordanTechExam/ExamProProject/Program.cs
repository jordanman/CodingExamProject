using System;

namespace ExamProProject
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("***Coding Tech Assessment by Jordan***");
            Console.WriteLine();
            Console.WriteLine("Please enter sample data input & press enter.");

            string input = Console.ReadLine(); 

            bool isValidFound = DataValidator.IsMatchAngleBrackets(input);

            if (isValidFound)
            {
                Console.WriteLine($"'{input}' has matching angle brackets.");
            }
            else
            {
                Console.WriteLine($"'{input}' has invalid matching angle brackets.");
            }

            Console.ReadLine();
        }
    }
}
