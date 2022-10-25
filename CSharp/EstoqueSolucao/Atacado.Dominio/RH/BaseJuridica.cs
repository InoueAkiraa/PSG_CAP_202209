using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Dominio.RH
{
    public abstract class BaseJuridica : BasePessoa
    {
        protected string cnpj;
        protected string inscricaoEstadual;
        protected DateTime fundacao;
        protected string nomeFantasia;
        protected string razaoSocial;
        protected string emailCorporativo;

        public string Cnpj { get => cnpj; set => cnpj = value; }
        public string InscricaoEstaduao { get => inscricaoEstadual; set => inscricaoEstadual = value; }
        public DateTime Fundacao { get => fundacao; set => fundacao = value; }
        public string NomeFantasia { get => nomeFantasia; set => nomeFantasia = value; }
        public string RazaoSocial { get => razaoSocial; set => razaoSocial = value; }
        public string EmailCorporativo { get => emailCorporativo; set => emailCorporativo = value; }

        public BaseJuridica() : base()
        {
        }

        public BaseJuridica(int id, string cnpj, string inscricaoEstaduao, DateTime fundacao, string nomeFantasia, string razaoSocial, string emailCorporativo) 
            : base(id)
        {
            this.cnpj = cnpj;
            this.inscricaoEstadual = inscricaoEstaduao;
            this.fundacao = fundacao;
            this.nomeFantasia = nomeFantasia;
            this.razaoSocial = razaoSocial;
            this.emailCorporativo = emailCorporativo;
        }
    }
}
