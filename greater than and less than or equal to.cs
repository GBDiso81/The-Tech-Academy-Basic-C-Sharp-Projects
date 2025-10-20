using System;


namespace greater_than_lesser_than
{
    class Program
    {
        static void Main(string[] args)
        {

            //utiliza the greater than operator
            Console.WriteLine("Election Primary Requirement :");
            Console.ReadKey();
            Console.WriteLine("Enter your Age :");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age > 17)
            {
                Console.WriteLine("You are allowed to vote!");
                Console.ReadLine();
            }

            else
                Console.WriteLine("You are not allowed to Vote.");
            Console.ReadLine();


            //utilize the use of less than or equal to operator
            Console.WriteLine("Welcome to Drivers Licensing Department");
            Console.ReadKey();
            Console.WriteLine("Enter your Age :");
            int age1 = Convert.ToInt32(Console.ReadLine());
            if (age1 <= 15)
            {
                Console.WriteLine("You are not allowed to apply for Drivers License.");
                Console.ReadLine();
            }
            else
                Console.WriteLine("You can now submit needed requirements for new application!");
                
            Console.ReadLine();
        }
    }
}
