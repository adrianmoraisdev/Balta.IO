using System;

namespace ClassesAbstratas
{
    class Program
    {
        static void Main(string[] args)
        {
            var pagamento = new Pagamento();

        }
    }

    // Absttract serve para definir um contrato, mas não pode ser instanciada.
    public abstract class Pagamento : IPagamento
    {
        public DateTime Vencimento { get; set; }

        public virtual void Pagar(double valor)
        {

        }
    }

    public class PagamentoCartao : Pagamento
    {
        public override void Pagar(double valor)
        {
           base.Pagar(valor);
        }
    }

    public class PagamentoBoleto : Pagamento
    {
        public override void Pagar(double valor)
        {
            base.Pagar(valor);
        }
    }

    public class PagamentoApplePay : Pagamento
    {
        public override void Pagar(double valor)
        {
            base.Pagar(valor);
        }
    }

    public interface IPagamento
    {
        DateTime Vencimento { get; set; }
        void Pagar(double valor);
    }
}