using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ViajeFacil.Dominio.EF
{
    public partial class ViajeFacilContexto : DbContext
    {
        public DbSet<Pais> Paises { get; set; } = null!;
        public DbSet<Regiao> Regioes { get; set; } = null!;
        public DbSet<Estado> Estados { get; set; } = null!;
        public DbSet<Cidade> Cidades { get; set; } = null!;
        public DbSet<Endereco> Enderecos { get; set; } = null!;
        public DbSet<Instituicao> Instituicoes { get; set; } = null!;
        public DbSet<TipoUsuario> TiposUsuario { get; set; } = null!;
        public DbSet<Usuario> Usuarios { get;set; } = null!;
        public DbSet<Rota> Rotas { get; set; } = null!;
        public DbSet<PontoParada> PontosParada { get; set; } = null!;
        public DbSet<Evento> Eventos { get; set; } = null!;
        public DbSet<ParticipanteEvento> ParticipanteEventos { get; set; } = null!;
        public ViajeFacilContexto() 
        { }

        public ViajeFacilContexto(DbContextOptions<ViajeFacilContexto> options) : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
