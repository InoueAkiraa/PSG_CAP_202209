using System;

using EstoqueApp.Model;

namespace EstoqueApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Categoria cat = new Categoria(1, "Teste", true, DateTime.Now);
            cat.Imprimir();
        }
    }
}