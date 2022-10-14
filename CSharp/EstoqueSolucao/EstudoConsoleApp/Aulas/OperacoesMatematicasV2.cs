using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Aulas
{
    public static class OperacoesMatematicasV2
    {
        public static int Somar(int x, int y)
        {
            return x + y;
        }

        public static int Subtrair(int x, int y)
        {
            return x - y;
        }

        public static int Multiplicar(int x, int y)
        {
            return x * y;
        }

        public static double Dividir(double x, double y)
        {
            return x / y;
        }

        public static double Potenciacao(double x, double y)
        {
            //x ^ y
            return Math.Pow(x, y);
        }

        public static double Radiciacao(double x)
        {
            //x^2
            return Math.Sqrt(x);
        }
    }
}
