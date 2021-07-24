using IfeedsApi.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;

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

            // Entidade Contato
            modelBuilder.Entity<Contato>()
                .HasIndex(p => p.Email)
                .IsUnique();


            //Entidade Role
            modelBuilder.Entity<Role>()
                .HasIndex(p => p.Tipo)
                .IsUnique();

                
            //Entidade Campus
            modelBuilder.Entity<Campus>()
                .HasIndex(p => p.Nome)
                .IsUnique();

            //Entidade Categoria
            modelBuilder.Entity<Categoria>()
                .HasIndex(p => p.Nome)
                .IsUnique();

            // Popular o banco
            modelBuilder.Entity<Contato>()
                .HasData(
                    new
                    {
                        Id = 1,
                        Email = "cicrano@email.com",
                        Telefone = "79999999999",
                        DataCriacao =  DateTime.UtcNow
                    },
                    new
                    {
                        Id = 2,
                        Email = "fulano@email.com",
                        Telefone = "79999999999",
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 3,
                        Email = "maria@email.com",
                        Telefone = "71999999999",
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 4,
                        Email = "jose@email.com",
                        Telefone = "7199944444",
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 5,
                        Email = "joao@email.com",
                        Telefone = "7199933333",
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 6,
                        Email = "carlos@email.com",
                        Telefone = "71999995555",
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 7,
                        Email = "rafaela@email.com",
                        Telefone = "7199999999999",
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 8,
                        Email = "kaiki@email.com",
                        Telefone = "71999666666",
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 9,
                        Email = "vanilton@email.com",
                        Telefone = "71999977777",
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 10,
                        Email = "chico@email.com",
                        Telefone = "71999998888",
                        DataCriacao = DateTime.UtcNow
                    }
                 );



            modelBuilder.Entity<Role>()
                .HasData(
                    new
                    {
                        Id = 1,
                        Tipo = "ADMIN",
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 2,
                        Tipo = "USER" , // servidor ou aluno
                        DataCriacao = DateTime.UtcNow

                    }
                );




            modelBuilder.Entity<Usuario>()
                .HasData(
                    new 
                    {
                        Id = 1,
                        Nome = "Cicrano",
                        Senha = BCrypt.Net.BCrypt.HashPassword("12345678"),
                        Matricula = "20211897238",
                        Status = true,
                        ContatoId = 1,
                        RoleId = 1,
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 2,
                        Nome = "Fulano",
                        Senha = BCrypt.Net.BCrypt.HashPassword("12345678"),
                        Matricula = "21203554",
                        Status = true,
                        ContatoId = 2,
                        RoleId = 2,
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 3,
                        Nome = "Maria",
                        Senha = BCrypt.Net.BCrypt.HashPassword("12345678"),
                        Matricula = "20215888854",
                        Status = true,
                        ContatoId = 3,
                        RoleId = 2,
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 4,
                        Nome = "Jose",
                        Senha = BCrypt.Net.BCrypt.HashPassword("12345678"),
                        Matricula = "2021777554",
                        Status = true,
                        ContatoId = 4,
                        RoleId = 2,
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 5,
                        Nome = "Joao",
                        Senha = BCrypt.Net.BCrypt.HashPassword("12345678"),
                        Matricula = "2021533554",
                        Status = true,
                        ContatoId = 5,
                        RoleId = 2,
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 6,
                        Nome = "Carlos",
                        Senha = BCrypt.Net.BCrypt.HashPassword("12345678"),
                        Matricula = "20215554",
                        Status = true,
                        ContatoId = 6,
                        RoleId = 2,
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 7,
                        Nome = "Rafaela",
                        Senha = BCrypt.Net.BCrypt.HashPassword("12345678"),
                        Matricula = "20213554",
                        Status = true,
                        ContatoId = 7,
                        RoleId = 2,
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 8,
                        Nome = "Kaiki",
                        Senha = BCrypt.Net.BCrypt.HashPassword("12345678"),
                        Matricula = "202156954",
                        Status = true,
                        ContatoId = 8,
                        RoleId = 2,
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 9,
                        Nome = "Vanilton",
                        Senha = BCrypt.Net.BCrypt.HashPassword("12345678"),
                        Matricula = "20266654",
                        Status = true,
                        ContatoId = 9,
                        RoleId = 2,
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 10,
                        Nome = "Chico",
                        Senha = BCrypt.Net.BCrypt.HashPassword("12345678"),
                        Matricula = "2021585641",
                        Status = true,
                        ContatoId = 10,
                        RoleId = 2,
                        DataCriacao = DateTime.UtcNow
                    }
                );



            modelBuilder.Entity<Campus>()
                .HasData(
                    new
                    {
                        Id = 1,
                        Nome = "IFS-Campus Lagarto",
                        DataCriacao = DateTime.UtcNow
                    },

                    new
                    {
                        Id = 2,
                        Nome = "IFS-Campus Glória",
                        DataCriacao = DateTime.UtcNow
                    },

                    new
                    {
                        Id = 3,
                        Nome = "IFS-Campus Estância",
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 4,
                        Nome = "IFS-Campus São Cristovão",
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 5,
                        Nome = "IFS-Campus Itabaiana",
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 6,
                        Nome = "IFS-Campus Aracaju",
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 7,
                        Nome = "IFS-Campus Tobias Barreto",
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 8,
                        Nome = "IFS-Campus Poço Redondo",
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 9,
                        Nome = "IFS-Campus Propriá",
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 10,
                        Nome = "IFS-Campus Socorro",
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 11,
                        Nome = "IFS-Educação a Distancia",
                        DataCriacao = DateTime.UtcNow
                    }

                );




            modelBuilder.Entity<FormularioAvaliacao>()
                .HasData(
                    new
                    {
                        Id = 1,
                        Titulo = "Banheiro com problema",
                        Descricao = "Banheiro com problema espelho quebrado",
                        QuantidadeEstrelas = 3.50m,
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 2,
                        Titulo = "Problema no corrimão",
                        Descricao = "Corrimão da Escada da COINF Descascando. Me cortei",
                        QuantidadeEstrelas = 3m,
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 3,
                        Titulo = "Dificuldade com TCC",
                        Descricao = "Demora para Aprovar Máteria de TCC 1 - Estou com mais de um mes aguardando aprovação",
                        QuantidadeEstrelas = 2.50m,
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 4,
                        Titulo = "Sugestão de Melhoria",
                        Descricao = "Melhorias no Processo de Atendimento -  Deveriam automatizar mais os processos",
                        QuantidadeEstrelas = 3m,
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 5,
                        Titulo = "Elogio ao pessoal da limpeza",
                        Descricao = "Pessoal da Limpeza Top - Campus sempre muito bem conservado",
                        QuantidadeEstrelas = 5m,
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 6,
                        Titulo = "Problemas com WIFI",
                        Descricao = "Problemas com o Wifi do Campus - Internet lenta o que dificulta o acesso",
                        QuantidadeEstrelas = 4m,
                        DataCriacao = DateTime.UtcNow
                    },

                    new
                    {
                        Id = 7,
                        Titulo = "Elogio ao Techday",
                        Descricao = "Ifs Techday Top - Evento maravilhoso",
                        QuantidadeEstrelas = 5m,
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 8,
                        Titulo = "Elogio ao evento",
                        Descricao = "Semana Academica Divertida - Evento top",
                        QuantidadeEstrelas = 4.50m,
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 9,
                        Titulo = "Palestras cansativas na SEMAC",
                        Descricao = "Semana Academica Algumas Palestras Massantes - palestras muito longas e cansativas",
                        QuantidadeEstrelas = 2.50m,
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 10,
                        Titulo = "Problema com Ar",
                        Descricao = "Lab da COINF precisão limpar o filtro do Ar - nunca funciona corretamente",
                        QuantidadeEstrelas = 3.50m,
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 11,
                        Titulo = "Barulho no lab de redes",
                        Descricao = "Lab de Redes com acustica prejudicada - Barulho da oficina atrapalha a aula",
                        QuantidadeEstrelas = 2.50m,
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 12,
                        Titulo = "Sugestão de bibliográfia",
                        Descricao = "Nenhum Livro de Loiane Groner - acervos desatualizados",
                        QuantidadeEstrelas = 3m,
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 13,
                        Titulo = "Rasuras no livro",
                        Descricao = "Livro de Cálculo com página rasurada - o livro está com rasuras",
                        QuantidadeEstrelas = 3m,
                        DataCriacao = DateTime.UtcNow
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
                        Nome = "Infraestrutura",
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 2,
                        Nome = "Coordenação",
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 3,
                        Nome = "Serviços",
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 4,
                        Nome = "Eventos",
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 5,
                        Nome = "Laboratórios",
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 6,
                        Nome = "Biblioteca",
                        DataCriacao = DateTime.UtcNow
                    }
                );

            modelBuilder.Entity<Avaliacao>()
                .HasData(
                    new
                    {
                        Id = 1,
                        Titulo = "Banheiro Com Problema",
                        MediaAvaliacao = 4.5m,
                        CategoriaId = 1, 
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 2,
                        Titulo = "Corrimão da Escada da COINF Descascando",
                        MediaAvaliacao = 4.5m,
                        CategoriaId = 1,
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 3,
                        Titulo = "Demora para Aprovar Máteria de TCC 1",
                        MediaAvaliacao = 3.5m,
                        CategoriaId = 2,
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 4,
                        Titulo = "Melhorias no Processo de Atendimento",
                        MediaAvaliacao = 4.5m,
                        CategoriaId = 2,
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 5,
                        Titulo = "Pessoal da Limpeza Top",
                        MediaAvaliacao = 5.0m,
                        CategoriaId = 3,
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 6,
                        Titulo = "Problemas com o Wifi do Campus",
                        MediaAvaliacao = 2.5m,
                        CategoriaId = 3,
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 7,
                        Titulo = "Ifs Techday Top",
                        MediaAvaliacao = 5.0m,
                        CategoriaId = 4,
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 8,
                        Titulo = "Semana Academica Divertida",
                        MediaAvaliacao = 4.5m,
                        CategoriaId = 4,
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 9,
                        Titulo = "Semana Academica Algumas Palestras Massantes",
                        MediaAvaliacao = 3.0m,
                        CategoriaId = 4,
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 10,
                        Titulo = "Lab da COINF precisão limpar o filtro do Ar",
                        MediaAvaliacao = 3.5m,
                        CategoriaId = 5,
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 11,
                        Titulo = "Lab de Redes com acustica prejudicada",
                        MediaAvaliacao = 2.5m,
                        CategoriaId = 5,
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 12,
                        Titulo = "Nenhum Livro de Loiane Groner",
                        MediaAvaliacao = 2.5m,
                        CategoriaId = 6,
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 13,
                        Titulo = "Livro de Cálculo com página rasurada",
                        MediaAvaliacao = 3.5m,
                        CategoriaId = 6,
                        DataCriacao = DateTime.UtcNow
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

            modelBuilder.Entity<Feedback>()
                .HasData(
                    new
                    {
                        Id = 1,
                        Codigo = Guid.NewGuid(),
                        DataCriacao = DateTime.UtcNow,
                        FormularioAvaliacaoId = 1,
                        UsuarioId = 2,
                        AvaliacaoId = 1
                    },
                    new
                    {
                        Id = 2,
                        Codigo = Guid.NewGuid(),
                        DataCriacao = DateTime.UtcNow,
                        FormularioAvaliacaoId = 2,
                        UsuarioId = 1,
                        AvaliacaoId = 2
                    },
                    new
                    {
                        Id = 3,
                        Codigo = Guid.NewGuid(),
                        DataCriacao = DateTime.UtcNow,
                        FormularioAvaliacaoId = 3,
                        UsuarioId = 4,
                        AvaliacaoId = 3
                    },
                    new
                    {
                        Id = 4,
                        Codigo = Guid.NewGuid(),
                        DataCriacao = DateTime.UtcNow,
                        FormularioAvaliacaoId = 4,
                        UsuarioId = 3,
                        AvaliacaoId = 4
                    },
                    new
                    {
                        Id = 5,
                        Codigo = Guid.NewGuid(),
                        DataCriacao = DateTime.UtcNow,
                        FormularioAvaliacaoId = 5,
                        UsuarioId = 3,
                        AvaliacaoId = 5
                    },
                    new
                    {
                        Id = 6,
                        Codigo = Guid.NewGuid(),
                        DataCriacao = DateTime.UtcNow,
                        FormularioAvaliacaoId = 6,
                        UsuarioId = 8,
                        AvaliacaoId = 6
                    },
                    new
                    {
                        Id = 7,
                        Codigo = Guid.NewGuid(),
                        DataCriacao = DateTime.UtcNow,
                        FormularioAvaliacaoId = 7,
                        UsuarioId = 5,
                        AvaliacaoId = 7
                    },
                    new
                    {
                        Id = 8,
                        Codigo = Guid.NewGuid(),
                        DataCriacao = DateTime.UtcNow,
                        FormularioAvaliacaoId = 8,
                        UsuarioId = 9,
                        AvaliacaoId = 2
                    },
                    new
                    {
                        Id = 9,
                        Codigo = Guid.NewGuid(),
                        DataCriacao = DateTime.UtcNow,
                        FormularioAvaliacaoId = 9,
                        UsuarioId = 10,
                        AvaliacaoId = 5
                    },
                    new
                    {
                        Id = 10,
                        Codigo = Guid.NewGuid(),
                        DataCriacao = DateTime.UtcNow,
                        FormularioAvaliacaoId = 10,
                        UsuarioId = 7,
                        AvaliacaoId = 8
                    },
                    new
                    {
                        Id = 11,
                        Codigo = Guid.NewGuid(),
                        DataCriacao = DateTime.UtcNow,
                        FormularioAvaliacaoId = 11,
                        UsuarioId = 3,
                        AvaliacaoId = 4
                    },
                    new
                    {
                        Id = 12,
                        Codigo = Guid.NewGuid(),
                        DataCriacao = DateTime.UtcNow,
                        FormularioAvaliacaoId = 13,
                        UsuarioId = 4,
                        AvaliacaoId = 2
                    },
                    new
                    {
                        Id = 13,
                        Codigo = Guid.NewGuid(),
                        DataCriacao = DateTime.UtcNow,
                        FormularioAvaliacaoId = 12,
                        UsuarioId = 2,
                        AvaliacaoId = 8
                    }
                );

            modelBuilder.Entity<RespostaFeedback>()
                .HasData(
                    new
                    {
                        Id = 1,
                        Resposta = "Obrigado, iremos resolver",
                        FeedbackId = 2,
                        UsuarioId = 1,
                        Status = true,
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 2,
                        Resposta = "Obrigado, Sim, eles são maravilhosos",
                        FeedbackId = 5,
                        UsuarioId =1,
                        Status = true,
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 3,
                        Resposta = "Resolução esta em andamento",
                        FeedbackId = 4,
                        UsuarioId = 1,
                        Status = true,
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 4,
                        Resposta = "Oh, não estavamos cientes dessa situação",
                        FeedbackId = 1,
                        UsuarioId = 1,
                        Status = true,
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 5,
                        Resposta = "Que bom que está gostando, aproveite",
                        FeedbackId = 3,
                        UsuarioId = 1,
                        Status = true,
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 6,
                        Resposta = "Repassando para os resposáveis",
                        FeedbackId = 6,
                        UsuarioId = 1,
                        Status = true,
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 7,
                        Resposta = "Obrigado pelo seu feedback",
                        FeedbackId = 8,
                        UsuarioId = 1,
                        Status = true,
                        DataCriacao = DateTime.UtcNow
                    }
                );
        }
    }
}