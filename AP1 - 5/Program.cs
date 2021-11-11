using System;
using System.Collections.Generic;
using System.Linq;

namespace AP1___5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> altura = new();
            List<int> matricula = new();
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine($"Insira a matricula numero {i + 1}");
                matricula.Add(int.Parse(Console.ReadLine()));

                Console.WriteLine($"Insira a aultra do aluno da matricula {matricula[i]}");
                altura.Add(double.Parse(Console.ReadLine()));
            }
            Console.WriteLine($"Maior aluno : {altura.Max()}, Matricula: {matricula[altura.FindIndex(a => a == altura.Max())]}");
            Console.WriteLine($"Menor aluno : {altura.Min()}, Matricula: {matricula[altura.FindIndex(a => a == altura.Min())]}");
        }
    }
}
