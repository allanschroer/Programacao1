using System;
using System.Collections.Generic;

namespace AP1___3
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidadeMaioridade = 0;

            List<int> idades = new();
            for(var i = 0; i < 10; i++)
            {
                Console.WriteLine($"Insira a idade numero {i + 1}");
                idades.Add(int.Parse(Console.ReadLine()));
            }
           
            foreach(int idade in idades)
            {
                if(idade >= 18)
                    quantidadeMaioridade++;
            }
            Console.WriteLine($"A quantidade de pessoas em maioriadade é de: {quantidadeMaioridade}");
        }
    }
}
