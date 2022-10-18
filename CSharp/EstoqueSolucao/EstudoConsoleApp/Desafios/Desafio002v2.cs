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
            int dia, mes, ano;
            Console.Write("Informe o dia: ");
            if (Int32.TryParse(Console.ReadLine(), out dia) == false)
            {
                Console.WriteLine("Favor informar apenas números para o dia.");
                return;
            }
            

            Console.Write("Informe o mês: ");
            if (Int32.TryParse(Console.ReadLine(), out mes) == false) 
            {
                Console.WriteLine("Favor informar apenas números para o mês.");
                return;
            }

            Console.Write("Informe o ano: ");
            if (Int32.TryParse(Console.ReadLine(), out ano) == false)
            {
                Console.WriteLine("Favor informar apenas números para o ano.");
                return;
            }

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
