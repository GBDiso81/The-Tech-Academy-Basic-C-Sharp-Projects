using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
                // 1. Ask the user for their age.
                Console.Write("Please enter your age: ");

                // 3. Exceptions must be handled using "try/catch."
                try
                {
                    // Read the input from the console
                    string input = Console.ReadLine();
                    // Convert the string input to an integer
                    int age = int.Parse(input);

                    // 4. Display appropriate error messages if the user enters zero or negative numbers.
                    if (age <= 0)
                    {
                        // Manually throw an exception if the age is invalid (zero or negative)
                        throw new ArgumentException("Age cannot be zero or negative.");
                    }

                    // Calculate the birth year based on the current system year
                    int currentYear = DateTime.Now.Year;
                    int birthYear = currentYear - age;

                    // 2. Display the year the user was born.
                    Console.WriteLine($"\nYou were likely born in the year {birthYear}.");
                }
            // catch block for the ArgumentException for age <= 0
            catch (ArgumentException notZero)
            {
                Console.WriteLine($"\nError: {notZero.Message}");
            }
            // Catch block when user enters text instead of a number)
            catch (FormatException)
            {
                Console.WriteLine("\nError: Invalid input. Please enter a valid number for your age.");
            }
            // 5. Display a general message if an exception was caused by anything else.
            catch (Exception)
            {
                Console.WriteLine($"\nThis is General message for exception caused by anything else");
            }

            // Keeps the console window open until a key is pressed
            Console.WriteLine("\nPress any key to exit the application.");
                Console.ReadKey(); 
            }
        }

    }


