using IfeedsApi.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace IfeedsApi.Core.Database
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Contato> Contatos { get; set; }

        public DbSet<Role> Roles { get; set; }

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
                        DataCriacao = DateTime.UtcNow,
                        CampusId = 1
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
                        DataCriacao = DateTime.UtcNow,
                        CampusId = 2
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
                        DataCriacao = DateTime.UtcNow,
                        CampusId = 3
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
                        DataCriacao = DateTime.UtcNow,
                        CampusId = 1
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
                        DataCriacao = DateTime.UtcNow,
                        CampusId = 6
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
                        DataCriacao = DateTime.UtcNow,
                        CampusId = 7
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
                        DataCriacao = DateTime.UtcNow,
                        CampusId = 4
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
                        DataCriacao = DateTime.UtcNow,
                        CampusId = 2
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
                        DataCriacao = DateTime.UtcNow,
                        CampusId = 4
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
                        DataCriacao = DateTime.UtcNow,
                        CampusId = 1
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
                    }
                );

            modelBuilder.Entity<Avaliacao>()
                .HasData(
                    new
                    {
                        Id = 1,
                        Titulo = "Banheiro",
                        MediaAvaliacao = 3.5m,
                        CategoriaId = 1, 
                        CampusId = 1,
                        DataCriacao = DateTime.UtcNow

                    },
                    new
                    {
                        Id = 2,
                        Titulo = "Escada COINF",
                        MediaAvaliacao = 3.0m,
                        CategoriaId = 1,
                        CampusId = 2,
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 3,
                        Titulo = "COINF",
                        MediaAvaliacao = 2.5m,
                        CategoriaId = 2,
                        CampusId = 3,
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 4,
                        Titulo = "GEN",
                        MediaAvaliacao = 3.0m,
                        CategoriaId = 2,
                        CampusId = 4,
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 5,
                        Titulo = "Limpeza",
                        MediaAvaliacao = 5.0m,
                        CategoriaId = 3,
                        CampusId = 5,
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 6,
                        Titulo = "Biblioteca",
                        MediaAvaliacao = 3.5m,
                        CategoriaId = 3,
                        CampusId = 1,
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 7,
                        Titulo = "Ifs Techday",
                        MediaAvaliacao = 5.0m,
                        CategoriaId = 4,
                        CampusId = 7,
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 8,
                        Titulo = "Semana Acadêmica",
                        MediaAvaliacao = 3.5m,
                        CategoriaId = 4,
                        CampusId = 8,
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 9,
                        Titulo = "Ifs Dev Conf",
                        MediaAvaliacao = 0.0m,
                        CategoriaId = 4,
                        CampusId = 9,
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 10,
                        Titulo = "Lab da COINF",
                        MediaAvaliacao = 3.5m,
                        CategoriaId = 5,
                        CampusId = 10,
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 11,
                        Titulo = "Lab de Redes",
                        MediaAvaliacao = 2.5m,
                        CategoriaId = 5,
                        CampusId = 11,
                        DataCriacao = DateTime.UtcNow
                    },

                    new
                    {
                        Id = 12,
                        Titulo = "Refeitório",
                        MediaAvaliacao = 0.0m,
                        CategoriaId = 1,
                        CampusId = 1,
                        DataCriacao = DateTime.UtcNow
                    },
                    new
                    {
                        Id = 13,
                        Titulo = "Quadra Poliesportiva",
                        MediaAvaliacao = 0.0m,
                        CategoriaId = 1,
                        CampusId = 6,
                        DataCriacao = DateTime.UtcNow
                    }
                    
                );

            modelBuilder.Entity<Feedback>()
                .HasData(
                    new
                    {
                        Id = 1,
                        Codigo = Guid.NewGuid(),
                        DataCriacao = DateTime.UtcNow,
                        UsuarioId = 2,
                        Titulo = "Banheiro com problema",
                        Descricao = "Banheiro com problema espelho quebrado",
                        Nota = 3.50m,
                        AvaliacaoId = 1
                        
                    },
                    new
                    {
                        Id = 2,
                        Codigo = Guid.NewGuid(),
                        DataCriacao = DateTime.UtcNow,
                        UsuarioId = 1,
                        Titulo = "Problema no corrimão",
                        Descricao = "Corrimão da Escada da COINF Descascando. Me cortei",
                        Nota = 3m,
                        AvaliacaoId = 2
                    },
                    new
                    {
                        Id = 3,
                        Codigo = Guid.NewGuid(),
                        DataCriacao = DateTime.UtcNow,
                        UsuarioId = 4,
                        Titulo = "Dificuldade com TCC",
                        Descricao = "Demora para Aprovar Máteria de TCC 1 - Estou com mais de um mes aguardando aprovação",
                        Nota = 2.50m,
                        AvaliacaoId = 3
                    },
                    new
                    {
                        Id = 4,
                        Codigo = Guid.NewGuid(),
                        DataCriacao = DateTime.UtcNow,
                        UsuarioId = 3,
                        Titulo = "Sugestão de Melhoria",
                        Descricao = "Melhorias no Processo de Atendimento -  Deveriam automatizar mais os processos",
                        Nota = 3m,
                        AvaliacaoId = 4
                    },
                    new
                    {
                        Id = 5,
                        Codigo = Guid.NewGuid(),
                        DataCriacao = DateTime.UtcNow,
                        UsuarioId = 3,
                        Titulo = "Elogio ao pessoal da limpeza",
                        Descricao = "Pessoal da Limpeza Top - Campus sempre muito bem conservado",
                        Nota = 5m,
                        AvaliacaoId = 5
                    },
                    new
                    {
                        Id = 6,
                        Codigo = Guid.NewGuid(),
                        DataCriacao = DateTime.UtcNow,
                        UsuarioId = 8,
                        Titulo = "Problemas com WIFI",
                        Descricao = "Problemas com o Wifi do Campus - Internet lenta o que dificulta o acesso",
                        Nota = 4m,
                        AvaliacaoId = 6
                    },
                    new
                    {
                        Id = 7,
                        Codigo = Guid.NewGuid(),
                        DataCriacao = DateTime.UtcNow,
                        UsuarioId = 5,
                        Titulo = "Elogio ao Techday",
                        Descricao = "Ifs Techday Top - Evento maravilhoso",
                        Nota = 5m,
                        AvaliacaoId = 7
                    },
                    new
                    {
                        Id = 8,
                        Codigo = Guid.NewGuid(),
                        DataCriacao = DateTime.UtcNow,
                        UsuarioId = 9,
                        Titulo = "Elogio ao evento",
                        Descricao = "Semana Academica Divertida - Evento top",
                        Nota = 4.50m,
                        AvaliacaoId = 8
                    },
                    new
                    {
                        Id = 9,
                        Codigo = Guid.NewGuid(),
                        DataCriacao = DateTime.UtcNow,
                        UsuarioId = 10,
                        Titulo = "Palestras cansativas na SEMAC",
                        Descricao = "Semana Academica Algumas Palestras Massantes - palestras muito longas e cansativas",
                        Nota = 2.50m,
                        AvaliacaoId = 8
                    
                    },
                    new
                    {
                        Id = 10,
                        Codigo = Guid.NewGuid(),
                        DataCriacao = DateTime.UtcNow,
                        UsuarioId = 7,
                        Titulo = "Problema com Ar",
                        Descricao = "Lab da COINF precisão limpar o filtro do Ar - nunca funciona corretamente",
                        Nota = 3.50m,
                        AvaliacaoId = 10
                    },
                    new
                    {
                        Id = 11,
                        Codigo = Guid.NewGuid(),
                        DataCriacao = DateTime.UtcNow,
                        UsuarioId = 3,
                        Titulo = "Barulho no lab de redes",
                        Descricao = "Lab de Redes com acustica prejudicada - Barulho da oficina atrapalha a aula",
                        Nota = 2.50m,
                        AvaliacaoId = 11
                    },
                    new
                    {
                        Id = 12,
                        Codigo = Guid.NewGuid(),
                        DataCriacao = DateTime.UtcNow,
                        UsuarioId = 4,
                        Titulo = "Sugestão de bibliográfia",
                        Descricao = "Nenhum Livro de Loiane Groner - acervos desatualizados",
                        Nota = 3m,
                        AvaliacaoId = 6
                    },
                    new
                    {
                        Id = 13,
                        Codigo = Guid.NewGuid(),
                        DataCriacao = DateTime.UtcNow,
                        UsuarioId = 2,Titulo = "Rasuras no livro",
                        Descricao = "Livro de Cálculo com página rasurada - o livro está com rasuras",
                        Nota = 3m,
                        AvaliacaoId = 6
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