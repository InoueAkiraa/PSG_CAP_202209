using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Atacado.Servico.Base;
using Atacado.Dominio.RH;
using Atacado.Poco.RH;
using Atacado.Repositorio.RH;

namespace Atacado.Servico.RH
{
    public class UsuarioServico : BaseServico<UsuarioPoco, Usuario>
    {
        private UsuarioRepo repo;

        public UsuarioServico()
        {
            this.repo = new UsuarioRepo();
        }

        public override UsuarioPoco Add(UsuarioPoco poco)
        {
            Usuario nova = this.ConvertTo(poco);
            Usuario criada = this.repo.Create(nova);
            return this.ConvertTo(criada);
        }

        public override List<UsuarioPoco> Browse()
        {
            List<UsuarioPoco> listaPoco = this.repo.Read()
                .Select(usr =>
                    new UsuarioPoco()
                    {
                        Codigo = usr.Codigo,
                        Login = usr.Login,
                        Senha = usr.Senha,
                        Permissao = usr.Permissao
                    }
                )
                .ToList();
            return listaPoco;
        }

        public override UsuarioPoco ConvertTo(Usuario dominio)
        {
            return new UsuarioPoco()
            {
                Codigo = dominio.Codigo,
                Login = dominio.Login,
                Senha = dominio.Senha,
                Permissao = dominio.Permissao
            };
        }

        public override Usuario ConvertTo(UsuarioPoco poco)
        {
            return new Usuario(poco.Codigo, poco.Login, poco.Senha, poco.Permissao);
        }

        public override UsuarioPoco Delete(int chave)
        {
            Usuario del = this.repo.Delete(chave);
            UsuarioPoco delPoco = this.ConvertTo(del);
            return delPoco;
        }

        public override UsuarioPoco Delete(UsuarioPoco poco)
        {
            Usuario del = this.repo.Delete(poco.Codigo);
            UsuarioPoco delPoco = this.ConvertTo(del);
            return delPoco;
        }

        public override UsuarioPoco Edit(UsuarioPoco poco)
        {
            Usuario editada = this.ConvertTo(poco);
            Usuario alterada = this.repo.Update(editada);
            UsuarioPoco alteradaPoco = this.ConvertTo(alterada);
            return alteradaPoco;
        }

        public override UsuarioPoco Read(int chave)
        {
            Usuario lida = this.repo.Read(chave);
            UsuarioPoco lidaPoco = this.ConvertTo(lida);
            return lidaPoco;
        }
    }
}
