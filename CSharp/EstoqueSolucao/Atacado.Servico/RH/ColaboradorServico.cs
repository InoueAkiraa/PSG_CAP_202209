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
    public class ColaboradorServico : BaseServico<ColaboradorPoco, Colaborador>
    {
        private ColaboradorRepo repo;

        public ColaboradorServico()
        {
            this.repo = new ColaboradorRepo();
        }

        public override ColaboradorPoco Add(ColaboradorPoco poco)
        {
            Colaborador nova = this.ConvertTo(poco);
            Colaborador criada = this.repo.Create(nova);
            return this.ConvertTo(criada);
        }

        public override List<ColaboradorPoco> Browse()
        {
            List<ColaboradorPoco> listaPoco = this.repo.Read()
                .Select(col =>
                    new ColaboradorPoco()
                    {
                        Id = col.Id,
                        Nome = col.Nome,
                        Cpf = col.Cpf,
                        Rg = col.Rg,
                        Genero = col.Genero,
                        Nasc = col.Nasc,
                        EmailPessoal = col.EmailPessoal,
                        Ctps = col.Ctps,
                        Pis = col.Pis,
                        TituloEleitor = col.TituloEleitor,
                        Reservista = col.Reservista,
                        EstadoCivil = col.EstadoCivil,
                        NumDependentes = col.NumDependentes,
                        Ativo = col.Ativo,
                        Setor = col.Setor,
                        Cargo = col.Cargo,
                        Salario = col.Salario,
                        Telefone1 = col.Telefone1,
                        Telefone2 = col.Telefone2
                    }
                )
                .ToList();
            return listaPoco;
        }

        public override ColaboradorPoco ConvertTo(Colaborador dominio)
        {
            return new ColaboradorPoco()
            {
                Id = dominio.Id,
                Nome = dominio.Nome,
                Cpf = dominio.Cpf,
                Rg = dominio.Rg,
                Genero = dominio.Genero,
                Nasc = dominio.Nasc,
                EmailPessoal = dominio.EmailPessoal,
                Ctps = dominio.Ctps,
                Pis = dominio.Pis,
                TituloEleitor = dominio.TituloEleitor,
                Reservista = dominio.Reservista,
                EstadoCivil = dominio.EstadoCivil,
                NumDependentes = dominio.NumDependentes,
                Ativo = dominio.Ativo,
                Setor = dominio.Setor,
                Cargo = dominio.Cargo,
                Salario = dominio.Salario,
                Telefone1 = dominio.Telefone1,
                Telefone2 = dominio.Telefone2
            };
        }

        public override Colaborador ConvertTo(ColaboradorPoco poco)
        {
            return new Colaborador(poco.Id, poco.Nome, poco.Cpf, poco.Rg, poco.Genero, poco.Nasc, poco.EmailPessoal,
                poco.Ctps, poco.Pis, poco.TituloEleitor, poco.Reservista, poco.EstadoCivil, poco.NumDependentes, 
                poco.Ativo, poco.Setor, poco.Cargo, poco.Salario, poco.Telefone1, poco.Telefone2);
        }

        public override ColaboradorPoco Delete(int chave)
        {
            Colaborador del = this.repo.Delete(chave);
            ColaboradorPoco delPoco = this.ConvertTo(del);
            return delPoco;
        }

        public override ColaboradorPoco Delete(ColaboradorPoco poco)
        {
            Colaborador del = this.repo.Delete(poco.Id);
            ColaboradorPoco delPoco = this.ConvertTo(del);
            return delPoco;
        }

        public override ColaboradorPoco Edit(ColaboradorPoco poco)
        {
            Colaborador editada = this.ConvertTo(poco);
            Colaborador alterada = this.repo.Update(editada);
            ColaboradorPoco alteradaPoco = this.ConvertTo(alterada);
            return alteradaPoco;
        }

        public override ColaboradorPoco Read(int chave)
        {
            Colaborador lida = this.repo.Read(chave);
            ColaboradorPoco lidaPoco = this.ConvertTo(lida);
            return lidaPoco;
        }
    }
}
