using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        //// *******ITERATING ASSIGNMENT PART1

        ////Create a one dimensional Array of strings.
        Console.WriteLine("ITERATING ASSIGNMENT PART1");
        Console.WriteLine("Press enter to continue...");
        Console.ReadLine();

        string[] mysport = { "My Favorite sport is ", "I play as ", "My jersey number is " };
        List<string> userinput = new List<string>();

        //Ask user to input text
        Console.WriteLine("Please enter your favorite sport: ");
        userinput.Add(Console.ReadLine());
        Console.WriteLine("Please enter your position in your team: ");
        userinput.Add(Console.ReadLine());
        Console.WriteLine("Please enter your jersey number: ");
        userinput.Add(Console.ReadLine());
        Console.WriteLine("Press enter to continue...");
        Console.ReadLine();
        

        //create a loop and add the user input to the array
        for (int i = 0; i < mysport.Length; i++)
        {
            mysport[i] += userinput[i];
            Console.WriteLine(mysport[i]);
        }
        Console.WriteLine("Press enter to continue...");
        Console.ReadLine();



        // *********************** ITERATING ASSIGNMENT PART2 *****************************
        // INIFNITE LOOP COUNTER

        Console.WriteLine("Infinite Loop Assignment Part 2");
        Console.WriteLine("Press enter to continue...");
        Console.ReadLine();

        int h = 0;
        while (h < 7)
        {
            // The value of 'h' never changes, so the loop runs forever
            Console.WriteLine(h);

            //increment h by 1 to run till it reaches 20 that makes the while loop false
            h++;
        }
        Console.WriteLine("Press enter to continue...");
        Console.ReadLine();



        // ***************** ITERATING ASSIGNMENT PART 3 ********************

        Console.WriteLine("Assignment Part 3");
        Console.WriteLine("Press enter to continue...");
        Console.ReadLine();

        Console.WriteLine("A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<” operator.");
        int J = 0;
        while (J < 5)
        {

            Console.WriteLine(J);

            //increment J by 1 to run till it reaches 5 that makes the "while" loop false
            J++;

        }
        Console.WriteLine("Press enter to continue...");
        Console.ReadLine();


        Console.WriteLine("Add another loop where the comparison that’s used to determine whether to continue iterating the loop is a “<=” operator.");
        int K = 0;
        while (K <= 5)
        {

            Console.WriteLine(K);

            //increment K by 1 to run till it reaches 5 that complete the "while" condition
            K++;

        }
        Console.WriteLine("Press enter to continue...");
        Console.ReadLine();



        // *******************ITERATING ASSIGNMENT PART 4 *********************

        Console.WriteLine("Assignment Part 4");
        Console.WriteLine("Press enter to continue...");
        Console.ReadLine();

        List<string> uniqueItems = new List<string> { "JANUARY", "MARCH", "MAY", "JULY", "AUGUST", "OCTOBER", "DECEMBER" };
        Console.WriteLine("Enter MONTH to search for in the list:");
        string searchInput = Console.ReadLine();
        string uppercase = searchInput.ToUpper();

        bool found = false;
        for (int i = 0; i < uniqueItems.Count; i++)
        {
            if (uniqueItems[i] == uppercase)
            {
                Console.WriteLine($" '{uppercase}' is on the list of months with 31st day! ");
                found = true;
                break; // Stop the loop once found
            }
        }

        if (!found)
        {
            Console.WriteLine($"'{searchInput}' has no 31st day.");
        }

        Console.WriteLine("Press enter to continue...");
        Console.ReadLine();


        //// ************ ITERATING ASSIGNMENT PART 5 *****************

        //// 1. Create a list of strings with identical strings
        Console.WriteLine("Assignment Part 5");
        Console.WriteLine("Press enter to continue...");
        Console.ReadLine();

        List<string> teamlist = new List<string> {
            "MOTOGP TEAM STANDINGS: ",
            "HONDA HRC", // Identical string
            "DUCATI", // Identical string
            "KTM",
            "APRILIA",
            "DUCATI", // Identical string
            "HONDA HRC", // Identical string
            "DUCATI LENOVO",
            "HONDA CASTROL",
            "VR46",

        };

        Console.WriteLine("MotoGP 2025 Teamlist: " + string.Join(", ", teamlist));
        Console.WriteLine("Select Team Name listed above to search for its position in the list:");

        // Ask the user for input
        string searchItem = Console.ReadLine();
        string SearchTeam = searchItem.ToUpper();

        // A flag to check if the item was found at least once
        bool Found = false;

        // 2. Loop through the list and display the indices of matching text
        for (int i = 0; i < teamlist.Count; i++)
        {
            if (teamlist[i] == SearchTeam)
            {
                Console.WriteLine($"Found '{SearchTeam}' at team standings: {i}");
                found = true;
                // Ensure no 'break' statement is here to find all matches
            }
        }

        // 3. Add code to check if the user input was not on the list
        if (!found)
        {
            Console.WriteLine($"Sorry, '{searchItem}' is not on the list.");
        }

        // Keep console window open
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();


        // ********************* ITERATING ASSIGNMENT PART6 *********************

        Console.WriteLine("Assignment Part 6");
        Console.WriteLine("Press enter to continue...");
        Console.ReadLine();

        List<string> stringList = new List<string> { "JORDAN1", "JORDAN11", "JORDAN3", "JORDAN4", "JORDAN5", "JORDAN4", "JORDAN6", "JORDAN11", "JORDAN7" };
        HashSet<string> encounteredStrings = new HashSet<string>();

        //Create for each loop that will check item in the list for any duplicates and display wheter or not item is already on the list
        foreach (string item in stringList)
        {
            if (encounteredStrings.Contains(item))
            {
                Console.WriteLine($"{item} is already on the list.");
            }
            else
            {
                Console.WriteLine($"{item} has NO duplicate item.");
                encounteredStrings.Add(item); // Add the string to the set of encountered strings
            }
            System.Threading.Thread.Sleep(500);

            
            

        }

        // Keep the console window open so the user can see the output
        Console.WriteLine("Press enter to continue...");
        Console.ReadLine();

            

        }
    }













