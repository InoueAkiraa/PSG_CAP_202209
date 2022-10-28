using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Atacado.Repositorio.Base;
using Atacado.Dominio.AtacadoFrota;
using Atacado.DB.FakeDB.AtacadoFrota;

namespace Atacado.Repositorio.AtacadoFrota
{
    public class MotocicletaRepo : BaseRepositorio<Motocicleta>
    {
        private AtacadoFrotaContexto contexto;

        public MotocicletaRepo()
        {
            this.contexto = new AtacadoFrotaContexto();
        }

        public override Motocicleta Create(Motocicleta instancia)
        {
            return this.contexto.AddMotocicleta(instancia);
        }

        public override Motocicleta Delete(int chave)
        {
            Motocicleta del = this.Read(chave);
            if (this.contexto.Motocicletas.Remove(del) == false)
            {
                return null;
            }
            else
            {
                return del;
            }
        }

        public override Motocicleta Delete(Motocicleta instancia)
        {
            return this.Delete(instancia.Codigo);
        }

        public override Motocicleta Read(int chave)
        {
            return this.contexto.Motocicletas.SingleOrDefault(cat => cat.Codigo == chave);
        }

        public override List<Motocicleta> Read()
        {
            return this.contexto.Motocicletas;
        }

        public override Motocicleta Update(Motocicleta instancia)
        {
            Motocicleta atu = this.Read(instancia.Codigo);
            if (atu == null)
            {
                return null;
            }
            else
            {
                atu.Ativo = instancia.Ativo;
                atu.DataInclusao = instancia.DataInclusao;
                atu.Chassi = instancia.Chassi;
                atu.Cor = instancia.Cor;
                atu.Marca = instancia.Marca;
                atu.Modelo = instancia.Modelo;
                atu.Placa = instancia.Placa;
                atu.PesoBruto = instancia.PesoBruto;
                atu.PesoLiquido = instancia.PesoLiquido;
                atu.PesoTotal = instancia.PesoTotal;
                return atu;
            }
        }
    }
}
