using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {  // Começa no 2, vai até 20 e pula de 2 em 2
            for (int i = 2; i <= 20; i += 2)
            {
                Console.WriteLine(i); // Exibe apenas os pares
            }
        }
    }
}
