using System;

namespace test_github
{
    class Person
    {
        public string name;
        static public string personality;
        public Car car;

    }

    class Car
    {
        public string  color;
        static public string make;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person();
            var person2 = new Person();
            var car1 = new Car();
            var car2 = new Car();

            Console.WriteLine("Enter name: ");
            string input = Console.ReadLine();
            Console.ReadLine();
        }
    }
}

