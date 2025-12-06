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
            public void DivideByFive (int number)
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
