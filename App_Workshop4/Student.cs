using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Workshop4
{
    internal class Student
    {
        public string name;
        public int age;
        public string address;

        public static string college = "IIC";

        public void PrintDetails() => Console.WriteLine($"Name: {name}, Age: {age}, Address: {address}");
    }
}
