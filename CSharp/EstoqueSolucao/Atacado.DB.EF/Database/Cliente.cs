using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Atacado.DB.EF.Database
{
    [Table("Cliente", Schema = "Geral")]
    public partial class Cliente
    {
        [Key]
        public int Codigo { get; set; }
        [Unicode(false)]
        public string Nome { get; set; } = null!;
        [Unicode(false)]
        public string? RazaoSocial { get; set; }
        [Unicode(false)]
        public string? NomeFantasia { get; set; }
        [StringLength(14)]
        [Unicode(false)]
        public string Documento { get; set; } = null!;
        [StringLength(11)]
        [Unicode(false)]
        public string Telefone { get; set; } = null!;
        [Unicode(false)]
        public string Email { get; set; } = null!;
        [StringLength(1)]
        [Unicode(false)]
        public string TipoPessoa { get; set; } = null!;
        [Unicode(false)]
        public string? Endereco { get; set; }
        [Required]
        public bool? Ativo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DataInclusao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAlteracao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataExclusao { get; set; }
    }
}
