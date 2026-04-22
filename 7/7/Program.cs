using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 0; // Variável acumuladora

            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Digite o {i}º número: "); // Pede o número
                int numero = int.Parse(Console.ReadLine()); // Lê e converte para inteiro
                soma += numero; // Adiciona o número ao total da soma
            }

            Console.WriteLine($"A soma total é: {soma}"); // Mostra o resultado
        }
    }
}
