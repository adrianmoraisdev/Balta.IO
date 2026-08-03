using System;

namespace Propriedades
{
    class Program
    {
        static void Main(string[] args)
        {
            var pagamento = new Pagamento();
            pagamento.NumeroBoleto = "123456789";


        }


        public class Pagamento
        {


            //Propriedades
            public string NumeroBoleto { get; set; }
            public DateTime Vencimento { get; set; }

            private DateTime _dataPagamento;

            public DateTime DataPagamento
            {
                get {
                    Console.WriteLine("Lendo o Valor");
                    return _dataPagamento; }
                set {
                    Console.WriteLine("Atribuindo o Valor");
                    _dataPagamento = value; }
            }
        }
    }
}