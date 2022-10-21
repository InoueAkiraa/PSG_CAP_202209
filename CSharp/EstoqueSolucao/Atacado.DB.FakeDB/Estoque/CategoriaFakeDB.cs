using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//UTILIZAR O DOMÍNIO
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
            categorias.Add(new Categoria(1, "Farinhas", true, DateTime.Now));
        }
    }
}
