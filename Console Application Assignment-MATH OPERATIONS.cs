using System;


namespace Console_Application_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //takes input from user, multiplied by 50 and prints results.
            //decimal is used to accomodate exact decimal and larger than 10,000,000
            Console.WriteLine("Enter your number to be multiplied by 50.");
            string input = Console.ReadLine();
            Decimal number = Decimal.Parse(input);
            Decimal result = number * 50;
            Console.WriteLine(result);
            Console.ReadLine();

            //takes input from user, added by 25 and print results.
            //double data type is used
            Console.WriteLine("Enter your number to be added by 25.");
            string input = Console.ReadLine();
            double number = double.Parse(input);
            double result = number + 25;
            Console.WriteLine(result);
            Console.ReadLine();

            //takes input from user, divided by 12.5 and print results
            //double data type is also used
            Console.WriteLine("Enter your number to be divided by 12.5.");
            string input = Console.ReadLine();
            double number = double.Parse(input);
            double result = number / 12.5;
            Console.WriteLine(result);
            Console.ReadLine();

            //takes input from the user, compared it to 50 if it is greater, them print the results
            Console.WriteLine("Enter your number to be checked if it is greater than 50.");
            string input = Console.ReadLine();
            double number = double.Parse(input);
            bool result = number > 50;
            Console.WriteLine(result);
            Console.ReadLine();


            //takes input from the user, divided by 7 and print the remainder
            Console.WriteLine("Enter your number to get the remainder when divided by 7.");
            string input = Console.ReadLine();
            double number = double.Parse(input);
            double remainder = number % 7;
            Console.WriteLine(remainder);
            Console.ReadLine();






        }
    }
}
