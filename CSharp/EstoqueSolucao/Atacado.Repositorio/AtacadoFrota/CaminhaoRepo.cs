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
    public class CaminhaoRepo : BaseRepositorio<Caminhao>
    {
        private AtacadoFrotaContexto contexto;

        public CaminhaoRepo()
        {
            this.contexto = new AtacadoFrotaContexto();
        }

        public override Caminhao Create(Caminhao instancia)
        {
            return this.contexto.AddCaminhao(instancia);
        }

        public override Caminhao Delete(int chave)
        {
            Caminhao del = this.Read(chave);
            if (this.contexto.Caminhoes.Remove(del) == false)
            {
                return null;
            }
            else
            {
                return del;
            }
        }

        public override Caminhao Delete(Caminhao instancia)
        {
            return this.Delete(instancia.Codigo);
        }

        public override Caminhao Read(int chave)
        {
            return this.contexto.Caminhoes.SingleOrDefault(cat => cat.Codigo == chave);
        }

        public override List<Caminhao> Read()
        {
            return this.contexto.Caminhoes;
        }

        public override Caminhao Update(Caminhao instancia)
        {
            Caminhao atu = this.Read(instancia.Codigo);
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
