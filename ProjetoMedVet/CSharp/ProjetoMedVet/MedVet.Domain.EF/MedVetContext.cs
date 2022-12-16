using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedVet.Domain.EF
{
    public partial class MedVetContext : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; } = null!;
        public DbSet<Atendimento> Atendimentos { get; set; } = null!;
        public DbSet<TipoPessoa> TiposPessoa { get; set; } = null!;
        public DbSet<Cidade> Cidades { get; set; } = null!;
        public DbSet<Convenio> Convenios { get; set; } = null!;
        public DbSet<Endereco> Enderecos { get; set; } = null!;
        public DbSet<Estado> Estados { get; set; } = null!;
        public DbSet<TipoAtendimento> TiposAtendimento { get; set; } = null!;
        public MedVetContext()
        { }

        public MedVetContext(DbContextOptions<MedVetContext> options) : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>(entity =>
            {
                entity.Property(e => e.Situacao).HasDefaultValueSql("((1))");
                entity.Property(e => e.DataDeInsercao).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Atendimento>(entity =>
            {
                entity.Property(e => e.Situacao).HasDefaultValueSql("((1))");
                entity.Property(e => e.DataDeInsercao).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TipoPessoa>(entity =>
            {
                entity.Property(e => e.Situacao).HasDefaultValueSql("((1))");
                entity.Property(e => e.DataDeInsercao).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TipoAtendimento>(entity =>
            {
                entity.Property(e => e.Situacao).HasDefaultValueSql("((1))");
                entity.Property(e => e.DataDeInsercao).HasDefaultValueSql("(getdate())");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
