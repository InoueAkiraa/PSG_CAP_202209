using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Desafios
{
    /// <summary>
    /// Desafio 011 – Faça um programa que leia o salário de um funcionário, e mostre seu novo salário,
    /// com 15% de aumento.
    /// </summary>
    public static class Desafio011
    {
        public static void Executar()
        {
            Console.Write("Informe o salário do funcionário: ");
            double salario = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Novo salário com 15% de aumento: {0}.", (salario + (salario * 0.15)));
        }
    }
}
