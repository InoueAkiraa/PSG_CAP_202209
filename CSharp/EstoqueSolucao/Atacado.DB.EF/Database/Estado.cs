using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Atacado.DB.EF.Database
{
    [Table("Estado", Schema = "Geral")]
    public partial class Estado
    {
        public Estado()
        {
            Municipios = new HashSet<Municipio>();
        }

        [Key]
        [Column("CodigoUF")]
        public int CodigoUf { get; set; }
        [Column("SiglaUF")]
        [StringLength(2)]
        [Unicode(false)]
        public string SiglaUf { get; set; } = null!;
        [Column("DescricaoUF")]
        [StringLength(255)]
        [Unicode(false)]
        public string? DescricaoUf { get; set; }

        [InverseProperty("CodigoUfNavigation")]
        public virtual ICollection<Municipio> Municipios { get; set; }
    }
}
