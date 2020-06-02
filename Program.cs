using System;

namespace Aulao8POO
{
    class Program
    {
        static void Main(string[] args)
        {
            CartaoCredito Master = new CartaoCredito();
            Master.limite = 3000f;

            Console.WriteLine("Quanto acrescentar no limite?");
            float acres = float.Parse( Console.ReadLine() );
            
            Master.AumentarLimite(acres);
            Console.WriteLine("Novo limite: R$ " +Master.limite);

            System.Console.WriteLine("Digite a data do pagamento:");
            Master.data = DateTime.Parse( Console.ReadLine() );
            
            System.Console.WriteLine("Data: " + Master.data);
        }
    }
}
