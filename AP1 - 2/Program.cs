using System;

namespace AP1___2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Infome o numero que deseja verificar:");
            VerificarParOuImpar(int.Parse(Console.ReadLine()));
        }

        private static void VerificarParOuImpar(int numero)
        {
            if(numero %2 == 0)
                Console.WriteLine("PAR");
            else
                Console.WriteLine("IMPAR");
        }
    }
}
