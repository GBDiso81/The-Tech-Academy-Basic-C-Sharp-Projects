using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
  
            // 2. Create a variable using the keyword "var"
            var greeting = "Welcome to the Student Details Application!";
            Console.WriteLine(greeting);

            // Create instances of the 'Student' class using different constructors
            
            Console.WriteLine("\n--- Registering Students ---");
            Console.WriteLine("Enter you Full Name: ");
            var inputName = Console.ReadLine();

            var student1 = new student(inputName);
            var student2 = new student("Bob Johnson", "Office Administration");


            Console.ReadLine();



        }
    }
}

