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

            Console.WriteLine("\n=== Task 2: Calculator Methods ===");
            Calculator calc = new Calculator();
            calc.PrintWelcome();
            Console.WriteLine("Add: " + calc.Add(10, 20));
            Console.WriteLine("Multiply: " + calc.Multiply(5, 4));
            Console.WriteLine("Multiply default: " + calc.Multiply(5));

            // ====================== Task 3 ======================
            Console.WriteLine("=== Task 3: Parameter Types ===");
            ParameterDemo pd = new ParameterDemo();

            int value = 50;
            pd.Increase(ref value);
            Console.WriteLine($"After Increase(ref): {value}");

            pd.GetFullName(out string fullName);
            Console.WriteLine($"Full name from out: {fullName}");

            int sum = pd.SumAll(1, 2, 3, 4, 5, 10, 20);
            Console.WriteLine($"SumAll result: {sum}\n");
        }
    }
}
