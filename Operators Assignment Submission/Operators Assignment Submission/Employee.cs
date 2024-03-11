using System;

namespace Operators_Assignment_Submission
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Constructor to initialize properties
        public Employee(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        // Overload the "==" operator to compare Employee objects by their Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // If both objects are null, or both Ids are equal, return true
            if (ReferenceEquals(emp1, emp2))
            {
                return true;
            }

            // If one object is null, or their Ids are not equal, return false
            if (emp1 is null || emp2 is null || emp1.Id != emp2.Id)
            {
                return false;
            }

            return true;
        }

        // Overload the "!=" operator to complement the "==" comparison
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }
    }
}
