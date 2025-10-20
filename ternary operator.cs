using System;


namespace Ternary_Operator_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //using ternary operator
            Console.WriteLine("Welcome to AOL!");
            Console.ReadKey();
            Console.WriteLine("What is your Grade?");
            int grade = Convert.ToInt32(Console.ReadLine());
            string result = (grade >= 75) ? "You Passed! " : "Sorry... You've Failed.";
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
