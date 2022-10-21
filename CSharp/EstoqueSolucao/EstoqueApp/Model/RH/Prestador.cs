using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueApp.Model.RH
{
    public class Prestador : BaseJuridica
    {
        private DateOnly dataContratoInicial;
        private DateOnly dataContratoFinal;

        public DateOnly DataContratoInicial { get => dataContratoInicial; set => dataContratoInicial = value; }
        public DateOnly DataContratoFinal { get => dataContratoFinal; set => dataContratoFinal = value; }
        public Prestador() : base()
        {
        }

        public Prestador(int id, string cnpj, string inscricaoEstaduao, DateTime fundacao, string nomeFantasia, 
            string razaoSocial, string emailCorporativo, DateOnly dataContratoInicial, DateOnly dataContratoFinal) 
            : base(id, cnpj, inscricaoEstaduao, fundacao, nomeFantasia, razaoSocial, emailCorporativo)
        {
            this.dataContratoInicial = dataContratoInicial;
            this.dataContratoFinal = dataContratoFinal;
        }

        
    }
}
