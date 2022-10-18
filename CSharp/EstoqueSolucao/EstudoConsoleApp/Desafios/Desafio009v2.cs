using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Desafios
{
    /// <summary>
    /// Desafio 009 - Faça um programa que leia a largura e a altura de uma parede em metros, e calcule
    /// a sua área e a quantidade de tinta necessária para pintá-la, sabendo que cada litro de tinta pinta
    /// uma área de 2 metros quadrados.
    /// </summary>
    public static class Desafio009v2
    {
        public static void Executar()
        {
            double largura, altura, area;
            Console.Write("Informe a largura: ");
            if (Double.TryParse(Console.ReadLine(), out largura) == false)
            {
                Console.WriteLine("Favor informar apenas números.");
                return;
            }

            if (largura < 0)
            {
                Console.WriteLine("Favor informar apenas valores positivos para a largura.");
                return;
            }

            Console.Write("Informe a altura: ");
            if (Double.TryParse(Console.ReadLine(), out altura) == false)
            {
                Console.WriteLine("Favor informar apenas números.");
                return;
            }

            if (altura < 0)
            {
                Console.WriteLine("Favor informar apenas valores positivos para a altura.");
                return;
            }

            area = largura * altura;
            Console.WriteLine("Para uma área de {0} metros quadrados, serão utilizados {1} litros de tinta.", area, (area / 2));
        }
    }
}
