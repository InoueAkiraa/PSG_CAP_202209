using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Desafios
{
    /// <summary>
    /// Desafio 020 - Desenvolva um método que permita a entrada do nome do usuário e exiba
    /// - Imprima a frase “Olá meu nome é: {nome recebido}”.
    /// - O nome com todas as letras maiúsculas e minúsculas.
    /// - Quantas letras ao todo (sem considerar espaços).
    /// - Quantas letras tem o primeiro nome.
    /// </summary>
    public static class Desafio020
    {
        public static void Executar()
        {
            int pos;
            Console.Write("Favor informe seu nome completo: ");
            string nomeCompleto = Console.ReadLine();
            
            Console.Write("Olá meu nome é: {0}", nomeCompleto);
            Console.WriteLine();

            Console.Write("Nome com letras maiúsculas: {0}",nomeCompleto.ToUpper());
            Console.WriteLine();

            Console.Write("Nome com letras minúsculas: {0}", nomeCompleto.ToLower());
            Console.WriteLine();

            Console.Write("Quantidade de letras no nome (sem conter espaços): {0}", nomeCompleto.Replace(" ","").Trim().Length);
            Console.WriteLine();

            pos = nomeCompleto.IndexOf(' ');
            Console.Write("O primeiro nome possui {0} letras.", nomeCompleto.Substring(0, pos).Length);
            Console.WriteLine();
        }
    }
}
