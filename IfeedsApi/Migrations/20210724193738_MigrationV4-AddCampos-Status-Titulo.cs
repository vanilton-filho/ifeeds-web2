using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IfeedsApi.Migrations
{
    public partial class MigrationV4AddCamposStatusTitulo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Usuarios",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "RespostasFeedbacks",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<decimal>(
                name: "QuantidadeEstrelas",
                table: "FormulariosAvaliacaos",
                type: "decimal(5,1)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)");

            migrationBuilder.AddColumn<string>(
                name: "Titulo",
                table: "FormulariosAvaliacaos",
                type: "varchar(45)",
                maxLength: 45,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<decimal>(
                name: "MediaAvaliacao",
                table: "Avaliacoes",
                type: "decimal(5,1)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)");

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 37, 36, 978, DateTimeKind.Utc).AddTicks(5938));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 37, 36, 978, DateTimeKind.Utc).AddTicks(7315));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 37, 36, 978, DateTimeKind.Utc).AddTicks(7319));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 37, 36, 978, DateTimeKind.Utc).AddTicks(7320));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 37, 36, 978, DateTimeKind.Utc).AddTicks(7322));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 37, 36, 978, DateTimeKind.Utc).AddTicks(7324));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 37, 36, 978, DateTimeKind.Utc).AddTicks(7325));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 37, 36, 978, DateTimeKind.Utc).AddTicks(7327));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 37, 36, 978, DateTimeKind.Utc).AddTicks(7328));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 37, 36, 978, DateTimeKind.Utc).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 37, 36, 978, DateTimeKind.Utc).AddTicks(7332));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 37, 36, 978, DateTimeKind.Utc).AddTicks(7334));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 37, 36, 978, DateTimeKind.Utc).AddTicks(7335));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 37, 36, 971, DateTimeKind.Utc).AddTicks(3935));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 37, 36, 971, DateTimeKind.Utc).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 37, 36, 971, DateTimeKind.Utc).AddTicks(4693));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 37, 36, 971, DateTimeKind.Utc).AddTicks(4694));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 37, 36, 971, DateTimeKind.Utc).AddTicks(4696));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 37, 36, 971, DateTimeKind.Utc).AddTicks(4697));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 37, 36, 971, DateTimeKind.Utc).AddTicks(4698));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 37, 36, 971, DateTimeKind.Utc).AddTicks(4700));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 37, 36, 971, DateTimeKind.Utc).AddTicks(4701));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 37, 36, 971, DateTimeKind.Utc).AddTicks(4702));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 37, 36, 971, DateTimeKind.Utc).AddTicks(4704));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 37, 36, 978, DateTimeKind.Utc).AddTicks(5636));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 37, 36, 978, DateTimeKind.Utc).AddTicks(5655));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 37, 36, 978, DateTimeKind.Utc).AddTicks(5657));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 37, 36, 978, DateTimeKind.Utc).AddTicks(5658));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 37, 36, 978, DateTimeKind.Utc).AddTicks(5662));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 37, 36, 978, DateTimeKind.Utc).AddTicks(5663));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 37, 36, 969, DateTimeKind.Utc).AddTicks(3258));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 37, 36, 969, DateTimeKind.Utc).AddTicks(4510));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 37, 36, 969, DateTimeKind.Utc).AddTicks(4515));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 37, 36, 969, DateTimeKind.Utc).AddTicks(4516));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 37, 36, 969, DateTimeKind.Utc).AddTicks(4518));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 37, 36, 969, DateTimeKind.Utc).AddTicks(4520));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 37, 36, 969, DateTimeKind.Utc).AddTicks(4521));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 37, 36, 969, DateTimeKind.Utc).AddTicks(4522));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 37, 36, 969, DateTimeKind.Utc).AddTicks(4524));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 37, 36, 969, DateTimeKind.Utc).AddTicks(4525));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("784708a8-a4de-422c-95a4-b40c597c0c09"), new DateTime(2021, 7, 24, 19, 37, 36, 979, DateTimeKind.Utc).AddTicks(2509) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("1feeec4f-e8c3-4e87-909d-2a5f96b677b4"), new DateTime(2021, 7, 24, 19, 37, 36, 979, DateTimeKind.Utc).AddTicks(3833) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("cf305cb2-83f7-440d-9ba2-61c9483f113b"), new DateTime(2021, 7, 24, 19, 37, 36, 979, DateTimeKind.Utc).AddTicks(3838) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("2586f0b0-1905-41f2-9b88-81c67c59cfc6"), new DateTime(2021, 7, 24, 19, 37, 36, 979, DateTimeKind.Utc).AddTicks(3841) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("3886a03e-7da8-4f6f-9a8f-b4ff12864ed9"), new DateTime(2021, 7, 24, 19, 37, 36, 979, DateTimeKind.Utc).AddTicks(3843) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("9742e4e3-abed-46a6-87c0-d1e92a067caf"), new DateTime(2021, 7, 24, 19, 37, 36, 979, DateTimeKind.Utc).AddTicks(3845) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("776d421c-a912-4d2e-a0df-2c6c48e8a396"), new DateTime(2021, 7, 24, 19, 37, 36, 979, DateTimeKind.Utc).AddTicks(3848) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("5fbde759-d455-49b5-9da1-11053f43e28f"), new DateTime(2021, 7, 24, 19, 37, 36, 979, DateTimeKind.Utc).AddTicks(3863) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("714fc138-f109-44dd-b34d-f008cfbe481f"), new DateTime(2021, 7, 24, 19, 37, 36, 979, DateTimeKind.Utc).AddTicks(3865) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("3415c464-af69-4be5-93d1-bdd06a226746"), new DateTime(2021, 7, 24, 19, 37, 36, 979, DateTimeKind.Utc).AddTicks(3867) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("631ff3cf-ed9e-49f6-a79a-8c628307f27c"), new DateTime(2021, 7, 24, 19, 37, 36, 979, DateTimeKind.Utc).AddTicks(3870) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("a081a6f6-2903-44cc-ad10-a928d4d1f19e"), new DateTime(2021, 7, 24, 19, 37, 36, 979, DateTimeKind.Utc).AddTicks(3872) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("14ea4926-107e-40ff-99ab-d04e6dce3082"), new DateTime(2021, 7, 24, 19, 37, 36, 979, DateTimeKind.Utc).AddTicks(3874) });

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCriacao", "Titulo" },
                values: new object[] { new DateTime(2021, 7, 24, 19, 37, 36, 971, DateTimeKind.Utc).AddTicks(5205), "Banheiro com problema" });

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCriacao", "Titulo" },
                values: new object[] { new DateTime(2021, 7, 24, 19, 37, 36, 971, DateTimeKind.Utc).AddTicks(6381), "Problema no corrimão" });

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataCriacao", "Titulo" },
                values: new object[] { new DateTime(2021, 7, 24, 19, 37, 36, 971, DateTimeKind.Utc).AddTicks(6385), "Dificuldade com TCC" });

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataCriacao", "Titulo" },
                values: new object[] { new DateTime(2021, 7, 24, 19, 37, 36, 971, DateTimeKind.Utc).AddTicks(6386), "Sugestão de Melhoria" });

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataCriacao", "Titulo" },
                values: new object[] { new DateTime(2021, 7, 24, 19, 37, 36, 971, DateTimeKind.Utc).AddTicks(6388), "Elogio ao pessoal da limpeza" });

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataCriacao", "Titulo" },
                values: new object[] { new DateTime(2021, 7, 24, 19, 37, 36, 971, DateTimeKind.Utc).AddTicks(6389), "Problemas com WIFI" });

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DataCriacao", "Titulo" },
                values: new object[] { new DateTime(2021, 7, 24, 19, 37, 36, 971, DateTimeKind.Utc).AddTicks(6391), "Elogio ao Techday" });

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DataCriacao", "Titulo" },
                values: new object[] { new DateTime(2021, 7, 24, 19, 37, 36, 971, DateTimeKind.Utc).AddTicks(6392), "Elogio ao evento" });

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DataCriacao", "Titulo" },
                values: new object[] { new DateTime(2021, 7, 24, 19, 37, 36, 971, DateTimeKind.Utc).AddTicks(6394), "Palestras cansativas na SEMAC" });

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DataCriacao", "Titulo" },
                values: new object[] { new DateTime(2021, 7, 24, 19, 37, 36, 971, DateTimeKind.Utc).AddTicks(6395), "Problema com Ar" });

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DataCriacao", "Titulo" },
                values: new object[] { new DateTime(2021, 7, 24, 19, 37, 36, 971, DateTimeKind.Utc).AddTicks(6397), "Barulho no lab de redes" });

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DataCriacao", "Titulo" },
                values: new object[] { new DateTime(2021, 7, 24, 19, 37, 36, 971, DateTimeKind.Utc).AddTicks(6398), "Sugestão de bibliográfia" });

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DataCriacao", "Titulo" },
                values: new object[] { new DateTime(2021, 7, 24, 19, 37, 36, 971, DateTimeKind.Utc).AddTicks(6399), "Rasuras no livro" });

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCriacao", "Status" },
                values: new object[] { new DateTime(2021, 7, 24, 19, 37, 36, 979, DateTimeKind.Utc).AddTicks(4133), true });

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCriacao", "Status" },
                values: new object[] { new DateTime(2021, 7, 24, 19, 37, 36, 979, DateTimeKind.Utc).AddTicks(5167), true });

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataCriacao", "Status" },
                values: new object[] { new DateTime(2021, 7, 24, 19, 37, 36, 979, DateTimeKind.Utc).AddTicks(5176), true });

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataCriacao", "Status" },
                values: new object[] { new DateTime(2021, 7, 24, 19, 37, 36, 979, DateTimeKind.Utc).AddTicks(5178), true });

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataCriacao", "Status" },
                values: new object[] { new DateTime(2021, 7, 24, 19, 37, 36, 979, DateTimeKind.Utc).AddTicks(5179), true });

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataCriacao", "Status" },
                values: new object[] { new DateTime(2021, 7, 24, 19, 37, 36, 979, DateTimeKind.Utc).AddTicks(5180), true });

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DataCriacao", "Status" },
                values: new object[] { new DateTime(2021, 7, 24, 19, 37, 36, 979, DateTimeKind.Utc).AddTicks(5182), true });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 37, 36, 971, DateTimeKind.Utc).AddTicks(569));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 37, 36, 971, DateTimeKind.Utc).AddTicks(2081));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCriacao", "Status" },
                values: new object[] { new DateTime(2021, 7, 24, 19, 37, 36, 971, DateTimeKind.Utc).AddTicks(2473), true });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCriacao", "Status" },
                values: new object[] { new DateTime(2021, 7, 24, 19, 37, 36, 971, DateTimeKind.Utc).AddTicks(3730), true });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataCriacao", "Status" },
                values: new object[] { new DateTime(2021, 7, 24, 19, 37, 36, 971, DateTimeKind.Utc).AddTicks(3734), true });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataCriacao", "Status" },
                values: new object[] { new DateTime(2021, 7, 24, 19, 37, 36, 971, DateTimeKind.Utc).AddTicks(3735), true });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataCriacao", "Status" },
                values: new object[] { new DateTime(2021, 7, 24, 19, 37, 36, 971, DateTimeKind.Utc).AddTicks(3737), true });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataCriacao", "Status" },
                values: new object[] { new DateTime(2021, 7, 24, 19, 37, 36, 971, DateTimeKind.Utc).AddTicks(3738), true });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DataCriacao", "Status" },
                values: new object[] { new DateTime(2021, 7, 24, 19, 37, 36, 971, DateTimeKind.Utc).AddTicks(3740), true });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DataCriacao", "Status" },
                values: new object[] { new DateTime(2021, 7, 24, 19, 37, 36, 971, DateTimeKind.Utc).AddTicks(3741), true });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DataCriacao", "Status" },
                values: new object[] { new DateTime(2021, 7, 24, 19, 37, 36, 971, DateTimeKind.Utc).AddTicks(3742), true });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DataCriacao", "Status" },
                values: new object[] { new DateTime(2021, 7, 24, 19, 37, 36, 971, DateTimeKind.Utc).AddTicks(3743), true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "RespostasFeedbacks");

            migrationBuilder.DropColumn(
                name: "Titulo",
                table: "FormulariosAvaliacaos");

            migrationBuilder.AlterColumn<decimal>(
                name: "QuantidadeEstrelas",
                table: "FormulariosAvaliacaos",
                type: "decimal(5,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,1)");

            migrationBuilder.AlterColumn<decimal>(
                name: "MediaAvaliacao",
                table: "Avaliacoes",
                type: "decimal(5,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,1)");

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 454, DateTimeKind.Utc).AddTicks(6295));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 454, DateTimeKind.Utc).AddTicks(7874));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 454, DateTimeKind.Utc).AddTicks(7878));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 454, DateTimeKind.Utc).AddTicks(7879));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 454, DateTimeKind.Utc).AddTicks(7881));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 454, DateTimeKind.Utc).AddTicks(7883));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 454, DateTimeKind.Utc).AddTicks(7885));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 454, DateTimeKind.Utc).AddTicks(7888));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 454, DateTimeKind.Utc).AddTicks(7890));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 454, DateTimeKind.Utc).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 454, DateTimeKind.Utc).AddTicks(7892));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 454, DateTimeKind.Utc).AddTicks(7894));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 454, DateTimeKind.Utc).AddTicks(7895));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 447, DateTimeKind.Utc).AddTicks(3245));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 447, DateTimeKind.Utc).AddTicks(3994));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 447, DateTimeKind.Utc).AddTicks(4006));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 447, DateTimeKind.Utc).AddTicks(4007));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 447, DateTimeKind.Utc).AddTicks(4008));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 447, DateTimeKind.Utc).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 447, DateTimeKind.Utc).AddTicks(4011));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 447, DateTimeKind.Utc).AddTicks(4012));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 447, DateTimeKind.Utc).AddTicks(4014));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 447, DateTimeKind.Utc).AddTicks(4015));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 447, DateTimeKind.Utc).AddTicks(4016));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 454, DateTimeKind.Utc).AddTicks(6027));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 454, DateTimeKind.Utc).AddTicks(6045));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 454, DateTimeKind.Utc).AddTicks(6047));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 454, DateTimeKind.Utc).AddTicks(6048));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 454, DateTimeKind.Utc).AddTicks(6050));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 454, DateTimeKind.Utc).AddTicks(6052));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 444, DateTimeKind.Utc).AddTicks(9525));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 445, DateTimeKind.Utc).AddTicks(900));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 445, DateTimeKind.Utc).AddTicks(906));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 445, DateTimeKind.Utc).AddTicks(908));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 445, DateTimeKind.Utc).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 445, DateTimeKind.Utc).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 445, DateTimeKind.Utc).AddTicks(914));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 445, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 445, DateTimeKind.Utc).AddTicks(917));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 445, DateTimeKind.Utc).AddTicks(918));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("db8c3d73-3b23-457c-a528-dab3f4cb10a4"), new DateTime(2021, 7, 24, 19, 22, 28, 455, DateTimeKind.Utc).AddTicks(3894) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("de238d69-ba71-466c-9bbb-86be43e29428"), new DateTime(2021, 7, 24, 19, 22, 28, 455, DateTimeKind.Utc).AddTicks(5463) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("0a988dbd-240e-40a0-8207-4974d37690a2"), new DateTime(2021, 7, 24, 19, 22, 28, 455, DateTimeKind.Utc).AddTicks(5468) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("9417e3c6-cc4b-48f7-b57b-07ed9de78f30"), new DateTime(2021, 7, 24, 19, 22, 28, 455, DateTimeKind.Utc).AddTicks(5471) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("2a182ebe-2b70-4812-9799-0667beddfb96"), new DateTime(2021, 7, 24, 19, 22, 28, 455, DateTimeKind.Utc).AddTicks(5473) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("236f4625-3984-4b4b-88be-f716994e51b9"), new DateTime(2021, 7, 24, 19, 22, 28, 455, DateTimeKind.Utc).AddTicks(5495) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("dd6ce154-ab8c-49f0-acd4-eb127db47e70"), new DateTime(2021, 7, 24, 19, 22, 28, 455, DateTimeKind.Utc).AddTicks(5498) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("18f7a093-7698-4472-9d0c-df043d65de7e"), new DateTime(2021, 7, 24, 19, 22, 28, 455, DateTimeKind.Utc).AddTicks(5501) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("545956c0-8a7d-44dd-bf52-03f0dd0945cc"), new DateTime(2021, 7, 24, 19, 22, 28, 455, DateTimeKind.Utc).AddTicks(5503) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("97057ae6-3c06-44a0-9900-0b8230b209c0"), new DateTime(2021, 7, 24, 19, 22, 28, 455, DateTimeKind.Utc).AddTicks(5505) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("8c9028e7-9dc9-4660-aafa-f9f231319d84"), new DateTime(2021, 7, 24, 19, 22, 28, 455, DateTimeKind.Utc).AddTicks(5508) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("930c6523-f985-4840-8377-017482445b0f"), new DateTime(2021, 7, 24, 19, 22, 28, 455, DateTimeKind.Utc).AddTicks(5510) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("70b57b08-e74e-450a-939c-052de39da2bd"), new DateTime(2021, 7, 24, 19, 22, 28, 455, DateTimeKind.Utc).AddTicks(5512) });

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 447, DateTimeKind.Utc).AddTicks(4439));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 447, DateTimeKind.Utc).AddTicks(5357));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 447, DateTimeKind.Utc).AddTicks(5361));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 447, DateTimeKind.Utc).AddTicks(5362));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 447, DateTimeKind.Utc).AddTicks(5364));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 447, DateTimeKind.Utc).AddTicks(5366));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 447, DateTimeKind.Utc).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 447, DateTimeKind.Utc).AddTicks(5369));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 447, DateTimeKind.Utc).AddTicks(5479));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 447, DateTimeKind.Utc).AddTicks(5481));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 447, DateTimeKind.Utc).AddTicks(5483));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 447, DateTimeKind.Utc).AddTicks(5485));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 447, DateTimeKind.Utc).AddTicks(5487));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 455, DateTimeKind.Utc).AddTicks(5816));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 455, DateTimeKind.Utc).AddTicks(6796));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 455, DateTimeKind.Utc).AddTicks(6799));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 455, DateTimeKind.Utc).AddTicks(6801));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 455, DateTimeKind.Utc).AddTicks(6802));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 455, DateTimeKind.Utc).AddTicks(6803));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 455, DateTimeKind.Utc).AddTicks(6805));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 447, DateTimeKind.Utc).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 447, DateTimeKind.Utc).AddTicks(1680));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 447, DateTimeKind.Utc).AddTicks(2014));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 447, DateTimeKind.Utc).AddTicks(3072));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 447, DateTimeKind.Utc).AddTicks(3078));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 447, DateTimeKind.Utc).AddTicks(3080));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 447, DateTimeKind.Utc).AddTicks(3081));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 447, DateTimeKind.Utc).AddTicks(3083));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 447, DateTimeKind.Utc).AddTicks(3084));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 447, DateTimeKind.Utc).AddTicks(3086));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 447, DateTimeKind.Utc).AddTicks(3087));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 22, 28, 447, DateTimeKind.Utc).AddTicks(3089));
        }
    }
}
