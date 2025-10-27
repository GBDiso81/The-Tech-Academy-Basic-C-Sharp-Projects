using System;


namespace Switch_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Weekly Vehicle Coding");
            Console.ReadLine();
            Console.WriteLine("Enter your vehicle plate ending number:");
            int endingnum = Convert.ToInt32(Console.ReadLine());
           
            
            switch (endingnum)
            {
                case 1:
                    Console.WriteLine("Your Vehicle is coded during Monday!");
                    break;
                case 2:
                    Console.WriteLine("Your Vehicle is coded during Monday!");
                    break;
                case 3:
                    Console.WriteLine("Your Vehicle is coded during Tuesday!");
                    break;
                case 4:
                    Console.WriteLine("Your Vehicle is coded during Tuesday!");
                    break;
                case 5:
                    Console.WriteLine("Your Vehicle is coded during Wednesday!");
                    break;
                case 6:
                    Console.WriteLine("Your Vehicle is coded during Wednesday!");
                    break;
                case 7:
                    Console.WriteLine("Your Vehicle is coded during Thursday!");
                    break;
                case 8:
                    Console.WriteLine("Your Vehicle is coded during Thursday!");
                    break;
                case 9:
                    Console.WriteLine("Your Vehicle is coded during Friday!");
                    break;
                case 0:
                    Console.WriteLine("Your Vehicle is coded during Friday!");
                    break;
                default:
                    Console.WriteLine("Invalid Plate! But no coding on weekend...Happy Weekend!");
                    break;


            }

            Console.ReadLine();

            
        }
    }
}
