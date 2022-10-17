using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Desafios
{
    /// <summary>
    /// Desafio 006 - Escreva um programa que leia um valor em metros e o exiba convertido em
    /// centímetros e milímetros.
    /// </summary>
    public static class Desafio006v2
    {
        public static void Executar()
        {
            double metros;
            Console.Write("Informe o número em metros: ");
            if (Double.TryParse(Console.ReadLine(), out metros) == false)
            {
                Console.WriteLine("Favor informar apenas números.");
            }
            else
            {
                double centimetros = metros * 100;
                double milimetros = metros * 1000;
                Console.WriteLine("{0} metros valem {1} centímetros.", metros, centimetros);
                Console.WriteLine("{0} metros valem {1} milímetros.", metros, milimetros);
            }
        }
    }
}
