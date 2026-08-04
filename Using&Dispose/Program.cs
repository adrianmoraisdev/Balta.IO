using System;

namespace UsingDispose
{
    class Program
    {
        static void Main(string[] args)
        {
            // O bloco using é usado para garantir que o objeto seja descartado corretamente após o uso,
            // chamando automaticamente o método Dispose()
            // quando o bloco é finalizado.
            using (var pagamento = new Pagamento())
            {
                Console.WriteLine("Processando Pagamento");
            }
        }
        public class Pagamento : IDisposable
        {
            //Garbage Collector (GC) - Coletor de Lixo




            public Pagamento()
            {
                Console.WriteLine("Iniciando Pagamento");
            }

            //Implementando o método Dispose da interface IDisposable
            public void Dispose()
            {
                Console.WriteLine("Finalizando Pagamento");
            }
        }
       
    }
}