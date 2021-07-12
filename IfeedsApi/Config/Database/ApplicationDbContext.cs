using IfeedsApi.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace IfeedsApi.Config.Database
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Contato> Contatos { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<FormularioAvaliacao> FormulariosAvaliacaos { get; set; }

        public DbSet<RespostaFeedback> RespostasFeedbacks { get; set; }

        public DbSet<Campus> Campus { get; set; }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Avaliacao> Avaliacoes { get; set; }

        public DbSet<Feedback> Feedbacks { get; set; }

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


            // Popular o banco
            modelBuilder.Entity<Contato>()
                .HasData(
                    new
                    {
                        Id = 1,
                        Email = "cicrano@email.com",
                        Telefone = "79999999999"
                    },
                    new
                    {
                        Id = 2,
                        Email = "fulano@email.com",
                        Telefone = "79999999999"
                    });

            modelBuilder.Entity<Role>()
                .HasData(
                    new
                    {
                        Id = 1,
                        Tipo = "ADMIN"
                    },
                    new
                    {
                        Id = 2,
                        Tipo = "USER" // servidor ou aluno
                    }
                );

            modelBuilder.Entity<Usuario>()
                .HasData(
                    new
                    {
                        Id = 1,
                        Nome = "Cicrano",
                        Matricula = "20211897238",
                        ContatoId = 1,
                        RoleId = 1
                    }
                );

            modelBuilder.Entity<Categoria>()
                .HasData(
                    new
                    {
                        Id = 1,
                        Nome = "Infraestrutura"
                    },
                    new
                    {
                        Id = 2,
                        Nome = "Coordenação"
                    },
                    new
                    {
                        Id = 3,
                        Nome = "Serviços"
                    },
                    new
                    {
                        Id = 4,
                        Nome = "Eventos"
                    },
                    new
                    {
                        Id = 5,
                        Nome = "Laboratórios"
                    },
                    new
                    {
                        Id = 6,
                        Nome = "Biblioteca"
                    }
                );

            modelBuilder.Entity<Avaliacao>()
                .HasData(
                    new
                    {
                        Id = 1,
                        Titulo = "Banheiro Com Problema",
                        MediaAvaliacao = 4.5m,
                        CategoriaId = 1
                    },
                    new
                    {
                        Id = 2,
                        Titulo = "Corrimão da Escada da COINF Descascando",
                        MediaAvaliacao = 4.5m,
                        CategoriaId = 1
                    },
                    new
                    {
                        Id = 3,
                        Titulo = "Demora para Aprovar Máteria de TCC 1",
                        MediaAvaliacao = 3.5m,
                        CategoriaId = 2
                    },
                    new
                    {
                        Id = 4,
                        Titulo = "Melhorias no Processo de Atendimento",
                        MediaAvaliacao = 4.5m,
                        CategoriaId = 2
                    },
                    new
                    {
                        Id = 5,
                        Titulo = "Pessoal da Limpeza Top",
                        MediaAvaliacao = 5.0m,
                        CategoriaId = 3
                    },
                    new
                    {
                        Id = 6,
                        Titulo = "Problemas com o Wifi do Campus",
                        MediaAvaliacao = 2.5m,
                        CategoriaId = 3
                    },
                    new
                    {
                        Id = 7,
                        Titulo = "Ifs Techday Top",
                        MediaAvaliacao = 5.0m,
                        CategoriaId = 4
                    },
                    new
                    {
                        Id = 8,
                        Titulo = "Semana Academica Divertida",
                        MediaAvaliacao = 4.5m,
                        CategoriaId = 4
                    },
                    new
                    {
                        Id = 9,
                        Titulo = "Semana Academica Algumas Palestras Massantes",
                        MediaAvaliacao = 3.0m,
                        CategoriaId = 4
                    },
                    new
                    {
                        Id = 10,
                        Titulo = "Lab da COINF precisão limpar o filtro do Ar",
                        MediaAvaliacao = 3.5m,
                        CategoriaId = 5
                    },
                    new
                    {
                        Id = 11,
                        Titulo = "Lab de Redes com acustica prejudicada",
                        MediaAvaliacao = 2.5m,
                        CategoriaId = 5
                    },
                    new
                    {
                        Id = 12,
                        Titulo = "Nenhum Livro de Loiane Groner",
                        MediaAvaliacao = 2.5m,
                        CategoriaId = 6
                    },
                    new
                    {
                        Id = 13,
                        Titulo = "Livro de Cálculo com página rasurada",
                        MediaAvaliacao = 3.5m,
                        CategoriaId = 6
                    }
                );
        }
    }
}