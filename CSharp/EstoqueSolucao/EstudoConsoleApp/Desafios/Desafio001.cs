using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Desafios
{
    /// <summary>
    /// Desafio 001 - Crie um programa que leia o nome de uma pessoa e mostre uma mensagem de
    /// boas-vindas de acordo com o valor digitado.
    /// </summary>
    public static class Desafio001
    {
        public static void Executar()
        {
            Console.WriteLine("Favor informar seu primeiro nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Seja bem-vindo(a): {0}", nome);
            Console.ReadLine();
        }
    }
}
