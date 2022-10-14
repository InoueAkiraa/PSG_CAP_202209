using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Aulas
{
    public static class ComparacoesLogicas
    {
        public static void MaiorQue(int x, int y)
        {
            if (x > y)
            {
                Console.WriteLine("{0} é maior que {1}.", x, y);
            } 
            else
            {
                Console.WriteLine("{0} não é maior que {1}.", x, y);
            }
        }

        public static void MenorQue(int x, int y)
        {
            if (x < y)
            {
                Console.WriteLine("{0} é menor que {1}.", x, y);
            }
            else
            {
                Console.WriteLine("{0} não é menor que {1}", x, y);
            }
        }
    }
}
