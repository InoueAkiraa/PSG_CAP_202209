using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Servico.Base
{
    public interface IGenericService<TDominio, TPoco> 
        where TDominio : class
        where TPoco : class
    {
        List<TPoco> Listar();

        List<TPoco> Consultar(Expression<Func<TDominio, bool>> predicate = null);

        TPoco PesquisarPorChave(object chave);

        TPoco Inserir(TPoco poco);

        TPoco Alterar(TPoco poco);

        TPoco Excluir(object chave);

        TDominio ConverterPara(TPoco poco);

        TPoco ConverterPara(TDominio dominio);
    }
}
