using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Desafios
{
    /// <summary>
    /// Desafio 005 - Desenvolva um programa que leia as duas notas de um aluno, calcule e mostre a
    /// sua média.
    /// </summary>
    public static class Desafio005
    {
        public static void Executar()
        {
            Console.Write("Favor informar a primeira nota: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Favor informar a segunda nota: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            double media = ((nota1 + nota2) / 2);
            Console.WriteLine("A média vale {0}", media);
        }
    }
}
