using System;

namespace NixLesson3
{
    class Person
    {
        public string Name { get; set; }
        public virtual void Display()
        {
            Console.WriteLine($"Person {Name}");
        }
    }
    class Employee : Person
    {
        public string Company { get; set; }
        public override void Display()
        {
            Console.WriteLine($"Employee {Name}");
        }
    }
    class Manager : Employee
    {
        public override void Display()
        {
            Console.WriteLine($"Manager {Name}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Manager { Name = "Bob", Company = "Microsoft" };
            Employee employee = (Employee)person;
            employee.Display();
            Console.Write(employee.Company);

            Console.ReadKey();
        }
    }

}
