using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Atacado.Servico.Base;
using Atacado.DB.EF.Database;
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
                        CodigoCategoria = pro.CodigoCategoria,
                        CodigoSubcategoria = pro.CodigoSubcategoria,
                        Descricao = pro.Descricao,
                        Ativo = pro.Ativo,
                        DataInsert = pro.DataInsert                        
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
                CodigoCategoria = dominio.CodigoCategoria,
                CodigoSubcategoria = dominio.CodigoSubcategoria,
                Descricao = dominio.Descricao,
                Ativo = dominio.Ativo,
                DataInsert = dominio.DataInsert                
            };
        }

        public override Produto ConvertTo(ProdutoPoco poco)
        {
            return new Produto()
            {
                Codigo = poco.Codigo,
                CodigoCategoria = poco.CodigoCategoria,
                CodigoSubcategoria = poco.CodigoSubcategoria,
                Descricao = poco.Descricao,
                Ativo = poco.Ativo,
                DataInsert = poco.DataInsert
            };
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
