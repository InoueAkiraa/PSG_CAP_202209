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
    public class CaminhaoServico : BaseServico<CaminhaoPoco, Caminhao>
    {
        private CaminhaoRepo repo;

        public CaminhaoServico()
        {
            this.repo = new CaminhaoRepo();
        }

        public override CaminhaoPoco Add(CaminhaoPoco poco)
        {
            Caminhao novo = this.ConvertTo(poco);
            Caminhao criada = this.repo.Create(novo);
            return this.ConvertTo(criada);
        }

        public override List<CaminhaoPoco> Browse()
        {
            List<CaminhaoPoco> listaPoco = this.repo.Read()
                .Select(cam =>
                    new CaminhaoPoco()
                    {
                        Ativo = cam.Ativo,
                        Codigo = cam.Codigo,
                        DataInclusao = cam.DataInclusao,
                        Chassi = cam.Chassi,
                        Cor = cam.Cor,
                        Marca = cam.Marca,
                        Modelo = cam.Modelo,
                        Placa = cam.Placa,
                        PesoBruto = cam.PesoBruto,
                        PesoLiquido = cam.PesoLiquido,
                        PesoTotal = cam.PesoTotal
                    }
                )
                .ToList();
            return listaPoco;
        }

        public override CaminhaoPoco ConvertTo(Caminhao dominio)
        {
            return new CaminhaoPoco()
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

        public override Caminhao ConvertTo(CaminhaoPoco poco)
        {
            return new Caminhao(poco.Ativo, poco.Codigo, poco.DataInclusao, poco.Chassi, poco.Cor, poco.Marca,
                poco.Modelo, poco.Placa, poco.PesoBruto, poco.PesoLiquido, poco.PesoTotal);
        }

        public override CaminhaoPoco Delete(int chave)
        {
            Caminhao del = this.repo.Delete(chave);
            CaminhaoPoco delPoco = this.ConvertTo(del);
            return delPoco;
        }

        public override CaminhaoPoco Delete(CaminhaoPoco poco)
        {
            Caminhao del = this.repo.Delete(poco.Codigo);
            CaminhaoPoco delPoco = this.ConvertTo(del);
            return delPoco;
        }

        public override CaminhaoPoco Edit(CaminhaoPoco poco)
        {
            Caminhao editada = this.ConvertTo(poco);
            Caminhao alterada = this.repo.Update(editada);
            CaminhaoPoco alteradaPoco = this.ConvertTo(alterada);
            return alteradaPoco;
        }

        public override CaminhaoPoco Read(int chave)
        {
            Caminhao lida = this.repo.Read(chave);
            CaminhaoPoco lidaPoco = this.ConvertTo(lida);
            return lidaPoco;
        }
    }
}
