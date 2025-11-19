using System.Numerics;

namespace App_Workshop4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======== Task 1: Student Class ========");
            Student s1 = new Student { name = "Shar", age = 20, address = "Kathmandu" };
            Student s2 = new Student { name = "Ram", age = 22, address = "Pokhara" };
            s1.PrintDetails();
            s2.PrintDetails();
            Console.WriteLine("College: " + Student.college);
            Console.WriteLine();

            Console.WriteLine("\n======== Task 2: Calculator Methods ========");
            Calculator calc = new Calculator();
            calc.PrintWelcome();
            Console.WriteLine("Add: " + calc.Add(10, 20));
            Console.WriteLine("Multiply: " + calc.Multiply(5, 4));
            Console.WriteLine("Multiply default: " + calc.Multiply(5));
            Console.WriteLine();

            Console.WriteLine("\n======== Task 3: Parameter Types ========");
            ParameterDemo pd = new ParameterDemo();

            int value = 50;
            pd.Increase(ref value);
            Console.WriteLine($"After Increase(ref): {value}");

            pd.GetFullName(out string fullName);
            Console.WriteLine($"Full name from out: {fullName}");

            int sum = pd.SumAll(1, 2, 3, 4, 5, 10, 20);
            Console.WriteLine($"SumAll result: {sum}\n");
            Console.WriteLine();

            Console.WriteLine("\n======== Task 4: Constructors ========");
            Player p1 = new Player();
            Player p2 = new Player("Warrior", 50, 100);
            p1.Display();
            p2.Display();
            Console.WriteLine();

            Console.WriteLine("======== Task 5: Enums & Records ========");

            // Enum part
            Console.Write("Enter a day of the week: ");
            string input = Console.ReadLine()!.Trim();
            DayType dayType = (input.ToLower() == "saturday" || input.ToLower() == "sunday")
                ? DayType.Weekend : DayType.Weekday;

            Console.WriteLine($"It is: {dayType}\n");

            // Record part
            Book b1 = new Book("Clean Code", "Robert C. Martin", 45.99);
            Book b2 = b1 with { Title = "The Pragmatic Programmer", Price = 52.50 };

            Console.WriteLine("First book:");
            Console.WriteLine(b1);

            var (title, author, price) = b2;
            Console.WriteLine($"Deconstructed second book -> Title: {title}, Author: {author}, Price: {price}\n");
            Console.WriteLine();

            Console.WriteLine("\n======== Task 6: Debugging ========");
            Console.Write("Enter marks obtained: ");
            bool marksOk = int.TryParse(Console.ReadLine(), out int marks);

            Console.Write("Enter total marks: ");
            bool totalOk = int.TryParse(Console.ReadLine(), out int total);

            if (!marksOk || !totalOk || total <= 0)
            {
                Console.WriteLine("Invalid input!");
                return;
            }

            // ← BUG: integer division happens first!
            //double percentage = marks / total * 100;

            // Fixed: Force floating-point division
            double percentage = (double)marks / total * 100;

            Console.WriteLine($"Percentage: {percentage}%");
        }
    }
}