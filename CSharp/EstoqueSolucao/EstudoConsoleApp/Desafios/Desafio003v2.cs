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
    public static class Desafio003v2
    {
        public static void Executar()
        {
            double num1, num2;

            Console.Write("Informe o primeiro número: ");
            if (Double.TryParse(Console.ReadLine(), out num1) == false) // VAI TENTAR REALIZAR A CONVERSÃO PARA INT32
            {                                                          // CASO NÃO CONSIGA, EXIBIRÁ MENSAGEM DE ERRO
                Console.WriteLine("Favor informar apenas números");
                return;
            }

            if (num1 < 0)
            {
                Console.WriteLine("Favor informar apenas números positivos.");
                return;
            }

            Console.Write("Informe o segundo número: ");
            if (Double.TryParse(Console.ReadLine(), out num2) == false)
            {
                Console.WriteLine("Favor informar apenas números");
                return;
            }  
            
            if (num2 < 0)
            {
                Console.WriteLine("Favor informar apenas números positivos.");
                return;
            }

            double soma = num1 + num2;

            Console.WriteLine();
            Console.Write("A soma de {0} com {1} é igual a {2}.", num1, num2, soma);
        }
    }
}
