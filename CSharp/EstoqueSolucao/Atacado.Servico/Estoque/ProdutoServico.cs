using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Atacado.Servico.Base;
using Atacado.Dominio.Estoque;
using Atacado.Poco.Estoque;
using Atacado.Repositorio.Estoque;

namespace Atacado.Servico.Estoque
{
    public class ProdutoServico : BaseServico<ProdutoPoco, Produto>
    {
        private ProdutoRepo repo;

        public ProdutoServico()
        {
            this.repo = new ProdutoRepo();
        }

        public override ProdutoPoco Add(ProdutoPoco poco)
        {
            Produto nova = this.ConvertTo(poco);
            Produto criada = this.repo.Create(nova);
            return this.ConvertTo(criada);
        }

        public override List<ProdutoPoco> Browse()
        {
            List<ProdutoPoco> listaPoco = this.repo.Read()
                .Select(pro =>
                    new ProdutoPoco()
                    {
                        Codigo = pro.Codigo,
                        Descricao = pro.Descricao,
                        Ativo = pro.Ativo,
                        DataInclusao = pro.DataInclusao,
                        CodigoSubcategoria = pro.CodigoSubcategoria
                    }
                )
                .ToList();
            return listaPoco;
        }

        public override ProdutoPoco ConvertTo(Produto dominio)
        {
            return new ProdutoPoco()
            {
                Codigo = dominio.Codigo,
                Descricao = dominio.Descricao,
                Ativo = dominio.Ativo,
                DataInclusao = dominio.DataInclusao,
                CodigoSubcategoria = dominio.CodigoSubcategoria
            };
        }

        public override Produto ConvertTo(ProdutoPoco poco)
        {
            return new Produto(poco.Codigo, poco.Descricao, poco.Ativo, poco.DataInclusao, poco.CodigoSubcategoria);
        }

        public override ProdutoPoco Delete(int chave)
        {
            Produto del = this.repo.Delete(chave);
            ProdutoPoco delPoco = this.ConvertTo(del);
            return delPoco;
        }

        public override ProdutoPoco Delete(ProdutoPoco poco)
        {
            Produto del = this.repo.Delete(poco.Codigo);
            ProdutoPoco delPoco = this.ConvertTo(del);
            return delPoco;
        }

        public override ProdutoPoco Edit(ProdutoPoco poco)
        {
            Produto editada = this.ConvertTo(poco);
            Produto alterada = this.repo.Update(editada);
            ProdutoPoco alteradaPoco = this.ConvertTo(alterada);
            return alteradaPoco;
        }

        public override ProdutoPoco Read(int chave)
        {
            Produto lida = this.repo.Read(chave);
            ProdutoPoco lidaPoco = this.ConvertTo(lida);
            return lidaPoco;
        }
    }
}
