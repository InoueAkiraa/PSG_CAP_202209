using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using Atacado.Repositorio.Base;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Atacado.Servico.Base
{
    public class GenericService<TDominio, TPoco>
        : IGenericService<TDominio,TPoco>
        where TDominio : class
        where TPoco : class
    {

        protected GenericRepository<TDominio> genrepo;

        public GenericService()
        {
            this.genrepo = new GenericRepository<TDominio>();
        }
        public List<TPoco> Listar()
        {
            return this.Consultar(null);
        }

        public virtual List<TPoco> Consultar(Expression<Func<TDominio, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public TPoco PesquisarPorChave(object chave)
        {
            TDominio lida = this.genrepo.GetById(chave);
            TPoco lidaPoco = this.ConverterPara(lida);
            return lidaPoco;
        }

        public TPoco Inserir(TPoco poco)
        {
            TDominio nova = this.ConverterPara(poco);          
            TDominio criada = this.genrepo.Insert(nova);
            TPoco criadaPoco = this.ConverterPara(criada);
            return criadaPoco;
        }

        public TPoco Alterar(TPoco poco)
        {
            TDominio editada = this.ConverterPara(poco);
            TDominio alterada = this.genrepo.Update(editada);
            TPoco alteradaPoco = this.ConverterPara(alterada);
            return alteradaPoco;
        }

        public TPoco Excluir(object chave)
        {
            TDominio del = this.genrepo.Delete(chave);
            TPoco delPoco = this.ConverterPara(del);
            return delPoco;
        }

        public virtual TDominio ConverterPara(TPoco poco)
        {
            throw new NotImplementedException();
        }

        public virtual TPoco ConverterPara(TDominio dominio)
        {
            throw new NotImplementedException();
        }
    }
}
