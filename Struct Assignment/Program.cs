using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StructAssignment.StructNumber;

namespace StructAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. In the Main() method, create an object of data type Number and assign an amount to it.
            // Declare a variable 'myPi' of the struct type 'Number'.
            Number myPi = new Number();

            // Assign a decimal value to the 'Amount' property using the 'm' suffix for decimal literals.
            myPi.Amount = 3.1415926535m;

            // 3. Print this amount to the console.
            
            Console.WriteLine($"Rounded approximation for the value of PI: {myPi.Amount}"); 

            // Keep the console window open
            Console.WriteLine("\nPress any key to exit."); //
            Console.ReadKey();
        }
    }
}
