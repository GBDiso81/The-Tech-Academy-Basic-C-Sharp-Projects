using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METHODS_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to input a number
            Console.Write("Enter your Exam Score get out of 100 Questions: ");
            // Read the user input and convert it to a double
            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Press any key for your exam results...");
            Console.ReadLine();

            // Create an instance of the MATH class
            MATH mathMethods = new MATH();

            // Call the first method, pass the user input, and store the result
            int result1 = mathMethods.correctAnswers(userInput);
            // Display the result to the screen
            Console.WriteLine($"You have { result1}  wrong answers or unanswered questions. ");

            // Call the second method, pass the user input, and store the result
            float result2 = mathMethods.DividedByQuestions(userInput);
            // Display the result to the screen
            Console.WriteLine($"Your Exam Rating is : {result2} %");

            // Call the third method, pass the user input, and store the result
            int result3 = mathMethods.SquareRoot(userInput);
            // Display the result to the screen
            Console.WriteLine($"The Square Root of your correct Score plus 10 score Bonus is : "   + Math.Sqrt(result3));


            


            // Keep the console window open
            Console.ReadLine();
        }
    }
}
