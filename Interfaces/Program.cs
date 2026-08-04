using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var pagamento = new Pagamento();
            pagamento.Vencimento = DateTime.Now.AddDays(30);
            
        }
    }

    public class Pagamento : IPagamento
    {
        public DateTime Vencimento { get; set; }

        public void Pagar(double valor)
        {
         
        }
    }

    public class PagamentoCartao : IPagamento
    {
        public DateTime Vencimento { get; set; }
        public void Pagar(double valor)
        {

        }
    }

    public interface IPagamento
    {
        DateTime Vencimento { get; set; }
        void Pagar(double valor);
    }
}