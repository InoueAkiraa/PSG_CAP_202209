namespace LibTec.Poco
{
    public class UsuarioPoco
    {
        public int CodigoUsuario { get; set; }

        public string Nome { get; set; } = null!;

        public string Sobrenome { get; set; } = null!;

        public string Senha { get; set; } = null!;

        public string Email { get; set; } = null!;

        public int MaxEmprestimos { get; set; }

        public int CodigoTipoUsuario { get; set; }

        public bool? Situacao { get; set; }

        public DateTime? DataDeInclusao { get; set; }

        public DateTime? DataDeAlteracao { get; set; }

        public DateTime? DataDeExclusao { get; set; }
    }
}
