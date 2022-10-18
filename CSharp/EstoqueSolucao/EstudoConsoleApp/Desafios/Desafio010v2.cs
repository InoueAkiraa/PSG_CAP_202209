using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Desafios
{
    /// <summary>
    /// Desafio 010 - Faça um programa que leia o preço de um produto, e mostre seu novo preço, com
    /// 5% de desconto.
    /// </summary>
    public static class Desafio010v2
    {
        public static void Executar()
        {
            double preco;
            Console.Write("Informe o preço do produto: ");
            if (Double.TryParse(Console.ReadLine(), out preco) == false)
            {
                Console.WriteLine("Favor informar apenas números.");
                return;
            }

            if (preco < 0)
            {
                Console.WriteLine("Favor informar apenas valores positivos para o preço.");
                return;
            }

            Console.WriteLine("Novo valor com 5% de desconto: {0}.", (preco - (preco * 0.05)));
        }
    }
}
