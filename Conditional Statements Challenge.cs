using System;


namespace Conditional_Statements_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask user to input age and compare it to below if, else if and else conditional statement
            Console.WriteLine("Enter your Age:");
            int age = Convert.ToInt32(Console.ReadLine());

            //takes user input and compare if it is greater than 20
            if (age > 20)
            {
                Console.WriteLine("You are 20 years old above.");
            }


            //takes user input and compare if it is greater than 10
            else if (age > 10)
            {
                Console.WriteLine("You are 10 years old above but not older than 20.");
            }

            //takes user input and compare if it meet above conditions and if none print below 
            else
            {
                Console.WriteLine("You are 10 years old below.");
            }

            Console.ReadLine();

        }
    }
}
