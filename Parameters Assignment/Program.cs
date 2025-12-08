using System;
using System.Collections.Generic;

namespace ParametersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Instantiate an Employee object with type "string" as its generic parameter.
            // Assign a list of strings as the property value of Things.
            Employee<string> stringEmployee = new Employee<string>();
            stringEmployee.Things = new List<string> { "car", "cellphone", "laptop" };

            // 4. Instantiate an Employee object with type "int" as its generic parameter.
            // Assign a list of integers as the property value of Things.
            Employee<int> intEmployee = new Employee<int>();
            intEmployee.Things = new List<int> { 1, 2, 3, 4 };

            // 5. Create a loop that prints all of the Things to the Console for the string employee
            Console.WriteLine("String Employee Things:");
            foreach (T thing in stringEmployee.Things)
            {
                Console.WriteLine(thing);
            }

            Console.WriteLine("\nInt Employee Things:");
            // Create a loop that prints all of the Things to the Console for the integer employee
            foreach (T thing in intEmployee.Things)
            {
                Console.WriteLine(thing);
            }

        }
    }
}
