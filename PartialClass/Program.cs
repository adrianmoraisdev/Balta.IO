using System;

namespace PartialClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var payment = new Payments.Payment();
            payment.PropriedadeA = 10;
            payment.PropriedadeB = 20;
        }
    }
}