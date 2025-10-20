using System;


namespace Boolean_Logic_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print the Program Title
            Console.WriteLine("Looking for Car Insurance? Check it here if your qualified!");

            //takes the user age input and convert to integer
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            //takes the user input if driving under influence and convert the user input to lower case to exactly match the bool condition
            Console.WriteLine("Have you ever had a DUI? (Yes or No)");
            string answer = Console.ReadLine().ToLower();
            bool dui = answer == "yes";

            //takes the user input for how many speeding tickets recieved and convert to integer
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());

            //check all the current conditions are all true to qualified for insurance
            //if one is false out of three conditions, will print false to tell the user is not qualified for insurance
            Console.WriteLine("Are your qualified?");
            bool qualified = (age > 15) && !dui && tickets <= 3;
            Console.WriteLine(qualified);
            Console.ReadLine();
        }
    }
}
