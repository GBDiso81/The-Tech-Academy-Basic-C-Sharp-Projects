        using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Array of strings
        string[] fruitArray = { "Apple", "Banana", "Cherry", "Dragon Fruit", "ElderBerry", "Feijoa", "Grape", "Honeydew Melon", " Imbe", "Jackfruit" };
        // Ask the user to select number between index 0 to 10
        Console.WriteLine("Select number between 1 to 10 to display your lucky fruit today: ");
        int inputNum = Convert.ToInt32(Console.ReadLine());
        bool validInput = false;

        while (!validInput)
        {
            try
            {
                Console.WriteLine("Wow.... Your Lucky fruit for today is " + fruitArray[inputNum] + "!");
                validInput = true;
                Console.ReadLine();
            }

            catch
            {
                // displays message when the user selects an index that doesn’t exist.
                Console.WriteLine("Please input only number between 0 to 10!");
                inputNum = Convert.ToInt32(Console.ReadLine());
            }
        }
    




        //  Array of integers
        int[] numlineArray = { 3, 6, 12, 23, 33, 91, 24, 77, 32, 11, 64, 21, 8, 18, 45, };
        // Ask the user to select number between index 0 to 15
        Console.WriteLine("Select between 1 to 15 to assign your jersey number: ");
        int inputNumber = Convert.ToInt32(Console.ReadLine());
        bool validNum = false;

        while (!validNum)
        {
            try
            {
                Console.WriteLine("Your Jersey number is " + numlineArray[inputNumber] + "!");
                validNum = true;
                Console.ReadLine();
            }

            catch
            {
                // displays message when the user selects an index that doesn’t exist.
                Console.WriteLine("Please input only number between 0 to 15!");
                inputNumber = Convert.ToInt32(Console.ReadLine());

            }
        }

        //list of strings
        List<string> teamList = new List<string> { "Hoopers", "Stealers", "Screamers", "Sparks", "Strikers", "Ignites", "Volts", "Smash", "Rocks", "Miners", };
        // Ask the user to select number between index 0 to 10
        Console.WriteLine("Select number between o to 10 for your assigned Team : ");
        int inputTeam = Convert.ToInt32(Console.ReadLine());
        bool validTeam = false;

        while (!validTeam)
        {
            try
            {
                Console.WriteLine("Your assigned Team is " + teamList[inputTeam] + "..." + "Congratulations!");
                validTeam = true;
                Console.ReadLine();
            }

            catch
            {
                // displays message when the user selects an index that doesn’t exist.
                Console.WriteLine("Please input only number between 0 to 10! ");
                inputTeam = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
            
        
    

    

    
        





        
    



        
    

