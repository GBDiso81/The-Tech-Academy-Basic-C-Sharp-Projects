using System;


namespace ParsingEnumsAssignment
{
    class Program
    {

        static void Main(string[] args)
        {
            bool isvalid = false;
            while (!isvalid)
            {
                try
                {

                    // 2.Prompt the user to enter the current day of the week.
                    Console.WriteLine("\nPlease enter the current day of the week:");

                    // Read the user's input from the console and store it in a string variable
                    string userInput =  Console.ReadLine();
                    

                    // 3.Assign the value to a variable of that enum data type you just created.
                    //DaysofWeek.DaysOfTheWeek currentDay;

                    // 4.Wrap the above statement in a try/catch block and have it print "Please enter an actual day of the week.” to the console if an error occurs.



                    DaysofWeek.DaysOfTheWeek currentDay = (DaysofWeek.DaysOfTheWeek)Enum.Parse(typeof(DaysofWeek.DaysOfTheWeek), userInput);

                    // If successful, display the day entered back to the console
                    Console.WriteLine($"You entered: { currentDay}");
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadLine();
                    isvalid = true;
                }
                catch (ArgumentException)
                {
                    // The catch block handles the error if the input is not a valid day of the week
                    Console.WriteLine("\nYou have entered incorrect actual day of the week.");
                    Console.ReadLine();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadLine();


                }

            }
        }
    }
}