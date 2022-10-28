using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Atacado.Dominio.AtacadoFrota;

namespace Atacado.DB.FakeDB.AtacadoFrota
{
    public static class CaminhaoFakeDB
    {
        private static List<Caminhao> caminhoes;

        public static List<Caminhao> Caminhoes
        {
            get
            {
                if (caminhoes == null)
                {
                    caminhoes = new List<Caminhao>();
                    Carregar();
                }
                return caminhoes;
            }
        }

        private static void Carregar()
        {
            caminhoes.Add(new Caminhao(true, 1, DateTime.Now, "3h3 dCbw7A sm Al6313", "Branco", "VOLVO",
                "FH 540cv", "HRQ-2425", 44000, 10905, 54905));

            caminhoes.Add(new Caminhao(true, 2, DateTime.Now, "3EA Z650bx 11 Dr9790", "Branco", "SCANIA",
                "R450", "HTV-5394", 33100, 9996, 43096));

            caminhoes.Add(new Caminhao(true, 3, DateTime.Now, "521 nA3A99 WU d05273", "Branco", "VOLVO",
                "460", "HTH-5833", 43630, 8645, 52275));

            caminhoes.Add(new Caminhao(true, 4, DateTime.Now, "21n M8j9wd 4J 036368", "Cinza", "Scania",
                "R500", "HRE-6192", 69000, 9051, 78051));

            caminhoes.Add(new Caminhao(true, 5, DateTime.Now, "602 4SsA9s Ab u64091", "Branco", "MERCEDES-BENZ",
                "AXOR 3344", "HSE-3189", 32000, 9537, 41537));
        }
    }
}
