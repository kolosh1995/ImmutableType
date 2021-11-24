using System;

namespace ImmutableType
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Kolosh", "Borusiv");
            Employee employee = new Employee("Dima", "Izyaslav");
            Person personBase = new Employee("Ivan", "Osrog");

            Console.WriteLine($"{person.Name} {person.Address}");
            Console.WriteLine($"{employee.Name} {employee.Address}");
            Console.WriteLine(personBase.GetInfo());

            Console.ReadKey();
        }
    }

    class Person
    {
        public Person(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public string Name { get; private set; }
        public string Address { get; private set; }

        public virtual string GetInfo()
        {
            return "Person class";
        }
    }

    class Employee : Person
    {
        public Employee(string name, string address) : base(name, address)
        {
        }
        public override string GetInfo()
        {
            return "Employee class";
        }
    }
}
