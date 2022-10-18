using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Desafios
{
    public static class Desafio012
    {
        /// <summary>
        /// Desafio 012 – escreva um programa que converta uma temperatura digitada em graus celsius
        /// para fahrenheit.
        /// </summary>
        public static void Executar()
        {
            Console.Write("Favor informar qualquer temperatura em graus Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("A temperatura em Celsius {0}°C convertida para Fahrenheit fica {1}°F", celsius, ((celsius * 1.8) + 32));

        }
    }
}
