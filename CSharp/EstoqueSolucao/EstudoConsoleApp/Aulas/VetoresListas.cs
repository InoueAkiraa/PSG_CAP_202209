using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Aulas
{
    public static class VetoresListas
    {
        public static void Executar()
        {
            List<int> numeros = new List<int>();
            for (int i = 0; i < 500; i++)
            {
                int x = numeros.Count;
                numeros.Add(x * (i * 2));
            }
            for (int i = 0; i < numeros.Count; i++)
            {
                Console.WriteLine("Valor do vetor, na posição {0} = {1}", i, numeros[i]);
            }
        }
    }
}