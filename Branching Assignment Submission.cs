using System;


namespace Branching_Assignment_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask user to input weight
            Console.WriteLine("Welcome to Package Express");
            Console.WriteLine("Press any key to begin shipping...");
            Console.ReadKey();
            Console.WriteLine("Enter your package Weight :");
            double weight = Convert.ToDouble(Console.ReadLine());



            //check conditon for user input if weigth is above 50, program will exit
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express.");
                Console.WriteLine("Press any key to exit.");
                Console.ReadLine();
            }

            //check user input if weight is less than or equal to 50, program continues and ask user to input package dimension
            else if (weight <= 50)
            {
                Console.WriteLine("Input your package width:");
                double width = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Input your package height:");
                double height = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Input your package lenght:");
                double lenght = Convert.ToDouble(Console.ReadLine());

                double dimensionstotal = width + height + lenght;
                Console.WriteLine("Total Package Dimension : " + dimensionstotal);



                //if total dimension of package is greater than 50, program will exit
                if (dimensionstotal > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                }

                //if total dimensions is below or equal to 50, Quote for shipping will display
                else if (dimensionstotal <= 50)
                {
                    Double quote = (width * height * lenght * weight / 100);
                    Console.WriteLine("Your Shipping quote for your package is : ${0}", quote);


                    Console.ReadLine();
                }



            }
        }
    }
}
