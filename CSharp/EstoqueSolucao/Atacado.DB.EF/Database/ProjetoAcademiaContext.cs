using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Atacado.DB.EF.Database
{
    public partial class ProjetoAcademiaContext : DbContext
    {
        public ProjetoAcademiaContext()
        {
        }

        public ProjetoAcademiaContext(DbContextOptions<ProjetoAcademiaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categoria> Categorias { get; set; } = null!;
        public virtual DbSet<Cliente> Clientes { get; set; } = null!;
        public virtual DbSet<Departamento> Departamentos { get; set; } = null!;
        public virtual DbSet<Estado> Estados { get; set; } = null!;
        public virtual DbSet<Funcionario> Funcionarios { get; set; } = null!;
        public virtual DbSet<InstituicaoBancaria> InstituicaoBancarias { get; set; } = null!;
        public virtual DbSet<Municipio> Municipios { get; set; } = null!;
        public virtual DbSet<Pais> Paises { get; set; } = null!;
        public virtual DbSet<Produto> Produtos { get; set; } = null!;
        public virtual DbSet<Profissao> Profissoes { get; set; } = null!;
        public virtual DbSet<Subcategoria> Subcategorias { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=psgs0071.psg.local; Initial Catalog=Academia; User=Academia; Password=@cadem1@555;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.Property(e => e.DataInsert).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.Property(e => e.Ativo).HasDefaultValueSql("((1))");

                entity.Property(e => e.DataInclusao).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TipoPessoa)
                    .HasDefaultValueSql("('F')")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Departamento>(entity =>
            {
                entity.Property(e => e.DataInsert).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Estado>(entity =>
            {
                entity.HasKey(e => e.CodigoUf)
                    .HasName("PK__Estado__DB3727ECC065FDB3");

                entity.Property(e => e.CodigoUf).ValueGeneratedNever();

                entity.Property(e => e.SiglaUf).IsFixedLength();
            });

            modelBuilder.Entity<Funcionario>(entity =>
            {
                entity.Property(e => e.DataAdmissao).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Sexo).IsFixedLength();
            });

            modelBuilder.Entity<InstituicaoBancaria>(entity =>
            {
                entity.Property(e => e.DataInsert).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Municipio>(entity =>
            {
                entity.Property(e => e.CodigoMunicipio).ValueGeneratedNever();

                entity.Property(e => e.DataInclusao).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SiglaUf).IsFixedLength();

                entity.HasOne(d => d.CodigoUfNavigation)
                    .WithMany(p => p.Municipios)
                    .HasForeignKey(d => d.CodigoUf)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Municipio_Estado");
            });

            modelBuilder.Entity<Pais>(entity =>
            {
                entity.Property(e => e.DataInsert).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Produto>(entity =>
            {
                entity.Property(e => e.DataInsert).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.CodigoSubcategoriaNavigation)
                    .WithMany(p => p.Produtos)
                    .HasForeignKey(d => d.CodigoSubcategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Produto_Subcategoria");
            });

            modelBuilder.Entity<Profissao>(entity =>
            {
                entity.Property(e => e.DataInsert).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Subcategoria>(entity =>
            {
                entity.Property(e => e.DataInsert).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.CodigoCategoriaNavigation)
                    .WithMany(p => p.Subcategoria)
                    .HasForeignKey(d => d.CodigoCategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubCategoria_Categoria");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
