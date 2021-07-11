using IfeedsApi.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace IfeedsApi.Config.Database
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<FormularioAvaliacao> FormularioAvaliacao { get; set; }

        public DbSet<RespostaFeedback> RespostasFeedbacks { get; set; }

        public DbSet<Campus> Campus { get; set; }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Avaliacao> Avaliacao { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Entidade Usuário
            modelBuilder.Entity<Usuario>()
                .HasIndex(p => p.Matricula)
                .IsUnique();

            modelBuilder.Entity<Usuario>()
                .Property(p => p.DataCriacao)
                .HasDefaultValueSql("(utc_timestamp())");


            // Entidade Contato
            modelBuilder.Entity<Contato>()
                .HasIndex(p => p.Email)
                .IsUnique();

            modelBuilder.Entity<Contato>()
                .Property(p => p.DataCriacao)
                .HasDefaultValueSql("(utc_timestamp())");

            //Entidade Role
            modelBuilder.Entity<Role>()
                .HasIndex(p => p.Tipo)
                .IsUnique();

            modelBuilder.Entity<Role>()
                .Property(p => p.DataCriacao)
                .HasDefaultValueSql("(utc_timestamp())");



            //Entidade Formulario Avaliação
            modelBuilder.Entity<FormularioAvaliacao>()
                .Property(p => p.DataCriacao)
                .HasDefaultValueSql("(utc_timestamp())");

            //Entidade Campus
            modelBuilder.Entity<Campus>()
                .HasIndex(p => p.Nome)
                .IsUnique();

            modelBuilder.Entity<Campus>()
                .Property(p => p.DataCriacao)
                .HasDefaultValueSql("(utc_timestamp())");

            //Entidade Categoria
            modelBuilder.Entity<Categoria>()
                .HasIndex(p => p.Nome)
                .IsUnique();

            modelBuilder.Entity<Categoria>()
                .Property(p => p.DataCriacao)
                .HasDefaultValueSql("(utc_timestamp())");

            //Entidade Avalicao
            modelBuilder.Entity<Avaliacao>()
                .Property(p => p.DataCriacao)
                .HasDefaultValueSql("(utc_timestamp())");

            //Entidade Feedback
            modelBuilder.Entity<Feedback>()
                .Property(p => p.Codigo)
                .HasDefaultValueSql("(UUID())");

            modelBuilder.Entity<Feedback>()
                .Property(p => p.DataCriacao)
                .HasDefaultValueSql("(utc_timestamp())");


            //Entidade RespostaFeedbck
            modelBuilder.Entity<RespostaFeedback>()
                .Property(p => p.DataCriacao)
                .HasDefaultValueSql("(utc_timestamp())");

        }
    }
}