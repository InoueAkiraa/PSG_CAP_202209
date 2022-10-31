using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Atacado.DB.EF.Database
{
    [Table("Produto", Schema = "EST")]
    public partial class Produto
    {
        [Key]
        public int Codigo { get; set; }
        public int CodigoSubcategoria { get; set; }
        public int CodigoCategoria { get; set; }
        [Unicode(false)]
        public string Descricao { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime DataInsert { get; set; }

        [ForeignKey("CodigoSubcategoria")]
        [InverseProperty("Produtos")]
        public virtual Subcategoria CodigoSubcategoriaNavigation { get; set; } = null!;
    }
}
