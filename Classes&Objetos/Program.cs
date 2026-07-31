using System;

namespace ClassesObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            var custumer = new Custumer();
            custumer.Name = "John";
            custumer.LastName = "Doe";
            custumer.Age = 30;
            Console.WriteLine($"Name: {custumer.Name}, Last Name: {custumer.LastName}, Age: {custumer.Age}");
        }
    }
    class Custumer
    {
        public string Name;
        public string LastName;
        public int Age;
    }
}