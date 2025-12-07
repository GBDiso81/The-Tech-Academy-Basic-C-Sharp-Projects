using System;


namespace MethodsAndObjectsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4. Inside of the Main method, instantiate and initialize an Employee object with a first name of “Sample” and a last name of “Student”.
            Employee employee = new Employee
            {
                FirstName = "Sample",
                LastName = "Student",
                Id = 1 // Assign an arbitrary ID
            };

            // 5. Call the superclass method SayName() on the Employee object.
            employee.SayName();
            Console.ReadLine();

           
        }
    }
}
