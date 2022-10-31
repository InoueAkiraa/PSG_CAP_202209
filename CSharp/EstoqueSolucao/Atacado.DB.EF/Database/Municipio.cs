using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Atacado.DB.EF.Database
{
    [Table("Municipio", Schema = "Geral")]
    public partial class Municipio
    {
        [Key]
        public int CodigoMunicipio { get; set; }
        [Unicode(false)]
        public string NomeMunicipio { get; set; } = null!;
        [Column("CodigoIBGE6")]
        public int CodigoIbge6 { get; set; }
        [Column("CodigoIBGE7")]
        public int CodigoIbge7 { get; set; }
        [Column("CEP")]
        public int Cep { get; set; }
        [Column("CodigoUF")]
        public int CodigoUf { get; set; }
        [Column("SiglaUF")]
        [StringLength(2)]
        [Unicode(false)]
        public string SiglaUf { get; set; } = null!;
        [StringLength(255)]
        [Unicode(false)]
        public string Regiao { get; set; } = null!;
        public int? Populacao { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? Porte { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataInclusao { get; set; }

        [ForeignKey("CodigoUf")]
        [InverseProperty("Municipios")]
        public virtual Estado CodigoUfNavigation { get; set; } = null!;
    }
}
