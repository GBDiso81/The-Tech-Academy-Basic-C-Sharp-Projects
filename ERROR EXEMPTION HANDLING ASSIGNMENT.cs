using System;
using System.Collections.Generic;


class Program
    {
    static void Main(string[] args)
    {
        Console.WriteLine("Exception Handling Assignment");
        Console.WriteLine("Press any key to continue...");
        Console.ReadLine();

        // 1. Create a list of integers
        List<int> numberslist = new List<int> { 10, 20, 30, 45, 60, 23, 77, 91, 33, 45, 28, 19 };
        Console.WriteLine($"Numbers List: {string.Join(", ", numberslist)}");
        Console.WriteLine("Press any key to continue...");
        Console.ReadLine();


        bool validInput = false;
        while (!validInput)
        {
            try
            {
                // Ask the user for a number to divide by
                Console.WriteLine("Enter a number to divide the numbers on the list by :");
                float userinput = float.Parse(Console.ReadLine());

                if (userinput == 0)
                {
                    Console.WriteLine("Error: Cannot divide by zero. Please try again.");
                }

                else
                {
                    // Input is valid and not zero, exit the input loop
                        foreach (int num in numberslist)
                        {
                            float result = num / userinput;
                            Console.WriteLine($"{num} divided by {userinput} is: {result}");
                        }
                        validInput = true;
                }
             }

            
            catch (FormatException)
            {
                // Handle cases where the user enters a non-numeric string
                Console.WriteLine("Error: Invalid format. Please enter a valid integer.");
            }
        }
            Console.WriteLine("The program has emerged from the try/catch block and will now exit.");
            Console.WriteLine("Press any key to exit program...");
            Console.ReadKey();

    }
    }
    









    
