using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Repositorio.Base
{
    public abstract class BaseRepositorio<TDominio> where TDominio : class
    {
        public abstract TDominio Create(TDominio instancia);

        public abstract TDominio Read(int chave);

        public abstract IQueryable<TDominio> Read(Expression<Func<TDominio, bool>> predicate = null);

        public abstract List<TDominio> Read();

        public abstract TDominio Update(TDominio instancia);

        public abstract TDominio Delete(int chave);

        public abstract TDominio Delete(TDominio instancia);
    }
}