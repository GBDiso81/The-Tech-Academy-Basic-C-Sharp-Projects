using System;


namespace Math_and_Comparison_Operators_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print Program Title
            //use console.readline to have space after program title
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            //Person 1 details
            ////input Person 1 details to compute annual salary
            Console.WriteLine("Person 1 Details: ");
            Console.WriteLine("Hourly Rate?");
            string hourlyrate1 = Console.ReadLine();
            Console.WriteLine("Hours worked per week?");
            string hoursworked1 = Console.ReadLine();

            //person 2 details
            //input Person 2 details to compute annual salary
            Console.WriteLine("Person 2 Details : ");
            Console.WriteLine("Hourly Rate?");
            Double hourlyrate2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            double hoursworked2 = Convert.ToDouble(Console.ReadLine());
            Console.ReadLine();

            //Person 1 Annual Salary
            //takes user input for Person1 and multiply hourly rate by rate per hour and multiplied by 52 weeks in a year
            Console.WriteLine("Person 1 Annual Salary is : ");
            int annualsalary1 = Convert.ToInt32(hourlyrate1) * Convert.ToInt32(hoursworked1) * 52;
            Console.WriteLine(annualsalary1);
            Console.ReadLine();

            //Person 2 Annual Salary
            //takes user input for Person2 and multiply hourly rate by rate per hour and multiplied by 52 weeks in a year
            Console.WriteLine("Person 2 Annual Salary is : ");
            int annualsalary2 = Convert.ToInt32(hourlyrate2) * Convert.ToInt32(hoursworked2) * 52;
            Console.WriteLine(annualsalary2);
            Console.ReadLine();

            //compare if person1 has more salary than person2 and print if it is true or false
            Console.WriteLine("Person 1 makes more money than Person 2?");
            Console.ReadKey();
            bool person1moresalary = annualsalary1 > annualsalary2;
            Console.WriteLine(person1moresalary);
            Console.ReadLine();



            Console.WriteLine("Press any key to exit!");
            Console.ReadKey();





        }
    }
}
