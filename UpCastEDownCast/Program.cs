using System;

namespace UpCastEDownCast
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person = new Personal();
            person = new Corporate();

        }
    }

    public class Person
    {
        public string Name { get; set; } 
    }

    public class Personal : Person
    {
        public string CPF { get; set; }
    }
    
    public class Corporate : Person
    {
        public string CNPJ { get; set; }
    }
}