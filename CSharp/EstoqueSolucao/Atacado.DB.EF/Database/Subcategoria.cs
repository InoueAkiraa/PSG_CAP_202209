using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Atacado.DB.EF.Database
{
    [Table("Subcategoria", Schema = "EST")]
    public partial class Subcategoria
    {
        public Subcategoria()
        {
            Produtos = new HashSet<Produto>();
        }

        [Key]
        public int Codigo { get; set; }
        public int CodigoCategoria { get; set; }
        [Unicode(false)]
        public string Descricao { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime DataInsert { get; set; }

        [Column(name: "Ativo")]
        public bool? Ativo { get; set; }

        [ForeignKey("CodigoCategoria")]
        [InverseProperty("Subcategoria")]
        public virtual Categoria CodigoCategoriaNavigation { get; set; } = null!;
        [InverseProperty("CodigoSubcategoriaNavigation")]
        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
