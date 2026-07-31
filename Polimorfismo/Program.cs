using System;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            var pagamentoBoleto = new PagamentoBoleto();
            pagamentoBoleto.Pagar();
            pagamentoBoleto.Vencimento = DateTime.Now;
            pagamentoBoleto.NumeroBoleto = "123456789";
            

        }

        class Pagamento
        {
            //Propriedades
            public DateTime Vencimento;

            //Métodos
            public virtual void Pagar()
            {

            }
            // O virtual permite que o método seja sobrescrito em classes derivadas,
            // enquanto o override indica que o método está sendo sobrescrito na classe derivada.
        }
        class PagamentoBoleto : Pagamento
        {
            //Propriedades
            public string NumeroBoleto;

            //Métodos
            public override void Pagar()
            {
                base.Pagar();
            }
            // O override indica que o método está sendo sobrescrito na classe derivada.
        }

        class PagamentoCartao : Pagamento
        {
            //Propriedades
            public string NumeroCartao;

            //Métodos
            public override void Pagar()
            {
                base.Pagar();
            }
            // O override indica que o método está sendo sobrescrito na classe derivada.
        }
    }
}