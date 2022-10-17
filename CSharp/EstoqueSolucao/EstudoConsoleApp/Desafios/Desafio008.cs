using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Desafios
{
    /// <summary>
    /// Desafio 008 - Crie um programa que leia o quanto uma pessoa tem na carteira e mostre quantos
    /// dólares ela pode comprar.
    /// Considere US$ 1,00 = R$ 5,00
    /// </summary>
    public static class Desafio008
    {
        public static void Executar()
        {
            Console.Write("Quanto você tem na carteira: ");
            double valor = Convert.ToDouble(Console.ReadLine());
            double dolar = valor / 5;
            Console.WriteLine("Você pode comprar {0} doláres.", dolar);
        }
    }
}
