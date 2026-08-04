using System;

namespace ClassesSeladas
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        // Classes seladas não podem ser herdadas, ou seja, não podem ter subclasses.
        public sealed class Pagamento
        {
            public DateTime Vencimento { get; set; }
        }

        // Esta classe não pode ser herdada devido à palavra-chave 'sealed'
        // public class PagamentoCartao : Pagamento
        // {
        //     public DateTime Vencimento { get; set; }
        // }
    }
}