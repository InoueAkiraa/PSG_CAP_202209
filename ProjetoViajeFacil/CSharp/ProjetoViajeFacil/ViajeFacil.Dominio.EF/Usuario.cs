using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajeFacil.Dominio.EF
{
    [Table("usuario", Schema = "dbo")]
    public partial class Usuario
    {
        [Key]
        [Column(name: "id_usuario")]
        public long CodigoUsuario { get; set; }

        [Column(name: "nome")]
        [Unicode(false)]
        [StringLength(100)]
        public string Nome { get; set; } = null!;

        [Column(name: "email")]
        [Unicode(false)]
        [StringLength(50)]
        public string Email { get; set; } = null!;

        [Column(name: "cpf")]
        [Unicode(false)]
        [StringLength(50)]
        public string CPF { get; set; } = null!;

        [Column(name: "telefone")]
        [Unicode(false)]
        [StringLength(20)]
        public string Telefone { get; set; } = null!;

        [Column(name: "login")]
        [Unicode(false)]
        [StringLength(50)]
        public string Login { get; set; } = null!;

        [Column(name: "senha")]
        [Unicode(false)]
        [StringLength(255)]
        public string Senha { get; set; } = null!;

        [Column(name: "id_endereco")]
        public long CodigoEndereco { get; set; }

        [Column(name: "id_tipo_usuario")]
        public long CodigoTipoUsuario { get; set; }

        [Column(name: "id_instituicao")]
        public long CodigoInstituicao { get; set; }
    }
}
