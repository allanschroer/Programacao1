using System;
using System.Collections.Generic;

namespace AP1___4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> salarios = new();
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine($"Insira o salario numero {i + 1}");
                salarios.Add(VerificaAjusteSalario(double.Parse(Console.ReadLine())));
            }

            foreach(double salario in salarios)
                Console.WriteLine($"Salario reajustado: {salario}");

            static double VerificaAjusteSalario(double salario)
            {
                if (salario <= 300)
                    return salario += (salario * 0.5);
                else
                    return salario += (salario * 0.3);
            }

        }
    }
}