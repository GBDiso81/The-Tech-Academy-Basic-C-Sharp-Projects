using System;


namespace Student_Daily_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            //print and display 
            Console.WriteLine("Academy of Learning Career College");
            Console.WriteLine("Student Daily Report");

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();

            Console.WriteLine("What page number?");
            int pagenum = Convert.ToInt32(Console.ReadLine());
            //boolean data type
            Console.WriteLine("Do you need help with anything? Please answer “true” or “false\".");
            string needhelp = Console.ReadLine();
            bool needhelpbool = bool.Parse(needhelp);

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics");
            string positiveexperiences = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            //convert string to int
            Console.WriteLine("How many hours did you study today?");
            string studyhours = Console.ReadLine();
            int studyhoursnum = Convert.ToInt32(studyhours);

            Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
