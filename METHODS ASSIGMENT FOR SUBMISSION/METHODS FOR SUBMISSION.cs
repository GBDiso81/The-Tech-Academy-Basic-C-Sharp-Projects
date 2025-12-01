using System;


namespace Method_Class_Assignment_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Instantiate the class
            MathOperations mathOps = new MathOperations();

            //takes two integers from users input
            Console.WriteLine("Enter 1st Num in parameter: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd Num in parameter: ");
            int num2 = Convert.ToInt32(Console.ReadLine());


            // 3. Call the method in the class, passing in two numbers
            mathOps.DoMath(num1, num2);

            // 4. Call the method again, specifying parameters by name
            mathOps.DoMath(num1: 7, num2: 3);



            // Pause so output remains visible
            Console.ReadLine();
        }
    }
}




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