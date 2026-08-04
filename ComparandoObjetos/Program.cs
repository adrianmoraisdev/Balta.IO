using System;

namespace ComparandoObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
           var pessoa1 = new Pessoa(1, "Adrian Higa");
           var pessoa2 = new Pessoa(1, "Adrian Higa");

            Console.WriteLine(pessoa1.Equals(pessoa2));


        }
    }

    // Implementando a interface IEquatable<T> para comparar objetos
    public class Pessoa : IEquatable<Pessoa>
    {
        public Pessoa(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public int Id { get; set; }
        public string Nome { get; set; }

        public bool Equals(Pessoa pessoa)
        {
            return Id == pessoa.Id && Nome == pessoa.Nome;
        }
    }
}