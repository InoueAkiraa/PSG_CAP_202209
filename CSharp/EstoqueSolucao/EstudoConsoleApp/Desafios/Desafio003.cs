using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Desafios
{
    /// <summary>
    /// Desafio 003 – Crie um programa que leia dos números e tente mostrar a soma entre eles.
    /// </summary>
    public static class Desafio003
    {
        public static void Executar()
        {
            Console.Write("Informe o primeiro número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int soma = num1 + num2;
            Console.Write("A soma de {0} com {1} é igual a {2}.", num1, num2, soma);
        }
    }
}
