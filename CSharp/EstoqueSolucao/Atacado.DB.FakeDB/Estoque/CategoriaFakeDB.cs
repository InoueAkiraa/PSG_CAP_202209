using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Atacado.Dominio.Estoque;

namespace Atacado.DB.FakeDB.Estoque
{
    public static class CategoriaFakeDB
    {
        private static List<Categoria> categorias;

        public static List<Categoria> Categorias
        {
            get
            {
                if (categorias == null)
                {
                    categorias = new List<Categoria>();
                    Carregar();
                }
                return categorias;
            }
        }

        private static void Carregar()
        {
            categorias.Add(new Categoria(1, "Alimento Infantil", true, DateTime.Now));
            categorias.Add(new Categoria(2, "Suplementos", true, DateTime.Now));
            categorias.Add(new Categoria(3, "Bebidas", true, DateTime.Now));
            categorias.Add(new Categoria(4, "Biscoitos, Bolos e Bolachas", true, DateTime.Now));
            categorias.Add(new Categoria(5, "Carnes", true, DateTime.Now));
            categorias.Add(new Categoria(6, "Congelados", true, DateTime.Now));
            categorias.Add(new Categoria(7, "Conservas", true, DateTime.Now));
            categorias.Add(new Categoria(8, "Doces, Balas, Chocolates e Cia", true, DateTime.Now));
            categorias.Add(new Categoria(9, "Farinhas, Cereais e Complementos", true, DateTime.Now));
            categorias.Add(new Categoria(10, "Fast-Food, Aperitivos e Petiscos", true, DateTime.Now));
            categorias.Add(new Categoria(11, "Frios e Embutidos", true, DateTime.Now));
            categorias.Add(new Categoria(12, "Frutas", true, DateTime.Now));
            categorias.Add(new Categoria(13, "Legumes, Verduras e Grãos", true, DateTime.Now));
            categorias.Add(new Categoria(14, "Massas", true, DateTime.Now));
            categorias.Add(new Categoria(15, "Molhos, Caldos e Condimentos", true, DateTime.Now));
            categorias.Add(new Categoria(16, "Ovos, Leite, Queijo e Cia", true, DateTime.Now));
            categorias.Add(new Categoria(17, "Pães", true, DateTime.Now));
            categorias.Add(new Categoria(18, "Sopas & Cremes", true, DateTime.Now));
            categorias.Add(new Categoria(19, "Diversos", true, DateTime.Now));
        }
    }
}