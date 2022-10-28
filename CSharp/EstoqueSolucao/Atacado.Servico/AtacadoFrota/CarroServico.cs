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
    public class CarroServico : BaseServico<CarroPoco, Carro>
    {
        private CarroRepo repo;

        public CarroServico()
        {
            this.repo = new CarroRepo();
        }

        public override CarroPoco Add(CarroPoco poco)
        {
            Carro novo = this.ConvertTo(poco);
            Carro criada = this.repo.Create(novo);
            return this.ConvertTo(criada);
        }

        public override List<CarroPoco> Browse()
        {
            List<CarroPoco> listaPoco = this.repo.Read()
                .Select(cam =>
                    new CarroPoco()
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
                        PesoTotal = cam.PesoTotal,
                        NumPassageiros = cam.NumPassageiros
                    }
                )
                .ToList();
            return listaPoco;
        }

        public override CarroPoco ConvertTo(Carro dominio)
        {
            return new CarroPoco()
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
                PesoTotal = dominio.PesoTotal,
                NumPassageiros = dominio.NumPassageiros
            };
        }

        public override Carro ConvertTo(CarroPoco poco)
        {
            return new Carro(poco.Ativo, poco.Codigo, poco.DataInclusao, poco.Chassi, poco.Cor, poco.Marca, poco.Modelo,
                poco.Placa, poco.PesoBruto, poco.PesoLiquido, poco.PesoTotal, poco.NumPassageiros);
        }

        public override CarroPoco Delete(int chave)
        {
            Carro del = this.repo.Delete(chave);
            CarroPoco delPoco = this.ConvertTo(del);
            return delPoco;
        }

        public override CarroPoco Delete(CarroPoco poco)
        {
            Carro del = this.repo.Delete(poco.Codigo);
            CarroPoco delPoco = this.ConvertTo(del);
            return delPoco;
        }

        public override CarroPoco Edit(CarroPoco poco)
        {
            Carro editada = this.ConvertTo(poco);
            Carro alterada = this.repo.Update(editada);
            CarroPoco alteradaPoco = this.ConvertTo(alterada);
            return alteradaPoco;
        }

        public override CarroPoco Read(int chave)
        {
            Carro lida = this.repo.Read(chave);
            CarroPoco lidaPoco = this.ConvertTo(lida);
            return lidaPoco;
        }
    }
}
