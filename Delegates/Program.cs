using System;

namespace Delegates
{
    class Program
    {

        static void RealizarPagamento(double valor)
        {
            Console.WriteLine($"Pagamento realizado no valor de: {valor}");
        }

        static void Main(string[] args)
        {
            var pagamento = new Pagamento.Pagar(RealizarPagamento);
            pagamento(25);


        }
    }

    class Pagamento
    {
        //Delegate que representa um método de pagamento
        public delegate void Pagar(double valor);
     
    }
}