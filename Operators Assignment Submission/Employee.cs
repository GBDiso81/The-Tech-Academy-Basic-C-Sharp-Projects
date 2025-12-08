using System;


namespace OperatorsAssignment
{
    //1. Create an Employee class with Id, FirstName and LastName properties. 
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmpFirstName { get; set; }
        public string EmpLastName { get; set; }

        //2. In the Employee class, overload the “==” operator so it checks if two Employee objects are equal by comparing their Id property. 
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            return employee1.EmployeeId == employee2.EmployeeId;
        }

        // Overload in pairs the operator "==" with operator "!==" .
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return !(employee1 == employee2);
        }

        // Override the standard Equals method for consistency
        public override bool Equals(object obj)
        {
            // Check if the object is an Employee and then use the overloaded ==
            if (obj is Employee other)
            {
                return this == other;
            }
            return false;
        }

        // Override GetHashCode to avoid compiler warnings and ensure consistent behavior
        public override int GetHashCode()
        {
            return EmployeeId.GetHashCode();

        }
    }
}
