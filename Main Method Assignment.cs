using System;


namespace mathOps
{
    public class MainMethod
    {
         // This is the first method, which takes an integer.
        // The same method name is used multiple times (overloading) distinguished by parameter types.
        public int MathOperation(int inputInteger)
        {
            // Perform a math operation (e.g., addition)
            return inputInteger = inputInteger + 50;
            
        }

        // 3. Add a second method to the class with the same name that will take in a decimal
        public int MathOperation(decimal inputDecimal)
        {
            // Perform a different math operation Division
            // Note: The result of the operation is cast to an int to match the return type requirement.
            decimal resultDecimal = inputDecimal / 1.6m;
            // The return type must be an integer, so we explicitly convert the decimal to an int.
            return ((int)resultDecimal);
        }

        // 5. Add a third method to the class, with the same name, that will take in a string and use math operation subtraction
        public int MathOperation(string inputString)
        {

            int convertedInput = Convert.ToInt32(inputString);
            return convertedInput - 2;
        }
    }
}
