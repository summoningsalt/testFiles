// Single-file C# demonstration (compatible with modern .NET top-level statements or standard Program.Main)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// 1. Namespace & Program Entry
namespace CSharpSyntaxDemo
{
    // 2. Interfaces
    public interface IWorker
    {
        void Work();
    }

    // 3. Abstract Class
    public abstract class Person
    {
        public string Name { get; set; }
        protected Person(string name) => Name = name;
        public abstract void Introduce();
    }

    // 4. Record Type (Immutable Data)
    public record Point(int X, int Y);

    // 5. Enum
    public enum Status { Pending, Active, Completed }

    // 6. Main Class implementing Interface
    public class Employee : Person, IWorker
    {
        public decimal Salary { get; init; }
        public Status CurrentStatus { get; set; } = Status.Active;

        public Employee(string name, decimal salary) : base(name)
        {
            Salary = salary;
        }

        // Method override
        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name} and I earn {Salary:C}.");
        }

        // Interface implementation
        public void Work()
        {
            Console.WriteLine($"{Name} is working hard...");
        }

        // Method overloading
        public void Work(string task)
        {
            Console.WriteLine($"{Name} is working on: {task}");
        }
    }

    class Program
    {
        static async Task Main(string[] args)
        {
            // --- Variables & Built-in Data Types ---
            int age = 30;
            double score = 95.5;
            decimal price = 19.99m;
            bool isVerified = true;
            char grade = 'A';
            string greeting = "Hello, C#";
            var inferredType = "Compiler figures this is a string";
            const double Pi = 3.14159;

            // --- Nullable Types & Null Coalescing ---
            string? middleName = null;
            string displayName = middleName ?? "None";

            // --- Control Flow (if-else & switch expression) ---
            if (age >= 18)
            {
                Console.WriteLine("Adult");
            }
            else
            {
                Console.WriteLine("Minor");
            }

            Status current = Status.Active;
            string statusMessage = current switch
            {
                Status.Pending => "Waiting to start",
                Status.Active => "In progress",
                Status.Completed => "Done",
                _ => "Unknown"
            };
            Console.WriteLine($"Status: {statusMessage}");

            // --- Loops ---
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"For loop iteration: {i}");
            }

            int count = 0;
            while (count < 2)
            {
                count++;
            }

            // --- Arrays, Lists, & Dictionaries ---
            int[] numbers = { 1, 2, 3, 4, 5 };
            List<string> fruits = new() { "Apple", "Banana", "Cherry" };
            Dictionary<string, int> scoresMap = new()
            {
                { "Alice", 90 },
                { "Bob", 85 }
            };

            foreach (var fruit in fruits)
            {
                Console.WriteLine($"Fruit: {fruit}");
            }

            // --- LINQ (Language Integrated Query) ---
            var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
            var highScores = from kvp in scoresMap
                             where kvp.Value >= 88
                             select kvp.Key;

            // --- OOP & Records Usage ---
            Employee emp = new("Alice", 75000m);
            emp.Introduce();
            emp.Work("Refactoring code");

            Point p1 = new(10, 20);
            var (x, y) = p1; // Deconstruction
            Console.WriteLine($"Point coordinates: X={x}, Y={y}");

            // --- Asynchronous Programming ---
            await Task.Delay(100);
            Console.WriteLine("Async task completed.");
        }
    }
}
