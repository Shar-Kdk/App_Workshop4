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
        }
    }
}
