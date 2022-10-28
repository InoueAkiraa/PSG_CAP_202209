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
    public class EnderecoServico : BaseServico<EnderecoPoco, Endereco>
    {
        private EnderecoRepo repo;

        public EnderecoServico()
        {
            this.repo = new EnderecoRepo();
        }

        public override EnderecoPoco Add(EnderecoPoco poco)
        {
            Endereco nova = this.ConvertTo(poco);
            Endereco criada = this.repo.Create(nova);
            return this.ConvertTo(criada);
        }

        public override List<EnderecoPoco> Browse()
        {
            List<EnderecoPoco> listaPoco = this.repo.Read()
                .Select(end =>
                    new EnderecoPoco()
                    {
                        Id = end.Id,
                        Logradouro = end.Logradouro,
                        Numero = end.Numero,
                        Complemento = end.Complemento,
                        Bairro = end.Bairro,
                        Cep = end.Cep,
                        Cidade = end.Cidade,
                        Uf = end.Uf
                    }
                )
                .ToList();
            return listaPoco;
        }

        public override EnderecoPoco ConvertTo(Endereco dominio)
        {
            return new EnderecoPoco()
            {
                Id = dominio.Id,
                Logradouro = dominio.Logradouro,
                Numero = dominio.Numero,
                Complemento = dominio.Complemento,
                Bairro = dominio.Bairro,
                Cep = dominio.Cep,
                Cidade = dominio.Cidade,
                Uf = dominio.Uf
            };
        }

        public override Endereco ConvertTo(EnderecoPoco poco)
        {
            return new Endereco(poco.Id, poco.Logradouro, poco.Numero, poco.Complemento, poco.Bairro, poco.Cep,
                poco.Cidade, poco.Uf);
        }

        public override EnderecoPoco Delete(int chave)
        {
            Endereco del = this.repo.Delete(chave);
            EnderecoPoco delPoco = this.ConvertTo(del);
            return delPoco;
        }

        public override EnderecoPoco Delete(EnderecoPoco poco)
        {
            Endereco del = this.repo.Delete(poco.Id);
            EnderecoPoco delPoco = this.ConvertTo(del);
            return delPoco;
        }

        public override EnderecoPoco Edit(EnderecoPoco poco)
        {
            Endereco editada = this.ConvertTo(poco);
            Endereco alterada = this.repo.Update(editada);
            EnderecoPoco alteradaPoco = this.ConvertTo(alterada);
            return alteradaPoco;
        }

        public override EnderecoPoco Read(int chave)
        {
            Endereco lida = this.repo.Read(chave);
            EnderecoPoco lidaPoco = this.ConvertTo(lida);
            return lidaPoco;
        }
    }
}
