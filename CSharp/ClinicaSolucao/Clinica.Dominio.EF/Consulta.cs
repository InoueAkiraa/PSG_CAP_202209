using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Clinica.Dominio.EF
{
    [Table("Consulta", Schema = "dbo")]
    public partial class Consulta
    {
        [Key]
        [Column(name: "CodigoConsulta")]
        public int CodigoConsulta { get; set; }

        [Column(name: "Historico")]
        [Unicode(false)]
        public string Historico { get; set; } = null!;

        [Column(name: "Data", TypeName = "date")]
        public DateTime Data { get; set; }

        [Column(name: "Hora")] //, TypeName = "time"
        public DateTime Hora { get; set; }

        [Column(name: "DataHora", TypeName = "datetime")]
        public DateTime DataHora { get; set; }

        [Column(name: "Situacao")]
        public bool? Situacao { get; set; }

        [Column(name: "DataInclusao", TypeName = "datetime")]
        public DateTime? DataInclusao { get; set; }

        [Column(name: "DataAlteracao", TypeName = "datetime")]
        public DateTime? DataAlteracao { get; set; }
    }
}
