using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Atacado.Dominio.AtacadoFrota;

namespace Atacado.DB.FakeDB.AtacadoFrota
{
    public static class MotocicletaFakeDB
    {
        private static List<Motocicleta> motocicletas;

        public static List<Motocicleta> Motocicletas
        {
            get
            {
                if (motocicletas == null)
                {
                    motocicletas = new List<Motocicleta>();
                    Carregar();
                }
                return motocicletas;
            }
        }

        private static void Carregar()
        {
            motocicletas.Add(new Motocicleta(true, 1, DateTime.Now, "1wJ 8M4AWS ht pa8199", "Branco",
                "Honda", "Pop 110i", "HTU-6566", 158, 87, 158));

            motocicletas.Add(new Motocicleta(true, 2, DateTime.Now, "5UL 7PG74E 1j hY3873", "Preto",
                "Shineray", "Worker 125", "HSR-0668", 168, 98, 168));

            motocicletas.Add(new Motocicleta(true, 3, DateTime.Now, "4tt lA0jbb uC At7464", "Vermelha",
                "Shineray", "JET 125", "HRK-2795", 186, 106, 186));

            motocicletas.Add(new Motocicleta(true, 4, DateTime.Now, "5d1 484z5Y s3 Y86869", "Prata",
                "Honda", "Biz 110i", "HTG-2581", 165, 99, 165));

            motocicletas.Add(new Motocicleta(true, 5, DateTime.Now, "7FP 0Ag7Ra yL 5b4510", "Vermelha",
                "Honda", "Elite 125", "HQP-8307", 185, 104, 185));
        }
    }
}
