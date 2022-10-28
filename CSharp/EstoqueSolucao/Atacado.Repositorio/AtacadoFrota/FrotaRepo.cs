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
    public class FrotaRepo : BaseRepositorio<Frota>
    {
        private AtacadoFrotaContexto contexto;

        public FrotaRepo()
        {
            this.contexto = new AtacadoFrotaContexto();
        }

        public override Frota Create(Frota instancia)
        {
            return this.contexto.AddFrota(instancia);
        }

        public override Frota Delete(int chave)
        {
            Frota del = this.Read(chave);
            if (this.contexto.Frotas.Remove(del) == false)
            {
                return null;
            }
            else
            {
                return del;
            }
        }

        public override Frota Delete(Frota instancia)
        {
            return this.Delete(instancia.Codigo);
        }

        public override Frota Read(int chave)
        {
            return this.contexto.Frotas.SingleOrDefault(fro => fro.Codigo == chave);
        }

        public override List<Frota> Read()
        {
            return this.contexto.Frotas;
        }

        public override Frota Update(Frota instancia)
        {
            Frota atu = this.Read(instancia.Codigo);
            if (atu == null)
            {
                return null;
            }
            else
            {
                atu.Ativo = instancia.Ativo;
                atu.DataInclusao = instancia.DataInclusao;
                atu.Finalidade = instancia.Finalidade;
                atu.Veiculos = instancia.Veiculos;
                return atu;
            }
        }
    }
}
