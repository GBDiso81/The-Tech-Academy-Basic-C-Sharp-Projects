using System;


namespace ClassMethodAssignmentFour
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Instantiate that class.
            MathOperations operationsInstance = new MathOperations();

            // --- Problem 3: User input and Method Call ---
            Console.Write("Enter a number to be divided by 2: ");
            // Reads user input from the console.
            string userInput = Console.ReadLine();

            // Validates input and converts it to an integer.
            if (int.TryParse(userInput, out int numberToDivide))
            {
                // Calls the void method from the instantiated class and passes the number.
                // The method itself handles the division and output to the screen.
                operationsInstance.DivideByFive (numberToDivide);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

            // --- Problem 4 & 5: Output Parameters and Overloading Demonstration ---
            int originalValue = 350;
            int outputResult;

            // Calling the method with an output parameter.
            // The 'out' keyword indicates the parameter is assigned within the method.
            operationsInstance.GetNewValue(originalValue, out outputResult);
            Console.WriteLine($"\nOriginal value in Main: {originalValue}");
            Console.WriteLine($"Value returned via output parameter: {outputResult}");

            // Calling the overloaded methods. The correct method is selected based on parameter types.
            Console.WriteLine("\nDemonstrating method overloading:");
            Console.WriteLine($"Sum of 1000 and 5000: {operationsInstance.Add(1000, 5000)}");
            Console.WriteLine($"Sum of 500.25 and 2000.5: {operationsInstance.Add(500.25, 2000.5)}");


            // --- Problem 6: Static Class Demonstration ---
            // Accessing a static method from a static class directly using the class name.
            Console.WriteLine("\nDeclare a class to be static.:");
            StaticClass.DisplayMessage();

            // Keeps the console window open until a key is pressed.
            Console.ReadKey();
        }
    }
}



//mathOperations.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignmentFour
{

    class MathOperations
    {
        // 1. Create a void method that outputs an integer and divides the data passed to it by 2 and prints the result directly.
        public void DivideByFive(int number)
        {
            // The method performs an action (division) and has side effects (printing to console).
            int result = number / 2;
            Console.WriteLine($"\nThe entered number divided by 2 is: {result}");
        }

        // 4. Create a method with output parameters.
        // Uses the 'out' keyword to ensure the 'result' variable is assigned within the method.
        public void GetNewValue(int input, out int result)
        {
            result = input * 3; // Must assign a value to 'result' before the method returns.
        }

        // 5. Overload a method.
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }
    }

    // 6. Declare a class to be static.
    public static class StaticClass
    {
        public static void DisplayMessage()
        {
            Console.WriteLine("Displaying message from a static class method.");
        }
    }

}