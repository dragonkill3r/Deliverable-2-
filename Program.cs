/* 
Author: Mahamoud Mohamed
Date: 1/23/2023
Description: This C# console provides students with their letter grades.
*/

using System;

namespace Conditional_Statements_1
{
     class Program
    {
        static void Main(string[] args)
        {
           double grade = 0;
            bool input = false;

            // Try catch statement 
            while (!input)
            {
                try
                {
                    Console.WriteLine("What grade do you expect to get in ISM 4300? (Enter Number)");
                    grade = double.Parse(Console.ReadLine());

                    // Checking if our grade is within a valid range 
                    if (grade < 0 || grade > 100)
                    {
                        throw new Exception("Grade must be between 0 and 100.");
                    }

                    input= true;
                }  
                catch (Exception e) 
                {
                    Console.WriteLine(e.Message);
                }
            }

                // Usig conditional statements to determine letter grade 
                if (grade>= 90) 
            {
                Console.WriteLine("Your Letter Grade is A");
            }
                else if (grade>= 80) 
            {
                Console.WriteLine("Your Letter Grade is B");
            }
                else if (grade>= 70)
            {
                Console.WriteLine("Your Letter Grade is C");
            }
                else if (grade>= 60)
            {
                Console.WriteLine("Your Letter Grade is D");
            }
                else
            {
                Console.WriteLine("Your Letter Grade is F");
            }

                Console.ReadKey();
        }
    }
}