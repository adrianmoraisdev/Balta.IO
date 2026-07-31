using System;

namespace TiposComplexos
{
    class Program
    {
        static void Main(string[] args)
        {



        }

        //Tipos complexos: são tipos que podem armazenar múltiplos valores e podem ter métodos e propriedades.
        //Ex: classes, structs, arrays, listas, dicionários, etc.

        public class Pagamento
        {
            //Propriedades
            DateTime Vencimento;

            //Relacionamento de composição: a classe Pagamento possui um objeto do tipo Address,
            //que representa o endereço de cobrança do pagamento.
            Address BillingAddress;

            //Métodos
            void Pagar()
            {

            }
        }

        public class Address() 
        {
            string ZipCode;
        }

    }
}