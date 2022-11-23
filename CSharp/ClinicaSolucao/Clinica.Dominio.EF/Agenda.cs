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
    [Table("Agenda", Schema = "dbo")]
    public partial class Agenda
    {
        [Key]
        [Column(name: "CodigoAgenda")]
        public int CodigoAgenda { get; set; }

        [Column(name: "CodigoPaciente")]
        public int CodigoPaciente { get; set; }

        [Column(name: "CodigoConsulta")]
        public int CodigoConsulta { get; set; }

        [Column(name: "Ano")]
        public int Ano { get; set; }

        [Column(name: "Situacao")]
        public bool? Situacao { get; set; }

        [Column(name: "DataInclusao", TypeName = "datetime")]
        public DateTime? DataInclusao { get; set; }

        [Column(name: "DataAlteracao", TypeName = "datetime")]
        public DateTime? DataAlteracao { get; set; }
    }
}
