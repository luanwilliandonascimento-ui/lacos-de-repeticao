using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite um número: "); //Pede o número 
            int limite = int.Parse(Console.ReadLine()); //Guarda o numero
            for (int i = 1; i <= limite; i++)
            { // Começa em 1 e repete até chegar no número digitado
                Console.Write(i + " ");}// Exibe os numeros ate o final
}
    }
}
