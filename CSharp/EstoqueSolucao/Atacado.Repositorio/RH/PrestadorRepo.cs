using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atacado.DB.FakeDB.RH;
using Atacado.Dominio.RH;
using Atacado.Repositorio.Base;

namespace Atacado.Repositorio.RH
{
    public class PrestadorRepo : BaseRepositorio<Prestador>
    {
        private RHContexto contexto;

        public PrestadorRepo()
        {
            this.contexto = new RHContexto();
        }

        public override Prestador Create(Prestador instancia)
        {
            return this.contexto.AddPrestador(instancia);
        }        

        public override Prestador Read(int chave)
        {
            return this.contexto.Prestadores.SingleOrDefault(usr => usr.Id == chave);
        }

        public override List<Prestador> Read()
        {
            return this.contexto.Prestadores;
        }

        public override Prestador Update(Prestador instancia)
        {
            Prestador atu = this.Read(instancia.Id);
            if (atu == null)
            {
                return null;
            }
            else
            {
                atu.Cnpj = instancia.Cnpj;
                atu.InscricaoEstadual = instancia.InscricaoEstadual;
                atu.Fundacao = instancia.Fundacao;
                atu.NomeFantasia = instancia.NomeFantasia;
                atu.RazaoSocial = instancia.RazaoSocial;
                atu.EmailCorporativo = instancia.EmailCorporativo;
                atu.DataContratoInicial = instancia.DataContratoInicial;
                atu.DataContratoFinal = instancia.DataContratoFinal;
                return atu;
            }
        }
        public override Prestador Delete(int chave)
        {
            Prestador del = this.Read(chave);
            if (this.contexto.Prestadores.Remove(del) == false)
            {
                return null;
            }
            else
            {
                return del;
            }
        }

        public override Prestador Delete(Prestador instancia)
        {
            return this.Delete(instancia.Id);
        }
    }
}
