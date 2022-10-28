using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Dominio.AtacadoFrota
{
    public class Frota : BaseCampos
    {
        private string finalidade;
        private int veiculos;        

        public string Finalidade { get => finalidade; set => finalidade = value; }
        public int Veiculos { get => veiculos; set => veiculos = value; }

        public Frota() : base()
        { }

        public Frota(bool ativo, int codigo, DateTime dataInclusao, string finalidade, int veiculos) : 
            base(ativo, codigo, dataInclusao)
        {
            this.finalidade = finalidade;
            this.veiculos = veiculos;
        }
    }
}
