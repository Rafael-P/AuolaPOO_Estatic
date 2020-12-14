using System;

namespace POO_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( Conversor.RealParaDolar(10f) );
            Console.WriteLine( Conversor.DolarParaReal(10f) );

            Console.WriteLine( Conversor.RealParaEuro(10f) );
            Console.WriteLine( Conversor.EuroParaReal(10f) );
        }
    }
}
