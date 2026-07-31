using System;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {



        }

        //modificadores de acesso: public, private, protected, internal, protected internal, private protected
        //private: acessível apenas dentro da própria classe
        //protected: acessível dentro da própria classe e em classes derivadas
        //internal: acessível dentro do mesmo assembly
        //protected internal: acessível dentro do mesmo assembly e em classes derivadas
        //private protected: acessível dentro do mesmo assembly e em classes derivadas, mas não fora do assembly

        public class Pagamento
        {
            //Propriedades
            protected DateTime Vencimento;

            //Métodos
            public virtual void Pagar()
            {

            }
            // O virtual permite que o método seja sobrescrito em classes derivadas,
            // enquanto o override indica que o método está sendo sobrescrito na classe derivada.
        }

        public class PagamentoBoleto : Pagamento
        {
            void Test()
            {
                
            }
        }

    }
}