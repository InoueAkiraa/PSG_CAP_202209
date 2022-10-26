using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Atacado.Dominio.RH;
using Atacado.DB.FakeDB.RH;
using Atacado.Repositorio.Base;

namespace Atacado.Repositorio.RH
{
    public class EnderecoRepo : BaseRepositorio<Endereco>
    {
        private RHContexto contexto;

        public EnderecoRepo()
        {
            this.contexto = new RHContexto();
        }

        public override Endereco Create(Endereco instancia)
        {
            return this.contexto.AddEndereco(instancia);
        }        

        public override Endereco Read(int chave)
        {
            return this.contexto.Enderecos.SingleOrDefault(usr => usr.Id == chave);
        }

        public override List<Endereco> Read()
        {
            return this.contexto.Enderecos;
        }

        public override Endereco Update(Endereco instancia)
        {
            Endereco atu = this.Read(instancia.Id);
            if (atu == null)
            {
                return null;
            }
            else
            {
                atu.Logradouro = instancia.Logradouro;
                atu.Numero = instancia.Numero;
                atu.Complemento = instancia.Complemento;
                atu.Bairro = instancia.Bairro;
                atu.Cep = instancia.Cep;
                atu.Cidade = instancia.Cidade;
                atu.Uf = instancia.Uf;
                return atu;
            }
        }
        public override Endereco Delete(int chave)
        {
            Endereco del = this.Read(chave);
            if (this.contexto.Enderecos.Remove(del) == false)
            {
                return null;
            }
            else
            {
                return del;
            }
        }

        public override Endereco Delete(Endereco instancia)
        {
            return this.Delete(instancia.Id);
        }
    }
}
