using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. create a list of at least 10 employees. At least two employees should have the first name “Joe”.
            List<Employee> Employees = new List<Employee>
        {
            new Employee { Id = 01, FirstName = "Mark", LastName = "Ecleo" },
            new Employee { Id = 02, FirstName = "Jefferson", LastName = "Diso" },
            new Employee { Id = 03, FirstName = "Joe", LastName = "Reagan" },
            new Employee { Id = 04, FirstName = "Noel", LastName = "Ador" },
            new Employee { Id = 05, FirstName = "Xandro", LastName = "Senes" }, // An extra Joe
            new Employee { Id = 06, FirstName = "James", LastName = "Hetfield" },
            new Employee { Id = 07, FirstName = "Jane", LastName = "Smith" },
            new Employee { Id = 08, FirstName = "Joe", LastName = "Johnson" },
            new Employee { Id = 09, FirstName = "Jhane", LastName = "Napasi" },
            new Employee { Id = 10, FirstName = "Arnel", LastName = "Miranda" },
            new Employee { Id = 11, FirstName = "Maegan", LastName = "Fox" },
            new Employee { Id = 12, FirstName = "Joe", LastName = "Bermas" }
        };

            // 3. Using a foreach loop, create a new list of all employees with the first name “Joe”. In your comparison statement, remember to reference the property of the object you are checking.
            List<Employee> AllJoe = new List<Employee>();
            foreach (var employee in Employees)
            {
                // Check if the current employee's first name is "Joe"
                if (employee.FirstName == "Joe")
                {
                    AllJoe.Add(employee);
                }
            }

            //print to console all names with Joe
            Console.WriteLine("Employees with First Name Joe :");
            foreach (var joe in AllJoe)
            {
                Console.WriteLine(" [ID : " + joe.Id + "] " + joe.FirstName + " " + joe.LastName);
            }
            Console.WriteLine(("**************************"));
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadLine();


            // 4. Perform the same action again, but this time with a lambda expression.
            // The lambda expression `e => e.FirstName == "Joe"` acts as a predicate.
            List<Employee> joesLambda = Employees.Where(e => e.FirstName == "Joe").ToList();

            Console.WriteLine("Employees named Joe (using lambda expression):");
            foreach (var joe in joesLambda)
            {
                Console.WriteLine(" [ID : " + joe.Id + "] " + joe.FirstName + " " + joe.LastName );
            }
            Console.WriteLine(("________________________________"));

            // 5. Using a lambda expression, make a list of all employees with an Id number greater than 5.
            // The lambda expression `e => e.Id > 5` filters employees based on their Id property.
            List<Employee> IDGreaterThanFive = Employees.Where(e => e.Id > 5).ToList();

            Console.WriteLine("\nEmployees with Id greater than 5 (using lambda expression):");
            foreach (var employee in IDGreaterThanFive)
            {
                Console.WriteLine(" [ID : " + employee.Id + "] " + employee.FirstName + " " + employee.LastName );
            }
            Console.WriteLine(("________________________________"));
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadLine();

        }
    }
}
