using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Clinica.Dominio.EF
{
    [Table("Servico", Schema = "dbo")]
    public partial class Servico
    {
        [Key]
        [Column(name: "CodigoServico")]
        public int CodigoServico { get; set; }

        [Column(name: "Descricao")]
        [Unicode(false)]
        public string Descricao { get; set; } = null!;

        [Column(name: "Preco", TypeName = "decimal")]
        public double Preco { get; set; }

        [Column(name: "MaterialUsado")]
        [Unicode(false)]
        public string? MaterialUsado { get; set; }

        [Column(name: "DenteTratado")]
        public int? DenteTratado { get; set; }

        [Column(name: "MedidaPreventiva")]
        [Unicode(false)]
        public string? MedidaPreventiva { get; set; }

        [Column(name: "TipoExame")]
        [Unicode(false)]
        public string? TipoExame { get; set; }

        [Column(name: "TipoServico")]
        [Unicode(false)]
        [StringLength(2)]
        public string TipoServico { get; set; } = null!;

        [Column(name: "Situacao", TypeName = "bit")]
        public bool? Situacao { get; set; }

        [Column(name: "DataInclusao", TypeName = "datetime")]
        public DateTime? DataInclusao { get; set; }

        [Column(name: "DataAlteracao", TypeName = "datetime")]
        public DateTime? DataAlteracao { get; set; }

        [Column(name: "DenteExtraido")]
        public int? DenteExtraido { get; set; }

        [Column(name: "DenteCanalPar")]
        public int? DenteCanalPar { get; set; }

        [Column(name: "CodigoTipoServico")]
        public int? CodigoTipoServico { get; set; }
    }
}
