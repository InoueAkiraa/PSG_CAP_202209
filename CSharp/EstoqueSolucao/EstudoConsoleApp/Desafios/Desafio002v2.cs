using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Desafios
{
    /// <summary>
    /// Desafio 002 – Crie um programa que leia o dia, o mês e ano de nascimento de uma pessoa e
    /// mostre uma mensagem com a data formatada.
    /// </summary>
    public static class Desafio002v2
    {
        public static void Executar()
        {
            Console.WriteLine("Informe o dia: ");
            int dia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o mês: ");
            int mes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o ano: ");
            int ano = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            DateTime data = new DateTime(ano, mes, dia);
            
            if (data > DateTime.Now)
            {
                Console.WriteLine("A data informada ainda não existe !");
            }
            else
            {
                Console.Write("A data informada foi: ");
                Console.Write(data.ToString("dddd, dd/MMMM/yyyy"));
                Console.WriteLine();
                
            }            
        }
    }
}
