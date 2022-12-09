using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using ViajeFacil.Dominio.EF;
using ViajeFacil.Poco.Viagem;
using ViajeFacil.Service.Base;

namespace ViajeFacil.Service.Viagem
{
    public class UsuarioService : GenericService<Usuario, UsuarioPoco>
    {
        public UsuarioService(ViajeFacilContexto contexto) : base(contexto) 
        { }

        public override List<UsuarioPoco> Consultar(Expression<Func<Usuario, bool>>? predicate = null)
        {
            IQueryable<Usuario> query;
            if (predicate == null)
            {
                query = this.genrepo.Browseable(null);
            }
            else
            {
                query = this.genrepo.Browseable(predicate);
            }
            return this.ConverterPara(query);
        }

        public override List<UsuarioPoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<Usuario> query;
            if (skip == null)
            {
                query = this.genrepo.GetAll();
            }
            else
            {
                query = this.genrepo.GetAll(take, skip);
            }
            return this.ConverterPara(query);
        }

        public override List<UsuarioPoco> ConverterPara(IQueryable<Usuario> query)
        {
            return query.Select(usu =>
                new UsuarioPoco()
            {
                CodigoUsuario = usu.CodigoUsuario,
                Nome = usu.Nome,
                Email = usu.Email,
                CPF = usu.CPF,
                Telefone = usu.Telefone,
                Login = usu.Login,
                Senha = usu.Senha,
                CodigoEndereco = usu.CodigoEndereco,
                CodigoTipoUsuario = usu.CodigoTipoUsuario,
                CodigoInstituicao = usu.CodigoInstituicao
            }).ToList();
        }
    }
}
