using System;


namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an Employee object with firstName “Sample” and lastName “Student”. 
            Person employee = new Employee();

            
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            // Call the SayName() method on the object
            employee.SayName();
            Console.ReadLine();
        }
    }
}
