using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Atacado.DB.EF.Database
{
    [Table("Funcionario", Schema = "RH")]
    public partial class Funcionario
    {
        [Key]
        public long FuncionarioId { get; set; }
        public long Matricula { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Nome { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Sobrenome { get; set; } = null!;
        [StringLength(1)]
        [Unicode(false)]
        public string Sexo { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime DataNascimento { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Email { get; set; } = null!;
        [StringLength(20)]
        [Unicode(false)]
        public string Ctps { get; set; } = null!;
        public long CtpsNum { get; set; }
        public int CtpsSerie { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAdmissao { get; set; }
        [Column(name: "Ativo")]
        public bool? Ativo { get; set; }
    }
}
