using System;
using System.Collections.Generic;

namespace AP1___1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> notas = new();
            Console.Write("Insira a primeira nota: ");
            notas.Add(int.Parse(Console.ReadLine()));
            Console.Write("Insira a segunda nota: ");
            notas.Add(int.Parse(Console.ReadLine()));
            Console.Write("Insira a terceira nota: ");
            notas.Add(int.Parse(Console.ReadLine()));
            Console.Write("Insira a quarta nota: ");
            notas.Add(int.Parse(Console.ReadLine()));
            Console.Write("Insira a quinta nota: ");
            notas.Add(int.Parse(Console.ReadLine()));

            CalcularExibirNotaFinal(notas);

        }

        private static void CalcularExibirNotaFinal(List<int> notas)
        {
            int total = 0;
            for (int i = 0; i < notas.Count; i++)
            {
                total += notas[i];
            }
            Console.WriteLine($"MEDIA FINAL: { total / notas.Count}");
        }
    }
}
