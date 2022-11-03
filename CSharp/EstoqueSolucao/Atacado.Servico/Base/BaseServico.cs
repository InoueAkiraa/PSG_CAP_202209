using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Servico.Base
{
    public abstract class BaseServico<TPoco, TDominio> 
        where TPoco : class
        where TDominio : class
    {
        public abstract List<TPoco> Browse();

        public abstract List<TPoco> Browse(Expression<Func<TDominio, bool>> predicate = null);

        public abstract TPoco Read(int chave);

        public abstract TPoco Edit(TPoco poco);

        public abstract TPoco Add(TPoco poco);

        public abstract TPoco Delete(int chave);

        public abstract TPoco Delete(TPoco poco);

        public abstract TPoco ConvertTo(TDominio dominio);

        public abstract TDominio ConvertTo(TPoco poco);
    }
}
