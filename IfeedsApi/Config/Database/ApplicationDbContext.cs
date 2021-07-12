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
                    },
                    new
                    {
                        Id = 3,
                        Email = "maria@email.com",
                        Telefone = "71999999999"
                    },
                    new
                    {
                        Id = 4,
                        Email = "jose@email.com",
                        Telefone = "7199944444"
                    },
                    new
                    {
                        Id = 5,
                        Email = "joao@email.com",
                        Telefone = "7199933333"
                    },
                    new
                    {
                        Id = 6,
                        Email = "carlos@email.com",
                        Telefone = "71999995555"
                    },
                    new
                    {
                        Id = 7,
                        Email = "rafaela@email.com",
                        Telefone = "7199999999999"
                    },
                    new
                    {
                        Id = 8,
                        Email = "kaiki@email.com",
                        Telefone = "71999666666",
                    },
                    new
                    {
                        Id = 9,
                        Email = "vanilton@email.com",
                        Telefone = "71999977777",
                    },
                    new
                    {
                        Id = 10,
                        Email = "chico@email.com",
                        Telefone = "71999998888",
                    }
                 );



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
                    },
                    new 
                    {
                        Id = 2,
                        Nome = "Fulano",
                        Matricula = "21203554",
                        ContatoId = 2,
                        RoleId = 2
                    },
                    new 
                    {
                        Id = 3,
                        Nome = "Maria",
                        Matricula = "20215888854",
                        ContatoId = 3,
                        RoleId = 2
                    },
                    new 
                    {
                        Id = 4,
                        Nome = "Jose",
                        Matricula = "2021777554",
                        ContatoId = 4,
                        RoleId = 2
                    },
                    new 
                    {
                        Id = 5,
                        Nome = "Joao",
                        Matricula = "2021533554",
                        ContatoId = 5,
                        RoleId = 2
                    },
                    new 
                    {
                        Id = 6,
                        Nome = "Carlos",
                        Matricula = "20215554",
                        ContatoId = 6,
                        RoleId = 2
                    },
                    new 
                    {
                        Id = 7,
                        Nome = "Rafaela",
                        Matricula = "20213554",
                        ContatoId = 7,
                        RoleId = 2
                    },
                    new
                    {
                        Id = 8,
                        Nome = "Kaiki",
                        Matricula = "202156954",
                        ContatoId = 8,
                        RoleId = 2
                    },
                    new 
                    {
                        Id = 9,
                        Nome = "Vanilton",
                        Matricula = "20266654",
                        ContatoId = 9,
                        RoleId = 2
                    },
                    new 
                    {
                        Id = 10,
                        Nome = "Chico",
                        Matricula = "2021585641",
                        ContatoId = 10,
                        RoleId = 2
                    }
                );



            modelBuilder.Entity<Campus>()
                .HasData(
                    new
                    {
                        Id = 1,
                        Nome = "IFS-Campus Lagarto",
                    },

                    new
                    {
                        Id = 2,
                        Nome = "IFS-Campus Glória",
                    },

                    new
                    {
                        Id = 3,
                        Nome = "IFS-Campus Estância",
                    },
                    new
                    {
                        Id = 4,
                        Nome = "IFS-Campus São Cristovão",
                    },
                    new
                    {
                        Id = 5,
                        Nome = "IFS-Campus Itabaiana",
                    },
                    new
                    {
                        Id = 6,
                        Nome = "IFS-Campus Aracaju",
                    },
                    new
                    {
                        Id = 7,
                        Nome = "IFS-Campus Tobias Barreto",
                    },
                    new
                    {
                        Id = 8,
                        Nome = "IFS-Campus Poço Redondo",
                    },
                    new
                    {
                        Id = 9,
                        Nome = "IFS-Campus Propriá",
                    },
                    new
                    {
                        Id = 10,
                        Nome = "IFS-Campus Socorro",
                    },
                    new
                    {
                        Id = 11,
                        Nome = "IFS-Educação a Distancia",
                    }

                );




            modelBuilder.Entity<FormularioAvaliacao>()
                .HasData(
                    new
                    {
                        Id = 1,
                        Descricao = "Banheiro com problema espelho quebrado",
                        QuantidadeEstrelas = 3.50m,
                    },
                    new
                    {
                        Id = 2,
                        Descricao = "Corrimão da Escada da COINF Descascando. Me cortei",
                        QuantidadeEstrelas = 3m,
                    },
                    new
                    {
                        Id = 3,
                        Descricao = "Demora para Aprovar Máteria de TCC 1 - Estou com mais de um mes aguardando aprovação",
                        QuantidadeEstrelas = 2.50m,
                    },
                    new
                    {
                        Id = 4,
                        Descricao = "Melhorias no Processo de Atendimento -  Deveriam automatizar mais os processos",
                        QuantidadeEstrelas = 3m,
                    },
                    new
                    {
                        Id = 5,
                        Descricao = "Pessoal da Limpeza Top - Campus sempre muito bem conservado",
                        QuantidadeEstrelas = 5m,
                    },
                    new
                    {
                        Id = 6,
                        Descricao = "Problemas com o Wifi do Campus - Internet lenta o que dificulta o acesso",
                        QuantidadeEstrelas = 4m,
                    },

                    new
                    {
                        Id = 7,
                        Descricao = "Ifs Techday Top - Evento maravilhoso",
                        QuantidadeEstrelas = 5m,
                    },
                    new
                    {
                        Id = 8,
                        Descricao = "Semana Academica Divertida - Evento top",
                        QuantidadeEstrelas = 4.50m,
                    },
                    new
                    {
                        Id = 9,
                        Descricao = "Semana Academica Algumas Palestras Massantes - palestras muito longas e cansativas",
                        QuantidadeEstrelas = 2.50m,
                    },
                    new
                    {
                        Id = 10,
                        Descricao = "Lab da COINF precisão limpar o filtro do Ar - nunca funciona corretamente",
                        QuantidadeEstrelas = 3.50m,
                    },
                    new
                    {
                        Id = 11,
                        Descricao = "Lab de Redes com acustica prejudicada - Barulho da oficina atrapalha a aula",
                        QuantidadeEstrelas = 2.50m,
                    },
                    new
                    {
                        Id = 12,
                        Descricao = "Nenhum Livro de Loiane Groner - acervos desatualizados",
                        QuantidadeEstrelas = 3m,
                    },
                    new
                    {
                        Id = 13,
                        Descricao = "Livro de Cálculo com página rasurada - o livro está com rasuras",
                        QuantidadeEstrelas = 3m,
                    }
            );


            modelBuilder
                .Entity<Campus>()
                .HasMany(p => p.FormulariosAvaliacoes)
                .WithMany(p => p.Campus)
                .UsingEntity(j => j.ToTable("CampusFormularioAvaliacao")
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

            modelBuilder
                .Entity<Campus>()
                .HasMany(p => p.FormulariosAvaliacoes)
                .WithMany(p => p.Campus)
                .UsingEntity(j => j.HasData(
                    new { CampusId = 1, FormulariosAvaliacoesId = 1 },
                    new { CampusId = 2, FormulariosAvaliacoesId = 2 },
                    new { CampusId = 3, FormulariosAvaliacoesId = 4 },
                    new { CampusId = 4, FormulariosAvaliacoesId = 3 },
                    new { CampusId = 5, FormulariosAvaliacoesId = 5 },
                    new { CampusId = 6, FormulariosAvaliacoesId = 7 },
                    new { CampusId = 7, FormulariosAvaliacoesId = 6 },
                    new { CampusId = 8, FormulariosAvaliacoesId = 8 }, 
                    new { CampusId = 9, FormulariosAvaliacoesId = 10 }, 
                    new { CampusId = 10,FormulariosAvaliacoesId = 9}
                ));

        }
    }
}