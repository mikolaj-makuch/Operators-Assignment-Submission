using System;

namespace Operators_Assignment_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create two Employee objects
            Employee emp1 = new Employee(1, "John", "Doe");
            Employee emp2 = new Employee(2, "Jane", "Smith");
            Employee emp3 = new Employee(1, "John", "Doe"); // This will have the same Id as emp1

            // Check if emp1 and emp2 are equal
            Console.WriteLine($"Are emp1 and emp2 equal? {emp1 == emp2}");

            // Check if emp1 and emp3 are equal
            Console.WriteLine($"Are emp1 and emp3 equal? {emp1 == emp3}");

            // Check if emp1 and emp2 are not equal
            Console.WriteLine($"Are emp1 and emp2 not equal? {emp1 != emp2}");

            // Check if emp1 and emp3 are not equal
            Console.WriteLine($"Are emp1 and emp3 not equal? {emp1 != emp3}");

            Console.ReadKey();
        }
    }
}
