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
    public static class Desafio005v2
    {
        public static void Executar()
        {
            double nota1, nota2, media;
            Console.Write("Favor informar a primeira nota: ");
            if (Double.TryParse(Console.ReadLine(), out nota1) == false)
            {
                Console.WriteLine("Favor informar apenas números.");
            }

            if ((nota1 < 0) && (nota1 > 10))
            {
                Console.WriteLine("Favor informar valores positivos para a primeira nota.");
                return;
            }

            Console.Write("Favor informar a segunda nota: ");
            if (Double.TryParse(Console.ReadLine(), out nota2) == false)
            {
                Console.WriteLine("Favor informar apenas números.");
            }

            if ((nota2 < 0) && (nota2 > 10))
            {
                Console.WriteLine("Favor informar valores positivos para a segunda nota.");
                return;
            }


            media = ((nota1 + nota2) / 2); //CORRIGIR PARA NÃO REALIZAR ISSO ATÉ VALIDAR
            Console.WriteLine("A média do aluno foi {0}", media);
        }
    }
}
