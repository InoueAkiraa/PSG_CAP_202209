using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Desafios
{
    /// <summary>
    /// Desafio 019 - Desenvolva um método que solicite a entrada de um número e calcule se o número
    /// é par ou ímpar.
    /// </summary>
    public static class Desafio019
    {
        public static void Executar()
        {
            Console.WriteLine("Favor informar um número inteiro");
            int numero = Convert.ToInt32(Console.ReadLine());

            if ((numero % 2) == 0)
            {
                Console.WriteLine("Você informou um número par.");
            }
            else
            {
                Console.WriteLine("Você informou um número ímpar.");
            }

        }
    }
}
