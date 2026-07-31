using System;

namespace Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            var pagamento = new Pagamento();

        }

        class Pagamento
        {
            //Propriedades
            DateTime Vencimento;

            //Métodos
            void Pagar()
            {
                ConsultarSaldoDoCartao();
            }

            private void ConsultarSaldoDoCartao()
            {


            }

        }
    }
}