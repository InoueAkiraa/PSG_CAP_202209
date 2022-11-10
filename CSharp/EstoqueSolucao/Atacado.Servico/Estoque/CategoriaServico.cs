﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Atacado.Servico.Base;
using Atacado.DB.EF.Database;
using Atacado.Poco.Estoque;
using Atacado.Repositorio.Estoque;
using Atacado.Repositorio.Base;
using System.Linq.Expressions;

namespace Atacado.Servico.Estoque
{
    public class CategoriaServico : GenericService<Categoria, CategoriaPoco>
    {
        public override CategoriaPoco ConverterPara(Categoria dominio)
        {
            return new CategoriaPoco()
            {
                Codigo = dominio.Codigo,
                Descricao = dominio.Descricao,
                Ativo = dominio.Ativo,
                DataInsert = dominio.DataInsert
            };
        }

        public override Categoria ConverterPara(CategoriaPoco poco)
        {
            return new Categoria()
            {
                Codigo = poco.Codigo,
                Descricao = poco.Descricao,
                Ativo = poco.Ativo,
                DataInsert = poco.DataInsert
            };
        }

        public override List<CategoriaPoco> Consultar(Expression<Func<Categoria, bool>>? predicate = null)
        {
            IQueryable<Categoria> query;
            if (predicate == null)
            {
                query = this.genrepo.Browseable(null);
            }
            else
            {
                query = this.genrepo.Browseable(predicate);
            }

            List<CategoriaPoco> listaPoco = query.Select(cat =>
                    new CategoriaPoco()
                    {
                        Codigo = cat.Codigo,
                        Descricao = cat.Descricao,
                        Ativo = cat.Ativo,
                        DataInsert = cat.DataInsert
                    }
                )
                .ToList();
            return listaPoco;
        }
    }
}
