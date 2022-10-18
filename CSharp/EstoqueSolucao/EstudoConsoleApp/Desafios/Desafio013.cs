using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Desafios
{
    public static class Desafio013
    {
        /// <summary>
        /// Desafio 013 – Escreva um programa que pergunte a quantidade de km percorridos por um carro
        /// alugado, e a quantidade de dias pelos quais ele foi alugado. Calcule o preço a pagar, sabendo
        /// que o carro custa R$ 60,00 por dia e R$ 0,15 por km rodado.
        /// </summary>
        public static void Executar()
        {
            Console.Write("Favor informar a quantidade de KMs percorridos pelo veículo: ");
            double km = Convert.ToDouble(Console.ReadLine());

            Console.Write("Favor informar a quantidade de dias pelo qual o veículo foi alugado: ");
            int dias = Convert.ToInt32(Console.ReadLine());

            Console.Write("O preço final pelo aluguel e pelos KMs rodados pelo veículo é igual a R$ {0} ", ((dias * 60) + (km * 0.15)));
        }
    }
}

