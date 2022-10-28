using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Atacado.Dominio.AtacadoFrota;

namespace Atacado.DB.FakeDB.AtacadoFrota
{
    public static class FrotaFakeDB
    {
        private static List<Frota> frotas;

        public static List<Frota> Frotas
        {
            get
            {
                if (frotas == null)
                {
                    frotas = new List<Frota>();
                    Carregar();
                }
                return frotas;
            }
        }

        private static void Carregar()
        {
            frotas.Add(new Frota(true, 1, DateTime.Now, "Transporte de Pessoas", 10));

            frotas.Add(new Frota(true, 2, DateTime.Now, "Transporte de Mercadorias", 7));

            frotas.Add(new Frota(true, 3, DateTime.Now, "Transporte de Materiais", 3));

            frotas.Add(new Frota(true, 4, DateTime.Now, "Locomoção", 7));

            frotas.Add(new Frota(true, 5, DateTime.Now, "Transporte de Documentos", 6));
        }
    }
}
