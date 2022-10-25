using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Atacado.Dominio.RH;

namespace Atacado.DB.FakeDB.RH
{
    public static class ParceiroFakeDB
    {
        private static List<Parceiro> parceiros;

        public static List<Parceiro> Parceiros
        {
            get
            {
                if (parceiros == null)
                {
                    parceiros = new List<Parceiro>();
                    Carregar();
                }
                return parceiros;
            }
        }

        public static void Carregar()
        {
            parceiros.Add(new Parceiro(1, "123", "321", new DateTime(2001, 4, 1), "Hikari Sistemas", "Hikari Desenvolvimento de Sistemas",
                "HikariEmpresa@hotmail", 100, 15, "Desenvolvimento"));

            parceiros.Add(new Parceiro(2, "456", "654", new DateTime(2001, 1, 4), "Soldamax", "Soldaria Max",
                "MaxSoldariaEmpresa@hotmail", 70, 10, "Soldaria"));

            parceiros.Add(new Parceiro(3, "789", "987", new DateTime(2001, 10, 10), "Entulhos e Reformas", "Entulhos, Reformas e Garantia - ERF",
                "ERFEmpresa@hotmail", 50, 5, "Materiais de Construção"));

            parceiros.Add(new Parceiro(4, "001", "110", new DateTime(2001, 4, 4), "Borracharia Golzin de Ouro", "Borracharia Gol de Ouro LTDA",
                "GolDeOuroEmpresa@hotmail", 200, 25, "Borracharia"));

            parceiros.Add(new Parceiro(5, "999", "987", new DateTime(2001, 4, 1), "Posto Cristal de Sangue", "Posto de Saúde Cristal de Sangue",
                "CristalDeSangueEmpresa@hotmail", 100, 15, "Saúde"));
        }

    }
}
