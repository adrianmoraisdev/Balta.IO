using System;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            var pagamentoBoleto = new PagamentoBoleto();
            pagamentoBoleto.Pagar();
            pagamentoBoleto.Vencimento = DateTime.Now;

        }

        class Pagamento
        {
            //Propriedades
            public DateTime Vencimento;

            //Métodos
            public void Pagar()
            {

            }
        }
        class PagamentoBoleto : Pagamento
        {
            //Propriedades
            public string CodigoBarras;

            //Métodos
            public void Pagar()
            {

            }
        }

        class PagamentoCartao : Pagamento
        {
            //Propriedades
            public string NumeroCartao;

            //Métodos
            public void Pagar()
            {
            }
        }
    }
}