using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Repositorio.Base
{
    public abstract class BaseRepositorio<TClasse> where TClasse : class
    {
        public abstract TClasse Create(TClasse instancia);

        public abstract TClasse Read(int chave);

        public abstract List<TClasse> Read();

        public abstract TClasse Update(TClasse instancia);

        public abstract TClasse Delete(int chave);

        public abstract TClasse Delete(TClasse instancia);
    }
}
