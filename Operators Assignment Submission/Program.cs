using System;


namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Instantiate first objects of the Employee class and assign values to properties. 
            Employee employee1 = new Employee
            {
                // Assign values to their properties.
                EmployeeId = 1,
                EmpFirstName = "Glen",
                EmpLastName = "Diso"
            };

            // Instantiate second objects of the Employee class and assign values to properties.
            Employee employee2 = new Employee
            {
                //Assign values to their properties.
                EmployeeId = 1,
                EmpFirstName = "Glen Mark",
                EmpLastName = "Diso"
            };

            // Compare the two employee objects using the overloaded '==' operator
            bool areEqual = (employee1 == employee2);

            // Display the result of the equality comparison to the console
            Console.WriteLine($"Is the EmployeeID equal [using (==) Operator]?   \n { areEqual}" );
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadLine();

            // Compare the two employee objects using the overloaded '!=' operator
            bool areNotEqual = (employee1 != employee2);

            // Display the result of the inequality comparison to the console
            Console.WriteLine($"Is the EmployeeID not equal [using (!=) Operator]?  \n { areNotEqual}");
            

            // Keep the console window open
            
            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadLine();
        }
    }
}
