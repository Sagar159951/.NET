using System;
using System.Collections.Generic;
namespace usingList
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Display()
        {
            Console.WriteLine(Id);
            Console.WriteLine(Name);
        }
    }

    public class MainClass
    {
        public static void Main()
        {
            List<Employee> emp = new List<Employee>()
            {
                new Employee(){Id= 1, Name ="Sagar"},
                new Employee(){Id= 2, Name ="Jhon"},
                new Employee() {Id= 3, Name ="Jos"}
            };

            emp.Add(new Employee() { Id=1, Name="Ryan"});

            foreach (Employee e in emp)
            {
                e.Display();
            }

            Console.WriteLine("Total number of Empoyees in the List are {0}", emp.Count);
        }
    }
}