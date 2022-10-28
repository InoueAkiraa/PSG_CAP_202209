using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Atacado.Servico.Base;
using Atacado.Dominio.AtacadoFrota;
using Atacado.Poco.AtacadoFrota;
using Atacado.Repositorio.AtacadoFrota;
using Atacado.Repositorio.Base;

namespace Atacado.Servico.AtacadoFrota
{
    public class FrotaServico : BaseServico<FrotaPoco, Frota>
    {
        private FrotaRepo repo;

        public FrotaServico()
        {
            this.repo = new FrotaRepo();
        }

        public override FrotaPoco Add(FrotaPoco poco)
        {
            Frota nova = this.ConvertTo(poco);
            Frota criada = this.repo.Create(nova);
            return this.ConvertTo(criada);
        }

        public override List<FrotaPoco> Browse()
        {
            List<FrotaPoco> listaPoco = this.repo.Read()
                .Select(fro =>
                    new FrotaPoco()
                    {
                        Ativo = fro.Ativo,
                        Codigo = fro.Codigo,
                        DataInclusao = fro.DataInclusao,
                        Finalidade = fro.Finalidade,
                        Veiculos = fro.Veiculos
                    }
                )
                .ToList();
            return listaPoco;
        }

        public override FrotaPoco ConvertTo(Frota dominio)
        {
            return new FrotaPoco()
            {
                Ativo = dominio.Ativo,
                Codigo = dominio.Codigo,
                DataInclusao = dominio.DataInclusao,
                Finalidade = dominio.Finalidade,
                Veiculos = dominio.Veiculos
            };
        }

        public override Frota ConvertTo(FrotaPoco poco)
        {
            return new Frota(poco.Ativo, poco.Codigo, poco.DataInclusao, poco.Finalidade, poco.Veiculos);
        }

        public override FrotaPoco Delete(int chave)
        {
            Frota del = this.repo.Delete(chave);
            FrotaPoco delPoco = this.ConvertTo(del);
            return delPoco;
        }

        public override FrotaPoco Delete(FrotaPoco poco)
        {
            Frota del = this.repo.Delete(poco.Codigo);
            FrotaPoco delPoco = this.ConvertTo(del);
            return delPoco;
        }

        public override FrotaPoco Edit(FrotaPoco poco)
        {
            Frota editada = this.ConvertTo(poco);
            Frota alterada = this.repo.Update(editada);
            FrotaPoco alteradaPoco = this.ConvertTo(alterada);
            return alteradaPoco;
        }

        public override FrotaPoco Read(int chave)
        {
            Frota lida = this.repo.Read(chave);
            FrotaPoco lidaPoco = this.ConvertTo(lida);
            return lidaPoco;
        }
    }
}
