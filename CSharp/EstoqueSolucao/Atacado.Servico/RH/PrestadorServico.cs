using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Atacado.Servico.Base;
using Atacado.Dominio.RH;
using Atacado.Poco.RH;
using Atacado.Repositorio.RH;

namespace Atacado.Servico.RH
{
    public class PrestadorServico : BaseServico<PrestadorPoco, Prestador>
    {
        private PrestadorRepo repo;

        public PrestadorServico()
        {
            this.repo = new PrestadorRepo();
        }

        public override PrestadorPoco Add(PrestadorPoco poco)
        {
            Prestador nova = this.ConvertTo(poco);
            Prestador criada = this.repo.Create(nova);
            return this.ConvertTo(criada);
        }

        public override List<PrestadorPoco> Browse()
        {
            List<PrestadorPoco> listaPoco = this.repo.Read()
                .Select(pre =>
                    new PrestadorPoco()
                    {
                        Id = pre.Id,
                        Cnpj = pre.Cnpj,
                        InscricaoEstadual = pre.InscricaoEstadual,
                        Fundacao = pre.Fundacao,
                        NomeFantasia = pre.NomeFantasia,
                        RazaoSocial = pre.RazaoSocial,
                        EmailCorporativo = pre.EmailCorporativo,
                        DataContratoInicial = pre.DataContratoInicial,
                        DataContratoFinal = pre.DataContratoFinal
                    }
                )
                .ToList();
            return listaPoco;
        }

        public override PrestadorPoco ConvertTo(Prestador dominio)
        {
            return new PrestadorPoco()
            {
                Id = dominio.Id,
                Cnpj = dominio.Cnpj,
                InscricaoEstadual = dominio.InscricaoEstadual,
                Fundacao = dominio.Fundacao,
                NomeFantasia = dominio.NomeFantasia,
                RazaoSocial = dominio.RazaoSocial,
                EmailCorporativo = dominio.EmailCorporativo,
                DataContratoInicial = dominio.DataContratoInicial,
                DataContratoFinal = dominio.DataContratoFinal
            };
        }

        public override Prestador ConvertTo(PrestadorPoco poco)
        {
            return new Prestador(poco.Id, poco.Cnpj, poco.InscricaoEstadual, poco.Fundacao, poco.NomeFantasia,
                poco.RazaoSocial, poco.EmailCorporativo, poco.DataContratoInicial, poco.DataContratoFinal);
        }

        public override PrestadorPoco Delete(int chave)
        {
            Prestador del = this.repo.Delete(chave);
            PrestadorPoco delPoco = this.ConvertTo(del);
            return delPoco;
        }

        public override PrestadorPoco Delete(PrestadorPoco poco)
        {
            Prestador del = this.repo.Delete(poco.Id);
            PrestadorPoco delPoco = this.ConvertTo(del);
            return delPoco;
        }

        public override PrestadorPoco Edit(PrestadorPoco poco)
        {
            Prestador editada = this.ConvertTo(poco);
            Prestador alterada = this.repo.Update(editada);
            PrestadorPoco alteradaPoco = this.ConvertTo(alterada);
            return alteradaPoco;
        }

        public override PrestadorPoco Read(int chave)
        {
            Prestador lida = this.repo.Read(chave);
            PrestadorPoco lidaPoco = this.ConvertTo(lida);
            return lidaPoco;
        }
    }
}
