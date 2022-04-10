using System;
using System.Reflection;

namespace ReflectionTest
{
    public class MainClass
    {
        public static void UseReflection()
        {
            Assembly assembly = Assembly.LoadFrom(@"C:\Users\Sagar\Desktop\parctice .NET\EmployeeManagementSystem\EmployeeManagementSystem\bin\Debug\net6.0\EmployeeManagementSystem.dll");

            Type[] type = assembly.GetTypes();
            foreach(Type t in type)
            {
                Console.WriteLine(t.FullName);
            }
        }

        public static void Main()
        {
            Console.WriteLine("Displaying the types using Reflection.");
            UseReflection();
        }
    }
}