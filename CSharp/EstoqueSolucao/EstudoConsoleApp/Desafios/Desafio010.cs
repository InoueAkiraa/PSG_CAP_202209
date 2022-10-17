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
    public static class Desafio010
    {
        public static void Executar()
        {
            Console.Write("Informe o preço do produto: ");
            double preco = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Novo valor com 5% de desconto: {0}.", (preco - (preco * 0.05)));
        }
    }
}
