using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Repositorio.Base
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> Browseable(Expression<Func<T, bool>>? predicate = null); //REALIZA BUSCAS POR FILTROS

        IQueryable<T> GetAll(int? take = null, int? skip = null); //BUSCAS POR PAGINAÇÃO

        T? GetById(object id); //PESQUISA POR CHAVE

        T? Insert(T obj); //CRIAÇÃO DE REGISTRO

        T? Update(T obj);  //ALTERAÇÃO DE REGISTRO

        T? Delete(object id);  //EXCLUSÃO DE REGISTRO

        void Save();
    }
}
