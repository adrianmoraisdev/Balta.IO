using System;

namespace Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            var pagamento = new PagamentoCartao();
            pagamento.Pagar("123456789");


        }



        public class Pagamento
        {

            public DateTime DataPagamento { get; set; }

            public Pagamento()
            {
                Console.WriteLine("Iniciando Pagamento");
                DataPagamento = DateTime.Now;
            }


            //Metodos
            public virtual void Pagar(string numero)
            {
                Console.WriteLine("Pagamento realizado.");
            } 

        }
        public class PagamentoCartao : Pagamento
        {
            //Metodos
            public override void Pagar(string numero)
            {
                Console.WriteLine("Pagamento realizado com cartão de crédito.");
            }
        }
    }
}