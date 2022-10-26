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
    public class CategoriaServico : BaseServico<CategoriaPoco, Categoria>
    {
        private CategoriaRepo repo;

        public CategoriaServico() : base()
        {
            this.repo = new CategoriaRepo();
        }
        public override CategoriaPoco Add(CategoriaPoco poco)
        {
            Categoria nova = this.ConvertTo(poco);
            Categoria criada = this.repo.Create(nova);
            return this.ConvertTo(criada);
        }

        public override List<CategoriaPoco> Browse()
        {
            List<Categoria> lista = this.repo.Read();
            List<CategoriaPoco> listaPoco = new List<CategoriaPoco>();

            foreach (Categoria item in lista)
            {
                CategoriaPoco poco = this.ConvertTo(item);
                listaPoco.Add(poco);
            }
            return listaPoco;
        }

        public override CategoriaPoco ConvertTo(Categoria dominio)
        {
            return new CategoriaPoco(dominio.Codigo, dominio.Descricao, dominio.Ativo, dominio.DataInclusao);
        }

        public override Categoria ConvertTo(CategoriaPoco poco)
        {
            return new Categoria(poco.Codigo, poco.Descricao, poco.Ativo, poco.DataInclusao);
        }

        public override CategoriaPoco Delete(int chave)
        {
            Categoria del = this.repo.Delete(chave);
            CategoriaPoco delPoco = this.ConvertTo(del);
            return delPoco;
        }

        public override CategoriaPoco Delete(CategoriaPoco poco)
        {
            Categoria del = this.repo.Delete(poco.Codigo);
            CategoriaPoco delPoco = this.ConvertTo(del);
            return delPoco;
        }

        public override CategoriaPoco Edit(CategoriaPoco poco)
        {
            Categoria editada = this.ConvertTo(poco);
            Categoria alterada = this.repo.Update(editada);
            CategoriaPoco alteradaPoco = this.ConvertTo(alterada);
            return alteradaPoco;
        }

        public override CategoriaPoco Read(int chave)
        {
            Categoria lida = this.repo.Read(chave);
            CategoriaPoco lidaPoco = this.ConvertTo(lida);
            return lidaPoco;
        }
    }
}
