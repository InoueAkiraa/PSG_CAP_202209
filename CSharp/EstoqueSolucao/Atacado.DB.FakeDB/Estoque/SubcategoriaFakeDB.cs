using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Atacado.Dominio.Estoque;

namespace Atacado.DB.FakeDB.Estoque
{
    public static class SubcategoriaFakeDB
    {
        private static List<Subcategoria> subcategorias;

        public static List<Subcategoria> Subcategorias
        {
            get
            {
                if (subcategorias == null)
                {
                    subcategorias = new List<Subcategoria>();
                    Carregar();
                }
                return subcategorias;
            }
        }

        private static void Carregar()
        {
            subcategorias.Add(new Subcategoria(1, "Farinha de Mandioca", true, DateTime.Now, 1));
        }
    }
}
