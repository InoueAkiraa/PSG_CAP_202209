﻿using System;
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
    public class SubcategoriaServico : BaseServico<SubcategoriaPoco, Subcategoria>
    {
        private SubcategoriaRepo repo;

        public SubcategoriaServico()
        {
            this.repo = new SubcategoriaRepo();
        }

        public override SubcategoriaPoco Add(SubcategoriaPoco poco)
        {
            Subcategoria nova = this.ConvertTo(poco);
            Subcategoria criada = this.repo.Create(nova);
            return this.ConvertTo(criada);
        }

        public override List<SubcategoriaPoco> Browse()
        {
            List<SubcategoriaPoco> listaPoco = this.repo.Read()
                .Select(sub =>
                    new SubcategoriaPoco()
                    {
                        Codigo = sub.Codigo,
                        Descricao = sub.Descricao,
                        Ativo = sub.Ativo,
                        DataInclusao = sub.DataInclusao,
                        CodigoCategoria = sub.CodigoCategoria
                    }
                )
                .ToList();
            return listaPoco;
        }

        public override SubcategoriaPoco ConvertTo(Subcategoria dominio)
        {
            return new SubcategoriaPoco()
            {
                Codigo = dominio.Codigo, 
                Descricao = dominio.Descricao, 
                Ativo = dominio.Ativo, 
                DataInclusao = dominio.DataInclusao, 
                CodigoCategoria = dominio.CodigoCategoria
            };
        }

        public override Subcategoria ConvertTo(SubcategoriaPoco poco)
        {
            return new Subcategoria(poco.Codigo, poco.Descricao, poco.Ativo, poco.DataInclusao, poco.CodigoCategoria);
        }

        public override SubcategoriaPoco Delete(int chave)
        {
            Subcategoria del = this.repo.Delete(chave);
            SubcategoriaPoco delPoco = this.ConvertTo(del);
            return delPoco;
        }

        public override SubcategoriaPoco Delete(SubcategoriaPoco poco)
        {
            Subcategoria del = this.repo.Delete(poco.Codigo);
            SubcategoriaPoco delPoco = this.ConvertTo(del);
            return delPoco;
        }

        public override SubcategoriaPoco Edit(SubcategoriaPoco poco)
        {
            Subcategoria editada = this.ConvertTo(poco);
            Subcategoria alterada = this.repo.Update(editada);
            SubcategoriaPoco alteradaPoco = this.ConvertTo(alterada);
            return alteradaPoco;
        }

        public override SubcategoriaPoco Read(int chave)
        {
            Subcategoria lida = this.repo.Read(chave);
            SubcategoriaPoco lidaPoco = this.ConvertTo(lida);
            return lidaPoco;
        }
    }
}
