using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ExameCap.Dominio.EF
{
    [Table("Passageiro", Schema = "dbo")]
    public partial class Passageiro
    {
        [Key]
        [Column(name: "CodigoPassageiro")]
        public int CodigoPassageiro { get; set; }

        [Column(name: "Nome")]
        [Unicode(false)]
        [StringLength(50)]
        public string Nome { get; set; } = null!;

        [Column(name: "Email")]
        [Unicode(false)]
        [StringLength(50)]
        public string Email { get; set; } = null!;

        [Column(name: "Telefone")]
        [Unicode(false)]
        [StringLength(18)]
        public string Telefone { get; set; } = null!;

        [Column(name: "Usuario")]
        [Unicode(false)]
        [StringLength(50)]
        public string Usuario { get; set; } = null!;

        [Column(name: "Senha")]
        [Unicode(false)]
        [StringLength(50)]
        public string Senha { get; set; } = null!;

        [Column(name: "Documento")]
        [Unicode(false)]
        [StringLength(20)]
        public string Documento { get; set; } = null!;

        [Column(name: "NumeroCartao")]
        [Unicode(false)]
        [StringLength(30)]
        public string NumeroCartao { get; set; } = null!;

        [Column(name: "DataNascimento", TypeName = "datetime")]
        public DateTime DataNascimento { get; set; }
    }
}
