using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatetimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentTime = DateTime.Now;
            Console.WriteLine("Current Date and time: " + currentTime);



            //2.Asks the user for a number.

            Console.Write("\nEnter a number of hours to add: ");
            // Read the user's input from the console
            string userInput = Console.ReadLine();
            // Convert the string input to a double for calculations
            double hoursToAdd = Convert.ToDouble(userInput);

            
            // 3. Calculate the future time by adding the user input to the current time
            DateTime futureTime = currentTime.AddHours(hoursToAdd);
            // Print the calculated future time to the console
            Console.WriteLine($"\nExact time in {hoursToAdd} hours: {futureTime}");
            
            Console.ReadLine();


        }
    }
}


