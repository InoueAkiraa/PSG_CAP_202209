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
    public class ColaboradorRepo : BaseRepositorio<Colaborador>
    {
        private RHContexto contexto;

        public ColaboradorRepo()
        {
            this.contexto = new RHContexto();
        }

        public override Colaborador Create(Colaborador instancia)
        {
            return this.contexto.AddColaborador(instancia);
        }        

        public override Colaborador Read(int chave)
        {
            return this.contexto.Colaboradores.SingleOrDefault(usr => usr.Id == chave);
        }

        public override List<Colaborador> Read()
        {
            return this.contexto.Colaboradores;
        }

        public override Colaborador Update(Colaborador instancia)
        {
            Colaborador atu = this.Read(instancia.Id);
            if (atu == null)
            {
                return null;
            }
            else
            {
                atu.Nome = instancia.Nome;
                atu.Cpf = instancia.Cpf;
                atu.Rg = instancia.Rg;
                atu.Genero = instancia.Genero;
                atu.Nasc = instancia.Nasc;
                atu.EmailPessoal = instancia.EmailPessoal;
                atu.Ctps = instancia.Ctps;
                atu.Pis = instancia.Pis;
                atu.TituloEleitor = instancia.TituloEleitor;
                atu.Reservista = instancia.Reservista;
                atu.EstadoCivil = instancia.EstadoCivil;
                atu.NumDependentes = instancia.NumDependentes;
                atu.Ativo = instancia.Ativo;
                atu.Setor = instancia.Setor;
                atu.Cargo = instancia.Cargo;
                atu.Salario = instancia.Salario;
                atu.Telefone1 = instancia.Telefone1;
                atu.Telefone2 = instancia.Telefone2;
                return atu;
            }
        }
        public override Colaborador Delete(int chave)
        {
            Colaborador del = this.Read(chave);
            if (this.contexto.Colaboradores.Remove(del) == false)
            {
                return null;
            }
            else
            {
                return del;
            }
        }

        public override Colaborador Delete(Colaborador instancia)
        {
            return this.Delete(instancia.Id);
        }
    }
}
