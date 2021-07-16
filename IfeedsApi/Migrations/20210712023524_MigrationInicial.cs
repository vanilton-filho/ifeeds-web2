﻿using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IfeedsApi.Migrations
{
    public partial class MigrationInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Campus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataCriacao = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValueSql: "(utc_timestamp())"),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campus", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataCriacao = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValueSql: "(utc_timestamp())"),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Contatos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefone = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataCriacao = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValueSql: "(utc_timestamp())"),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contatos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "FormulariosAvaliacaos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    QuantidadeEstrelas = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValueSql: "(utc_timestamp())"),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormulariosAvaliacaos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Tipo = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataCriacao = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValueSql: "(utc_timestamp())"),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Avaliacoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Titulo = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MediaAvaliacao = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValueSql: "(utc_timestamp())"),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CategoriaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Avaliacoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Avaliacoes_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CampusFormularioAvaliacao",
                columns: table => new
                {
                    CampusId = table.Column<int>(type: "int", nullable: false),
                    FormulariosAvaliacoesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampusFormularioAvaliacao", x => new { x.CampusId, x.FormulariosAvaliacoesId });
                    table.ForeignKey(
                        name: "FK_CampusFormularioAvaliacao_Campus_CampusId",
                        column: x => x.CampusId,
                        principalTable: "Campus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CampusFormularioAvaliacao_FormulariosAvaliacaos_FormulariosA~",
                        column: x => x.FormulariosAvaliacoesId,
                        principalTable: "FormulariosAvaliacaos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Matricula = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nome = table.Column<string>(type: "varchar(280)", maxLength: 280, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataCriacao = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValueSql: "(utc_timestamp())"),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    ContatoId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuarios_Contatos_ContatoId",
                        column: x => x.ContatoId,
                        principalTable: "Contatos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Usuarios_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Codigo = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false, defaultValueSql: "(UUID())")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataCriacao = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValueSql: "(utc_timestamp())"),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    AvaliacaoId = table.Column<int>(type: "int", nullable: false),
                    FormularioAvaliacaoId = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Feedbacks_Avaliacoes_AvaliacaoId",
                        column: x => x.AvaliacaoId,
                        principalTable: "Avaliacoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Feedbacks_FormulariosAvaliacaos_FormularioAvaliacaoId",
                        column: x => x.FormularioAvaliacaoId,
                        principalTable: "FormulariosAvaliacaos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Feedbacks_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RespostasFeedbacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Resposta = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataCriacao = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValueSql: "(utc_timestamp())"),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    FeedbackId = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RespostasFeedbacks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RespostasFeedbacks_Feedbacks_FeedbackId",
                        column: x => x.FeedbackId,
                        principalTable: "Feedbacks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RespostasFeedbacks_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Campus",
                columns: new[] { "Id", "DataAtualizacao", "Nome" },
                values: new object[,]
                {
                    { 1, null, "IFS-Campus Lagarto" },
                    { 10, null, "IFS-Campus Socorro" },
                    { 9, null, "IFS-Campus Propriá" },
                    { 8, null, "IFS-Campus Poço Redondo" },
                    { 7, null, "IFS-Campus Tobias Barreto" },
                    { 11, null, "IFS-Educação a Distancia" },
                    { 5, null, "IFS-Campus Itabaiana" },
                    { 4, null, "IFS-Campus São Cristovão" },
                    { 3, null, "IFS-Campus Estância" },
                    { 2, null, "IFS-Campus Glória" },
                    { 6, null, "IFS-Campus Aracaju" }
                });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "Id", "DataAtualizacao", "Nome" },
                values: new object[,]
                {
                    { 1, null, "Infraestrutura" },
                    { 2, null, "Coordenação" },
                    { 3, null, "Serviços" },
                    { 4, null, "Eventos" },
                    { 5, null, "Laboratórios" },
                    { 6, null, "Biblioteca" }
                });

            migrationBuilder.InsertData(
                table: "Contatos",
                columns: new[] { "Id", "DataAtualizacao", "Email", "Telefone" },
                values: new object[,]
                {
                    { 7, null, "rafaela@email.com", "7199999999999" },
                    { 10, null, "chico@email.com", "71999998888" },
                    { 9, null, "vanilton@email.com", "71999977777" },
                    { 8, null, "kaiki@email.com", "71999666666" },
                    { 6, null, "carlos@email.com", "71999995555" },
                    { 4, null, "jose@email.com", "7199944444" },
                    { 3, null, "maria@email.com", "71999999999" },
                    { 2, null, "fulano@email.com", "79999999999" },
                    { 1, null, "cicrano@email.com", "79999999999" },
                    { 5, null, "joao@email.com", "7199933333" }
                });

            migrationBuilder.InsertData(
                table: "FormulariosAvaliacaos",
                columns: new[] { "Id", "DataAtualizacao", "Descricao", "QuantidadeEstrelas" },
                values: new object[,]
                {
                    { 6, null, "Problemas com o Wifi do Campus - Internet lenta o que dificulta o acesso", 4m },
                    { 11, null, "Lab de Redes com acustica prejudicada - Barulho da oficina atrapalha a aula", 2.50m },
                    { 10, null, "Lab da COINF precisão limpar o filtro do Ar - nunca funciona corretamente", 3.50m },
                    { 9, null, "Semana Academica Algumas Palestras Massantes - palestras muito longas e cansativas", 2.50m },
                    { 8, null, "Semana Academica Divertida - Evento top", 4.50m },
                    { 7, null, "Ifs Techday Top - Evento maravilhoso", 5m },
                    { 5, null, "Pessoal da Limpeza Top - Campus sempre muito bem conservado", 5m },
                    { 4, null, "Melhorias no Processo de Atendimento -  Deveriam automatizar mais os processos", 3m },
                    { 3, null, "Demora para Aprovar Máteria de TCC 1 - Estou com mais de um mes aguardando aprovação", 2.50m },
                    { 2, null, "Corrimão da Escada da COINF Descascando. Me cortei", 3m },
                    { 1, null, "Banheiro com problema espelho quebrado", 3.50m },
                    { 12, null, "Nenhum Livro de Loiane Groner - acervos desatualizados", 3m },
                    { 13, null, "Livro de Cálculo com página rasurada - o livro está com rasuras", 3m }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "DataAtualizacao", "Tipo" },
                values: new object[,]
                {
                    { 1, null, "ADMIN" },
                    { 2, null, "USER" }
                });

            migrationBuilder.InsertData(
                table: "Avaliacoes",
                columns: new[] { "Id", "CategoriaId", "DataAtualizacao", "MediaAvaliacao", "Titulo" },
                values: new object[,]
                {
                    { 1, 1, null, 4.5m, "Banheiro Com Problema" },
                    { 13, 6, null, 3.5m, "Livro de Cálculo com página rasurada" },
                    { 12, 6, null, 2.5m, "Nenhum Livro de Loiane Groner" },
                    { 11, 5, null, 2.5m, "Lab de Redes com acustica prejudicada" },
                    { 10, 5, null, 3.5m, "Lab da COINF precisão limpar o filtro do Ar" },
                    { 8, 4, null, 4.5m, "Semana Academica Divertida" },
                    { 9, 4, null, 3.0m, "Semana Academica Algumas Palestras Massantes" },
                    { 6, 3, null, 2.5m, "Problemas com o Wifi do Campus" },
                    { 5, 3, null, 5.0m, "Pessoal da Limpeza Top" },
                    { 4, 2, null, 4.5m, "Melhorias no Processo de Atendimento" },
                    { 3, 2, null, 3.5m, "Demora para Aprovar Máteria de TCC 1" },
                    { 2, 1, null, 4.5m, "Corrimão da Escada da COINF Descascando" },
                    { 7, 4, null, 5.0m, "Ifs Techday Top" }
                });

            migrationBuilder.InsertData(
                table: "CampusFormularioAvaliacao",
                columns: new[] { "CampusId", "FormulariosAvaliacoesId" },
                values: new object[,]
                {
                    { 6, 7 },
                    { 9, 10 },
                    { 10, 9 },
                    { 8, 8 },
                    { 7, 6 },
                    { 3, 4 },
                    { 4, 3 },
                    { 2, 2 },
                    { 1, 1 },
                    { 5, 5 }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "ContatoId", "DataAtualizacao", "Matricula", "Nome", "RoleId" },
                values: new object[,]
                {
                    { 9, 9, null, "20266654", "Vanilton", 2 },
                    { 1, 1, null, "20211897238", "Cicrano", 1 },
                    { 2, 2, null, "21203554", "Fulano", 2 },
                    { 3, 3, null, "20215888854", "Maria", 2 },
                    { 4, 4, null, "2021777554", "Jose", 2 },
                    { 5, 5, null, "2021533554", "Joao", 2 },
                    { 6, 6, null, "20215554", "Carlos", 2 },
                    { 7, 7, null, "20213554", "Rafaela", 2 },
                    { 8, 8, null, "202156954", "Kaiki", 2 },
                    { 10, 10, null, "2021585641", "Chico", 2 }
                });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "AvaliacaoId", "DataAtualizacao", "FormularioAvaliacaoId", "UsuarioId" },
                values: new object[,]
                {
                    { 2, 2, null, 2, 1 },
                    { 1, 1, null, 1, 2 },
                    { 13, 8, null, 12, 2 },
                    { 4, 4, null, 4, 3 },
                    { 5, 5, null, 5, 3 },
                    { 11, 4, null, 11, 3 },
                    { 3, 3, null, 3, 4 },
                    { 12, 2, null, 13, 4 },
                    { 7, 7, null, 7, 5 },
                    { 10, 8, null, 10, 7 },
                    { 6, 6, null, 6, 8 },
                    { 8, 2, null, 8, 9 },
                    { 9, 5, null, 9, 10 }
                });

            migrationBuilder.InsertData(
                table: "RespostasFeedbacks",
                columns: new[] { "Id", "DataAtualizacao", "FeedbackId", "Resposta", "UsuarioId" },
                values: new object[,]
                {
                    { 1, null, 2, "Obrigado, iremos resolver", 1 },
                    { 4, null, 1, "Oh, não estavamos cientes dessa situação", 1 },
                    { 3, null, 4, "Resolução esta em andamento", 1 },
                    { 2, null, 5, "Obrigado, Sim, eles são maravilhosos", 1 },
                    { 6, null, 6, "Repassando para os resposáveis", 1 },
                    { 5, null, 8, "Que bom que está gostando, aproveite", 1 },
                    { 7, null, 8, "Obrigado pelo seu feedback", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Avaliacoes_CategoriaId",
                table: "Avaliacoes",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Campus_Nome",
                table: "Campus",
                column: "Nome",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CampusFormularioAvaliacao_FormulariosAvaliacoesId",
                table: "CampusFormularioAvaliacao",
                column: "FormulariosAvaliacoesId");

            migrationBuilder.CreateIndex(
                name: "IX_Categorias_Nome",
                table: "Categorias",
                column: "Nome",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contatos_Email",
                table: "Contatos",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_AvaliacaoId",
                table: "Feedbacks",
                column: "AvaliacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_FormularioAvaliacaoId",
                table: "Feedbacks",
                column: "FormularioAvaliacaoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_UsuarioId",
                table: "Feedbacks",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_RespostasFeedbacks_FeedbackId",
                table: "RespostasFeedbacks",
                column: "FeedbackId");

            migrationBuilder.CreateIndex(
                name: "IX_RespostasFeedbacks_UsuarioId",
                table: "RespostasFeedbacks",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_Tipo",
                table: "Roles",
                column: "Tipo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_ContatoId",
                table: "Usuarios",
                column: "ContatoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_Matricula",
                table: "Usuarios",
                column: "Matricula",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_RoleId",
                table: "Usuarios",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CampusFormularioAvaliacao");

            migrationBuilder.DropTable(
                name: "RespostasFeedbacks");

            migrationBuilder.DropTable(
                name: "Campus");

            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "Avaliacoes");

            migrationBuilder.DropTable(
                name: "FormulariosAvaliacaos");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Contatos");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}