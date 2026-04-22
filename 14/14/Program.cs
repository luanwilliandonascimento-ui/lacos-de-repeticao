using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int maior = 0;
                for (int i = 1; i <= 10; i++)
                {
                    Console.Write($"Digite o {i}º número: ");
                    int numero = int.Parse(Console.ReadLine());
                    if (numero > maior)
                    { // Comparação: se o novo for maior...
                        maior = numero; // ...ele assume o trono
                    }
                }

                Console.WriteLine($"O maior valor digitado foi:" +maior);
            }
        }
    }
}
            

            
        

