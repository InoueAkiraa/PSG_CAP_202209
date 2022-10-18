using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Desafios
{
    /// <summary>
    /// Desafio 007 - Faça um programa que leia um número inteiro e mostre na sua tela a sua tabuada.
    /// </summary>
    public static class Desafio007v2
    {
        public static void Executar()
        {
            int numero, contador;
            Console.Write("Informe um número inteiro: ");
            if (Int32.TryParse(Console.ReadLine(), out numero) == false)
            {
                Console.WriteLine("Favor informar apenas números inteiros.");
                return;
            }

            contador = 0;

            while (contador < 10)
            {
                contador++;
                Console.WriteLine("{0} x {1} = {2}.", numero, contador, (numero * contador));
            }
        }
    }
}
