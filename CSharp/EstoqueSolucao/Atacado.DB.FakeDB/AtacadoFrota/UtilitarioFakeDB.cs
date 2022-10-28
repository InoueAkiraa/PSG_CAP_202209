using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Atacado.Dominio.AtacadoFrota;

namespace Atacado.DB.FakeDB.AtacadoFrota
{
    public static class UtilitarioFakeDB
    {
        private static List<Utilitario> utilitarios;

        public static List<Utilitario> Utilitarios
        {
            get
            {
                if (utilitarios == null)
                {
                    utilitarios = new List<Utilitario>();
                    Carregar();
                }
                return utilitarios;
            }
        }

        private static void Carregar()
        {
            utilitarios.Add(new Utilitario(true, 1, DateTime.Now, "32m dv12MN x1 1h7507", "Branco",
                "Chevrolet", "Montana", "HTE-9336", 756, 1109, 1865));

            utilitarios.Add(new Utilitario(true, 2, DateTime.Now, "1AY ASY9Ch tx A19717", "Vermelho",
                "Toyota", "Hilux SRV CD 2.7 4×4", "HRO-2296", 1000, 1970, 2970));

            utilitarios.Add(new Utilitario(true, 3, DateTime.Now, "1Ah A5B8dc P8 297924", "Branco",
                "Fiat", "Ducato Minibus 2.3 TD", "HSH-0270", 1630, 2120, 3750));

            utilitarios.Add(new Utilitario(true, 4, DateTime.Now, "2Fh a6Ab8c 4L A68234", "Branco",
                "Renault", "Kangoo 1.6", "HTI-1467", 800, 1075, 1875));

            utilitarios.Add(new Utilitario(true, 5, DateTime.Now, "67N gAAtv2 5X Mz4141", "Preto",
                "Fiat", "Toro Endurance 1.8", "HTE-8692", 720, 1619, 2339));
        }
    }
}
