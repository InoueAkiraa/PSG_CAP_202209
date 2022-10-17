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
    public static class Desafio007
    {
        public static void Executar()
        {
            Console.Write("Informe um número inteiro: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} x 1 = {1}", numero, numero * 1);
            Console.WriteLine("{0} x 2 = {1}", numero, numero * 2);
            Console.WriteLine("{0} x 3 = {1}", numero, numero * 3);
            Console.WriteLine("{0} x 4 = {1}", numero, numero * 4);
            Console.WriteLine("{0} x 5 = {1}", numero, numero * 5);
            Console.WriteLine("{0} x 6 = {1}", numero, numero * 6);
            Console.WriteLine("{0} x 7 = {1}", numero, numero * 7);
            Console.WriteLine("{0} x 8 = {1}", numero, numero * 8);
            Console.WriteLine("{0} x 9 = {1}", numero, numero * 9);
            Console.WriteLine("{0} x 10 = {1}", numero, numero * 10);
        }
    }
}
