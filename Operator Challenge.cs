using System;


namespace Operator_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Football World Cup Series");
            Console.ReadKey();
            Console.WriteLine("Input Score of Team A :");
            int teamA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input Score of Team B:");
            int teamB = Convert.ToInt32(Console.ReadLine());

            if (teamA != teamB) 
             Console.WriteLine("One Team will move to the Playoff!");


            else

            Console.WriteLine("We are going to Overtime!");

            Console.ReadLine();



            

        } 
    }
}
