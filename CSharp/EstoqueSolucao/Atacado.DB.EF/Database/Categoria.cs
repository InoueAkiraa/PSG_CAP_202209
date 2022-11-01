using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Atacado.DB.EF.Database
{
    [Table("Categoria", Schema = "EST")]
    public partial class Categoria
    {
        public Categoria()
        {
            Subcategoria = new HashSet<Subcategoria>();
        }

        [Key]
        public int Codigo { get; set; }
        [Unicode(false)]
        public string Descricao { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime DataInsert { get; set; }

        [Column(name: "Ativo")]
        public bool? Ativo { get; set; }

        [InverseProperty("CodigoCategoriaNavigation")]
        public virtual ICollection<Subcategoria> Subcategoria { get; set; }
    }
}
