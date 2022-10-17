using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Desafios
{
    /// <summary>
    /// Desafio 001 - Crie um programa que leia o nome de uma pessoa e mostre uma mensagem de
    /// boas-vindas de acordo com o valor digitado.
    /// </summary>
    public static class Desafio001v2
    {
        public static void Executar()
        {
            Console.Write("Favor informar seu primeiro nome: ");
            string nome = Console.ReadLine();
            nome = nome.Trim();
            int pos;

            if (String.IsNullOrEmpty(nome)) //MÉTODO PARA NÃO PERMITIR NULO E VAZIO
            {
                Console.WriteLine("Favor não ficar sem informar o primeiro nome.");
            }
            else if (nome.All(char.IsDigit)) //MÉTODO VERIFICA SE A STRING POSSUI APENAS NÚMEROS
            {
                Console.WriteLine("Favor informar apenas letras.");
            }
            else if (nome.Contains(' ')) //MÉTODO VERIFICA SE A STRING POSSUI ESPAÇOS VAZIOS DENTRO DELA
            {
                pos = nome.IndexOf(' ');
                Console.WriteLine("Seja bem-vindo(a): {0}.", nome.Substring(0, pos));
            }
            else
            {
                Console.WriteLine();

                Console.WriteLine("Seja bem-vindo(a): {0}", nome);
                Console.ReadLine();
            }
        }
            
    }
}
