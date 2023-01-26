using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Avaliar.Domain.EF
{
    public partial class AvaliarContext : DbContext
    {
	    public DbSet<Categoria> Categorias { get; set; } = null!;
        public DbSet<Produto> Produtos { get; set; } = null!;

        public AvaliarContext() 
        { }
        public AvaliarContext(DbContextOptions<AvaliarContext> options) : base(options)
        { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            { }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>(entity => 
            {
                entity.Property(e => e.DataInclusao).HasDefaultValueSql("(getdate())");
                entity.Property(e => e.Ativo).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Produto>(entity =>
            {
                entity.Property(e => e.DataInclusao).HasDefaultValueSql("(getdate())");
                entity.Property(e => e.Ativo).HasDefaultValueSql("((1))");
            });
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}