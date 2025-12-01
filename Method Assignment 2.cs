using System;


namespace mathOperation2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOps2 class.
            mathOps2 op = new mathOps2();

            // Ask the user to input the first number.
            Console.WriteLine("Enter the yuour first number:");
            // Read the input and convert it to an integer.
            int input1 = Convert.ToInt32( Console.ReadLine());
            

            // Ask for the second number, and let them know it's optional.
            Console.WriteLine("Enter your second number (optional, press Enter to skip):");
            // Read the second input.
            string inputstr = (Console.ReadLine());

            int result;
            

            // Check if the second input string is empty.
            if (string.IsNullOrEmpty(inputstr))
            {
                // If empty, call the method with only the first number (using the default for the second).
                result = op.MultiplyNumbers(input1);
            }
            else
            {
                // If not empty, convert the second input to an integer.
                int input2 = Convert.ToInt32(inputstr);
                // Call the method with both numbers.
                result = op.MultiplyNumbers(input1, input2);
                
            }

            // Display the result of the operation.
            Console.WriteLine($"The result is: {result}");
            Console.ReadLine();
        }
    }
}



using System;


namespace mathOperation2
{
    public class mathOps2
    {
        // Method takes two integers. num2 is optional with a default value of 1.
        public int MultiplyNumbers(int num1, int num2 = 1)
        {
            // Perform a math operation (multiplication) and return the result.
            return (num1 - num2) * 100;

        }
    }
}