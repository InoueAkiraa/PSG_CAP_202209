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
    public class ParceiroServico : BaseServico<ParceiroPoco, Parceiro>
    {
        private ParceiroRepo repo;

        public ParceiroServico()
        {
            this.repo = new ParceiroRepo();
        }

        public override ParceiroPoco Add(ParceiroPoco poco)
        {
            Parceiro nova = this.ConvertTo(poco);
            Parceiro criada = this.repo.Create(nova);
            return this.ConvertTo(criada);
        }

        public override List<ParceiroPoco> Browse()
        {
            List<ParceiroPoco> listaPoco = this.repo.Read()
                .Select(par =>
                    new ParceiroPoco()
                    {
                        Id = par.Id,
                        Cnpj = par.Cnpj,
                        InscricaoEstadual = par.InscricaoEstadual,
                        Fundacao = par.Fundacao,
                        NomeFantasia = par.NomeFantasia,
                        RazaoSocial = par.RazaoSocial,
                        EmailCorporativo = par.EmailCorporativo,
                        Desempenho = par.Desempenho,
                        Comissao = par.Comissao,
                        Setor = par.Setor
                    }
                )
                .ToList();
            return listaPoco;
        }

        public override ParceiroPoco ConvertTo(Parceiro dominio)
        {
            return new ParceiroPoco()
            {
                Id = dominio.Id,
                Cnpj = dominio.Cnpj,
                InscricaoEstadual = dominio.InscricaoEstadual,
                Fundacao = dominio.Fundacao,
                NomeFantasia = dominio.NomeFantasia,
                RazaoSocial = dominio.RazaoSocial,
                EmailCorporativo = dominio.EmailCorporativo,
                Desempenho = dominio.Desempenho,
                Comissao = dominio.Comissao,
                Setor = dominio.Setor
            };
        }

        public override Parceiro ConvertTo(ParceiroPoco poco)
        {
            return new Parceiro(poco.Id, poco.Cnpj, poco.InscricaoEstadual, poco.Fundacao, poco.NomeFantasia,
                poco.RazaoSocial, poco.EmailCorporativo, poco.Desempenho, poco.Comissao, poco.Setor);
        }

        public override ParceiroPoco Delete(int chave)
        {
            Parceiro del = this.repo.Delete(chave);
            ParceiroPoco delPoco = this.ConvertTo(del);
            return delPoco;
        }

        public override ParceiroPoco Delete(ParceiroPoco poco)
        {
            Parceiro del = this.repo.Delete(poco.Id);
            ParceiroPoco delPoco = this.ConvertTo(del);
            return delPoco;
        }

        public override ParceiroPoco Edit(ParceiroPoco poco)
        {
            Parceiro editada = this.ConvertTo(poco);
            Parceiro alterada = this.repo.Update(editada);
            ParceiroPoco alteradaPoco = this.ConvertTo(alterada);
            return alteradaPoco;
        }

        public override ParceiroPoco Read(int chave)
        {
            Parceiro lida = this.repo.Read(chave);
            ParceiroPoco lidaPoco = this.ConvertTo(lida);
            return lidaPoco;
        }
    }
}
