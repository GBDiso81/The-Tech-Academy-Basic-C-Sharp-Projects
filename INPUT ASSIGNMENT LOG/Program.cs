using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputAssignmentLog
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Define the path for the text file
            string filePath = "C:\\Users\\gbdis\\Logs\\InputAssignmentLogs.txt";

            // 1. Ask the user to input a number
            Console.Write("Please enter a number: ");
            string input = Console.ReadLine();

            int userNumber;
            // Validate input using TryParse to ensure it's a valid integer
            bool isValid = int.TryParse(input, out userNumber);

            if (!isValid)
            {
                Console.WriteLine("\nYou Entered an invalid number! Check log file...");
                Console.WriteLine("\nPress ENTER key to view log...");
                // Exit the application if input is invalid
                Console.ReadLine();

            }

            // 2. Log the number to a text file
            // Use 'true' argument to append to the file, not overwriting it
            using (StreamWriter newfile = new StreamWriter(filePath, true))
            {
                // Write the number followed by a new line character
                newfile.WriteLine(input);
            }
            Console.WriteLine($"\nSuccessfully logged [{input}] located at last file of {filePath}\n");

            string fileContents = File.ReadAllText(filePath);
            Console.WriteLine(fileContents);
            Console.WriteLine("--------------------------------");
            Console.WriteLine( "Press ENTER key to exit...");
            Console.ReadLine();
            
        }
    }
}

    




