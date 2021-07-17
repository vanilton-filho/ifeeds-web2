using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IfeedsApi.Migrations
{
    public partial class MigrationV1 : Migration
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
                    DataCriacao = table.Column<DateTime>(type: "datetime(6)", nullable: false),
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
                    DataCriacao = table.Column<DateTime>(type: "datetime(6)", nullable: false),
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
                    Senha = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataCriacao = table.Column<DateTime>(type: "datetime(6)", nullable: false),
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
                    Codigo = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    DataCriacao = table.Column<DateTime>(type: "datetime(6)", nullable: false),
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
                    DataCriacao = table.Column<DateTime>(type: "datetime(6)", nullable: false),
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
                columns: new[] { "Id", "DataAtualizacao", "DataCriacao", "Nome" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(4840), "IFS-Campus Lagarto" },
                    { 10, null, new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(5426), "IFS-Campus Socorro" },
                    { 9, null, new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(5424), "IFS-Campus Propriá" },
                    { 8, null, new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(5423), "IFS-Campus Poço Redondo" },
                    { 7, null, new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(5421), "IFS-Campus Tobias Barreto" },
                    { 11, null, new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(5427), "IFS-Educação a Distancia" },
                    { 5, null, new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(5419), "IFS-Campus Itabaiana" },
                    { 4, null, new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(5418), "IFS-Campus São Cristovão" },
                    { 3, null, new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(5417), "IFS-Campus Estância" },
                    { 2, null, new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(5414), "IFS-Campus Glória" },
                    { 6, null, new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(5420), "IFS-Campus Aracaju" }
                });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "Id", "DataAtualizacao", "DataCriacao", "Nome" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(517), "Infraestrutura" },
                    { 2, null, new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(535), "Coordenação" },
                    { 3, null, new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(536), "Serviços" },
                    { 4, null, new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(537), "Eventos" },
                    { 5, null, new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(539), "Laboratórios" },
                    { 6, null, new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(540), "Biblioteca" }
                });

            migrationBuilder.InsertData(
                table: "Contatos",
                columns: new[] { "Id", "DataAtualizacao", "DataCriacao", "Email", "Telefone" },
                values: new object[,]
                {
                    { 7, null, new DateTime(2021, 7, 17, 19, 0, 29, 408, DateTimeKind.Utc).AddTicks(205), "rafaela@email.com", "7199999999999" },
                    { 10, null, new DateTime(2021, 7, 17, 19, 0, 29, 408, DateTimeKind.Utc).AddTicks(208), "chico@email.com", "71999998888" },
                    { 9, null, new DateTime(2021, 7, 17, 19, 0, 29, 408, DateTimeKind.Utc).AddTicks(207), "vanilton@email.com", "71999977777" },
                    { 8, null, new DateTime(2021, 7, 17, 19, 0, 29, 408, DateTimeKind.Utc).AddTicks(206), "kaiki@email.com", "71999666666" },
                    { 6, null, new DateTime(2021, 7, 17, 19, 0, 29, 408, DateTimeKind.Utc).AddTicks(204), "carlos@email.com", "71999995555" },
                    { 4, null, new DateTime(2021, 7, 17, 19, 0, 29, 408, DateTimeKind.Utc).AddTicks(201), "jose@email.com", "7199944444" },
                    { 3, null, new DateTime(2021, 7, 17, 19, 0, 29, 408, DateTimeKind.Utc).AddTicks(200), "maria@email.com", "71999999999" },
                    { 2, null, new DateTime(2021, 7, 17, 19, 0, 29, 408, DateTimeKind.Utc).AddTicks(195), "fulano@email.com", "79999999999" },
                    { 1, null, new DateTime(2021, 7, 17, 19, 0, 29, 407, DateTimeKind.Utc).AddTicks(8930), "cicrano@email.com", "79999999999" },
                    { 5, null, new DateTime(2021, 7, 17, 19, 0, 29, 408, DateTimeKind.Utc).AddTicks(202), "joao@email.com", "7199933333" }
                });

            migrationBuilder.InsertData(
                table: "FormulariosAvaliacaos",
                columns: new[] { "Id", "DataAtualizacao", "DataCriacao", "Descricao", "QuantidadeEstrelas" },
                values: new object[,]
                {
                    { 6, null, new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(6485), "Problemas com o Wifi do Campus - Internet lenta o que dificulta o acesso", 4m },
                    { 11, null, new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(6491), "Lab de Redes com acustica prejudicada - Barulho da oficina atrapalha a aula", 2.50m },
                    { 10, null, new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(6490), "Lab da COINF precisão limpar o filtro do Ar - nunca funciona corretamente", 3.50m },
                    { 9, null, new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(6489), "Semana Academica Algumas Palestras Massantes - palestras muito longas e cansativas", 2.50m },
                    { 8, null, new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(6488), "Semana Academica Divertida - Evento top", 4.50m },
                    { 7, null, new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(6487), "Ifs Techday Top - Evento maravilhoso", 5m },
                    { 5, null, new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(6484), "Pessoal da Limpeza Top - Campus sempre muito bem conservado", 5m },
                    { 4, null, new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(6483), "Melhorias no Processo de Atendimento -  Deveriam automatizar mais os processos", 3m },
                    { 3, null, new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(6482), "Demora para Aprovar Máteria de TCC 1 - Estou com mais de um mes aguardando aprovação", 2.50m },
                    { 2, null, new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(6479), "Corrimão da Escada da COINF Descascando. Me cortei", 3m },
                    { 1, null, new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(5762), "Banheiro com problema espelho quebrado", 3.50m },
                    { 12, null, new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(6493), "Nenhum Livro de Loiane Groner - acervos desatualizados", 3m },
                    { 13, null, new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(6494), "Livro de Cálculo com página rasurada - o livro está com rasuras", 3m }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "DataAtualizacao", "DataCriacao", "Tipo" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(2809), "ADMIN" },
                    { 2, null, new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(3627), "USER" }
                });

            migrationBuilder.InsertData(
                table: "Avaliacoes",
                columns: new[] { "Id", "CategoriaId", "DataAtualizacao", "DataCriacao", "MediaAvaliacao", "Titulo" },
                values: new object[,]
                {
                    { 1, 1, null, new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(743), 4.5m, "Banheiro Com Problema" },
                    { 13, 6, null, new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(1688), 3.5m, "Livro de Cálculo com página rasurada" },
                    { 12, 6, null, new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(1686), 2.5m, "Nenhum Livro de Loiane Groner" },
                    { 11, 5, null, new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(1685), 2.5m, "Lab de Redes com acustica prejudicada" },
                    { 10, 5, null, new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(1684), 3.5m, "Lab da COINF precisão limpar o filtro do Ar" },
                    { 8, 4, null, new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(1681), 4.5m, "Semana Academica Divertida" },
                    { 9, 4, null, new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(1683), 3.0m, "Semana Academica Algumas Palestras Massantes" },
                    { 6, 3, null, new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(1679), 2.5m, "Problemas com o Wifi do Campus" },
                    { 5, 3, null, new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(1678), 5.0m, "Pessoal da Limpeza Top" },
                    { 4, 2, null, new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(1677), 4.5m, "Melhorias no Processo de Atendimento" },
                    { 3, 2, null, new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(1676), 3.5m, "Demora para Aprovar Máteria de TCC 1" },
                    { 2, 1, null, new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(1673), 4.5m, "Corrimão da Escada da COINF Descascando" },
                    { 7, 4, null, new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(1680), 5.0m, "Ifs Techday Top" }
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
                columns: new[] { "Id", "ContatoId", "DataAtualizacao", "DataCriacao", "Matricula", "Nome", "RoleId", "Senha" },
                values: new object[,]
                {
                    { 9, 9, null, new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(4717), "20266654", "Vanilton", 2, "12346545745" },
                    { 1, 1, null, new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(3868), "20211897238", "Cicrano", 1, "123789745" },
                    { 2, 2, null, new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(4705), "21203554", "Fulano", 2, "12565735" },
                    { 3, 3, null, new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(4708), "20215888854", "Maria", 2, "145" },
                    { 4, 4, null, new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(4710), "2021777554", "Jose", 2, "123145" },
                    { 5, 5, null, new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(4712), "2021533554", "Joao", 2, "12312345" },
                    { 6, 6, null, new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(4713), "20215554", "Carlos", 2, "123452139" },
                    { 7, 7, null, new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(4714), "20213554", "Rafaela", 2, "12367645" },
                    { 8, 8, null, new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(4716), "202156954", "Kaiki", 2, "124356345" },
                    { 10, 10, null, new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(4718), "2021585641", "Chico", 2, "123454645" }
                });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "AvaliacaoId", "Codigo", "DataAtualizacao", "DataCriacao", "FormularioAvaliacaoId", "UsuarioId" },
                values: new object[,]
                {
                    { 2, 2, new Guid("fd4e3c65-4df1-435e-8396-c2042e3561cc"), null, new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(7194), 2, 1 },
                    { 1, 1, new Guid("2e8e624e-fa8a-451b-aa8f-4f557d6da49a"), null, new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(6356), 1, 2 },
                    { 13, 8, new Guid("a114a4e3-41b0-4917-b2dc-9eb9171ca90d"), null, new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(7232), 12, 2 },
                    { 4, 4, new Guid("2688f73b-b53f-4aa0-a58a-366bfded5868"), null, new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(7201), 4, 3 },
                    { 5, 5, new Guid("81f76f55-f8fc-43b5-83f2-0748c4c61382"), null, new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(7214), 5, 3 },
                    { 11, 4, new Guid("4d69868b-4aeb-4c7c-a17c-e1b71ea6ad21"), null, new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(7225), 11, 3 },
                    { 3, 3, new Guid("f65fac06-8eab-4b6f-9189-fbf0b9e469ed"), null, new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(7199), 3, 4 },
                    { 12, 2, new Guid("debb667c-0472-4dc1-852b-a616aca99422"), null, new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(7226), 13, 4 },
                    { 7, 7, new Guid("2076adfd-e6bb-4e62-8282-e11295443711"), null, new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(7218), 7, 5 },
                    { 10, 8, new Guid("45d9357d-c889-4eed-8ede-4cbebe52c17a"), null, new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(7223), 10, 7 },
                    { 6, 6, new Guid("264b7ce5-7cdb-4d9b-a978-b3958eec0af3"), null, new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(7216), 6, 8 },
                    { 8, 2, new Guid("7036489b-6ed2-402f-9254-92a71fb261d2"), null, new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(7220), 8, 9 },
                    { 9, 5, new Guid("5652a8e0-e7f0-411e-a2d7-08cbbaf2d19a"), null, new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(7221), 9, 10 }
                });

            migrationBuilder.InsertData(
                table: "RespostasFeedbacks",
                columns: new[] { "Id", "DataAtualizacao", "DataCriacao", "FeedbackId", "Resposta", "UsuarioId" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(7440), 2, "Obrigado, iremos resolver", 1 },
                    { 4, null, new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(8130), 1, "Oh, não estavamos cientes dessa situação", 1 },
                    { 3, null, new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(8129), 4, "Resolução esta em andamento", 1 },
                    { 2, null, new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(8127), 5, "Obrigado, Sim, eles são maravilhosos", 1 },
                    { 6, null, new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(8133), 6, "Repassando para os resposáveis", 1 },
                    { 5, null, new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(8132), 8, "Que bom que está gostando, aproveite", 1 },
                    { 7, null, new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(8134), 8, "Obrigado pelo seu feedback", 1 }
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
