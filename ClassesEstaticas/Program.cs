using System;

namespace ClassesEstaticas
{
    class Program
    {
        static void Main(string[] args)
        {
            Pagamento.Vencimento = DateTime.Now.AddDays(30);
        }


        // Classe estática é uma classe que não pode ser instanciada e só pode conter membros estáticos.
        // Ela é útil para agrupar métodos e propriedades relacionadas que não dependem de uma instância específica da classe.
        public static class Pagamento
        {
            public static DateTime Vencimento { get; set; }
        }

    }
}