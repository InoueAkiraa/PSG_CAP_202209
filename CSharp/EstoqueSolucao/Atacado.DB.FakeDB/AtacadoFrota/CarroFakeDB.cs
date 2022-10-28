using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Atacado.Dominio.AtacadoFrota;

namespace Atacado.DB.FakeDB.AtacadoFrota
{
    public static class CarroFakeDB
    {
        private static List<Carro> carros;

        public static List<Carro> Carros
        {
            get
            {
                if (carros == null)
                {
                    carros = new List<Carro>();
                    Carregar();
                }
                return carros;
            }
        }

        private static void Carregar()
        {
            carros.Add(new Carro(true, 1, DateTime.Now, "47M 5NzSAA P8 RK8232", "Cinza", "Peugeot",
                "208", "HSE-7846", 1139, 1096, 2235, 5));

            carros.Add(new Carro(true, 2, DateTime.Now, "2yV UAEA2V 4A AE9875", "Cinza", "Hyundai",
                "HB20S", "HRZ-5812", 670, 1137, 1807, 5));

            carros.Add(new Carro(true, 3, DateTime.Now, "6JN M29RAW sG 6u3847", "Branco", "Fiat",
                "Cronos", "HSV-6426", 400, 1155, 1555, 5));

            carros.Add(new Carro(true, 4, DateTime.Now, "6SB EXb2PN vK Ar6372", "Azul", "Renault",
                "Kwid", "HSU-7794", 376, 977, 1353, 4));

            carros.Add(new Carro(true, 5, DateTime.Now, "8G8 N8uebb Fu 9A0203", "Vermelho", "Chevrolet",
                "Onix Plus", "HRU-9396", 375, 1112, 1487, 5));
        }
    }
}
