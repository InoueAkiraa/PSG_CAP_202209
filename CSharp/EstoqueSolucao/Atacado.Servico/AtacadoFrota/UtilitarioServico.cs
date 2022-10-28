using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Atacado.Servico.Base;
using Atacado.Dominio.AtacadoFrota;
using Atacado.Poco.AtacadoFrota;
using Atacado.Repositorio.AtacadoFrota;

namespace Atacado.Servico.AtacadoFrota
{
    public class UtilitarioServico : BaseServico<UtilitarioPoco, Utilitario>
    {
        private UtilitarioRepo repo;

        public UtilitarioServico()
        {
            this.repo = new UtilitarioRepo();
        }

        public override UtilitarioPoco Add(UtilitarioPoco poco)
        {
            Utilitario nova = this.ConvertTo(poco);
            Utilitario criada = this.repo.Create(nova);
            return this.ConvertTo(criada);
        }

        public override List<UtilitarioPoco> Browse()
        {
            List<UtilitarioPoco> listaPoco = this.repo.Read()
                .Select(uti =>
                    new UtilitarioPoco()
                    {
                        Ativo = uti.Ativo,
                        Codigo = uti.Codigo,
                        DataInclusao = uti.DataInclusao,
                        Chassi = uti.Chassi,
                        Cor = uti.Cor,
                        Marca = uti.Marca,
                        Modelo = uti.Modelo,
                        Placa = uti.Placa,
                        PesoBruto = uti.PesoBruto,
                        PesoLiquido = uti.PesoLiquido,
                        PesoTotal = uti.PesoTotal
                    }
                )
                .ToList();
            return listaPoco;
        }

        public override UtilitarioPoco ConvertTo(Utilitario dominio)
        {
            return new UtilitarioPoco()
            {
                Ativo = dominio.Ativo,
                Codigo = dominio.Codigo,
                DataInclusao = dominio.DataInclusao,
                Chassi = dominio.Chassi,
                Cor = dominio.Cor,
                Marca = dominio.Marca,
                Modelo = dominio.Modelo,
                Placa = dominio.Placa,
                PesoBruto = dominio.PesoBruto,
                PesoLiquido = dominio.PesoLiquido,
                PesoTotal = dominio.PesoTotal
            };
        }

        public override Utilitario ConvertTo(UtilitarioPoco poco)
        {
            return new Utilitario(poco.Ativo, poco.Codigo, poco.DataInclusao, poco.Chassi, poco.Cor, poco.Marca,
                poco.Modelo, poco.Placa, poco.PesoBruto, poco.PesoLiquido, poco.PesoTotal);
        }

        public override UtilitarioPoco Delete(int chave)
        {
            Utilitario del = this.repo.Delete(chave);
            UtilitarioPoco delPoco = this.ConvertTo(del);
            return delPoco;
        }

        public override UtilitarioPoco Delete(UtilitarioPoco poco)
        {
            Utilitario del = this.repo.Delete(poco.Codigo);
            UtilitarioPoco delPoco = this.ConvertTo(del);
            return delPoco;
        }

        public override UtilitarioPoco Edit(UtilitarioPoco poco)
        {
            Utilitario editada = this.ConvertTo(poco);
            Utilitario alterada = this.repo.Update(editada);
            UtilitarioPoco alteradaPoco = this.ConvertTo(alterada);
            return alteradaPoco;
        }

        public override UtilitarioPoco Read(int chave)
        {
            Utilitario lida = this.repo.Read(chave);
            UtilitarioPoco lidaPoco = this.ConvertTo(lida);
            return lidaPoco;
        }
    }
}
