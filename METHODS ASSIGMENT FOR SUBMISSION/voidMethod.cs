using System;


namespace Method_Class_Assignment_Submission
{
    // 1. Create a class
    public class MathOperations
    {
        // Create a void method that takes two integers as parameters
        
        //displays only the second integer to the screen
        public void DoMath(int num1, int num2)
        {
            // Math operation on the first integer (example: multiply by 8)
            int result = num1 * 8;
            

            // Display the results
            Console.WriteLine($"First number is: {num1}");
            Console.WriteLine($"Second number of the parameter is: {num2}");
        }
    }
}
