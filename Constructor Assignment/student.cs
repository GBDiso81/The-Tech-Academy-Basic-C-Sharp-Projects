using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class student
    {
        // 1. Create a const variable
        // Constants are fixed values that cannot be changed after declaration.
        public const string DefaultSchool = "Academy of Learning";
        public const string DefaultCourse = "Software and Web Developer";

        // Fields to store student properties
        private string name;
        private string course;
        private string school;

        // 3. Chain two constructors together


        public student(string name, string course, string school)
        {
            this.name = name;
            this.course = course;
            this.school = school;
            Console.WriteLine($"\nStudent registered: {this.name} | Course: {this.course} | School: {this.school}");
        }

        public student(string name, string course) : this(name, course, DefaultSchool)
        {
            Console.WriteLine($"\t(Used default school for {name})");
        }

        // Another chained constructor that calls the constructor above it.
        // It provides both a default grade and a default school name.
        public student(string name) : this(name, DefaultCourse)
        {
            Console.WriteLine($"\t(Used default course and school for {name})");
        }
    }
}
