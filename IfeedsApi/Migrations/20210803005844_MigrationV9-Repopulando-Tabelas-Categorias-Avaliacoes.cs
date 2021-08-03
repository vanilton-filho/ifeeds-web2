using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IfeedsApi.Migrations
{
    public partial class MigrationV9RepopulandoTabelasCategoriasAvaliacoes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCriacao", "Titulo" },
                values: new object[] { new DateTime(2021, 8, 3, 0, 58, 42, 790, DateTimeKind.Utc).AddTicks(4182), "Banheiro" });

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCriacao", "Titulo" },
                values: new object[] { new DateTime(2021, 8, 3, 0, 58, 42, 790, DateTimeKind.Utc).AddTicks(5339), "Escada COINF" });

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataCriacao", "Titulo" },
                values: new object[] { new DateTime(2021, 8, 3, 0, 58, 42, 790, DateTimeKind.Utc).AddTicks(5345), "COINF" });

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataCriacao", "Titulo" },
                values: new object[] { new DateTime(2021, 8, 3, 0, 58, 42, 790, DateTimeKind.Utc).AddTicks(5347), "GEN" });

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataCriacao", "Titulo" },
                values: new object[] { new DateTime(2021, 8, 3, 0, 58, 42, 790, DateTimeKind.Utc).AddTicks(5349), "Limpeza" });

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CampusId", "DataCriacao", "Titulo" },
                values: new object[] { 1, new DateTime(2021, 8, 3, 0, 58, 42, 790, DateTimeKind.Utc).AddTicks(5350), "Biblioteca" });

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DataCriacao", "Titulo" },
                values: new object[] { new DateTime(2021, 8, 3, 0, 58, 42, 790, DateTimeKind.Utc).AddTicks(5351), "Ifs Techday" });

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DataCriacao", "Titulo" },
                values: new object[] { new DateTime(2021, 8, 3, 0, 58, 42, 790, DateTimeKind.Utc).AddTicks(5353), "Semana Acadêmica" });

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DataCriacao", "Titulo" },
                values: new object[] { new DateTime(2021, 8, 3, 0, 58, 42, 790, DateTimeKind.Utc).AddTicks(5354), "Ifs Dev Conf" });

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DataCriacao", "Titulo" },
                values: new object[] { new DateTime(2021, 8, 3, 0, 58, 42, 790, DateTimeKind.Utc).AddTicks(5356), "Lab da COINF" });

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DataCriacao", "Titulo" },
                values: new object[] { new DateTime(2021, 8, 3, 0, 58, 42, 790, DateTimeKind.Utc).AddTicks(5357), "Lab de Redes" });

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CategoriaId", "DataCriacao", "Titulo" },
                values: new object[] { 1, new DateTime(2021, 8, 3, 0, 58, 42, 790, DateTimeKind.Utc).AddTicks(5358), "Refeitório" });

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CategoriaId", "DataCriacao", "Titulo" },
                values: new object[] { 1, new DateTime(2021, 8, 3, 0, 58, 42, 790, DateTimeKind.Utc).AddTicks(5360), "Quadra Poliesportiva" });

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 3, 0, 58, 42, 789, DateTimeKind.Utc).AddTicks(8466));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 3, 0, 58, 42, 790, DateTimeKind.Utc).AddTicks(999));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 3, 0, 58, 42, 790, DateTimeKind.Utc).AddTicks(1009));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 3, 0, 58, 42, 790, DateTimeKind.Utc).AddTicks(1010));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 3, 0, 58, 42, 790, DateTimeKind.Utc).AddTicks(1015));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 3, 0, 58, 42, 790, DateTimeKind.Utc).AddTicks(1016));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 3, 0, 58, 42, 790, DateTimeKind.Utc).AddTicks(1036));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 3, 0, 58, 42, 790, DateTimeKind.Utc).AddTicks(1038));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 3, 0, 58, 42, 790, DateTimeKind.Utc).AddTicks(1039));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 3, 0, 58, 42, 790, DateTimeKind.Utc).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 3, 0, 58, 42, 790, DateTimeKind.Utc).AddTicks(1043));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 3, 0, 58, 42, 790, DateTimeKind.Utc).AddTicks(3914));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 3, 0, 58, 42, 790, DateTimeKind.Utc).AddTicks(3918));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 3, 0, 58, 42, 790, DateTimeKind.Utc).AddTicks(3919));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 3, 0, 58, 42, 790, DateTimeKind.Utc).AddTicks(3920));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 3, 0, 58, 42, 790, DateTimeKind.Utc).AddTicks(3923));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 3, 0, 58, 40, 250, DateTimeKind.Utc).AddTicks(4288));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 3, 0, 58, 40, 250, DateTimeKind.Utc).AddTicks(5529));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 3, 0, 58, 40, 250, DateTimeKind.Utc).AddTicks(5533));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 3, 0, 58, 40, 250, DateTimeKind.Utc).AddTicks(5534));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 3, 0, 58, 40, 250, DateTimeKind.Utc).AddTicks(5536));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 3, 0, 58, 40, 250, DateTimeKind.Utc).AddTicks(5537));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 3, 0, 58, 40, 250, DateTimeKind.Utc).AddTicks(5538));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 3, 0, 58, 40, 250, DateTimeKind.Utc).AddTicks(5540));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 3, 0, 58, 40, 250, DateTimeKind.Utc).AddTicks(5541));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 3, 0, 58, 40, 250, DateTimeKind.Utc).AddTicks(5543));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("f54af9b8-9441-4bce-8c99-a0a4894cd326"), new DateTime(2021, 8, 3, 0, 58, 42, 790, DateTimeKind.Utc).AddTicks(5699) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("885bb372-5f8f-437b-930a-e5bb1702d362"), new DateTime(2021, 8, 3, 0, 58, 42, 790, DateTimeKind.Utc).AddTicks(6977) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("810876d2-6f77-49ed-90d9-5f7cbe1f1e54"), new DateTime(2021, 8, 3, 0, 58, 42, 790, DateTimeKind.Utc).AddTicks(6982) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("44f38606-b69f-4e9c-b05b-2712ab2a89e5"), new DateTime(2021, 8, 3, 0, 58, 42, 790, DateTimeKind.Utc).AddTicks(6985) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("7e591aa2-2b27-432e-9914-f4a897c5e6b3"), new DateTime(2021, 8, 3, 0, 58, 42, 790, DateTimeKind.Utc).AddTicks(6987) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("c5e7abea-18ef-48d4-985b-76772fe3b4b2"), new DateTime(2021, 8, 3, 0, 58, 42, 790, DateTimeKind.Utc).AddTicks(6990) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("bffd52eb-4eef-4ee3-9d4a-995e0b69ffd8"), new DateTime(2021, 8, 3, 0, 58, 42, 790, DateTimeKind.Utc).AddTicks(7008) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("b702668b-dee3-4fc9-9da1-c6eb6cbdbe8f"), new DateTime(2021, 8, 3, 0, 58, 42, 790, DateTimeKind.Utc).AddTicks(7012) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("4513da67-5e9d-4b47-a9fd-8be1c395f263"), new DateTime(2021, 8, 3, 0, 58, 42, 790, DateTimeKind.Utc).AddTicks(7014) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("ccd10b7b-9d29-44e2-bcc6-683537940773"), new DateTime(2021, 8, 3, 0, 58, 42, 790, DateTimeKind.Utc).AddTicks(7016) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("9ad31258-37a1-47ab-b037-2d742fef68f7"), new DateTime(2021, 8, 3, 0, 58, 42, 790, DateTimeKind.Utc).AddTicks(7019) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("466512a3-c95b-4270-9869-020243dec607"), new DateTime(2021, 8, 3, 0, 58, 42, 790, DateTimeKind.Utc).AddTicks(7022) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("29df9bd6-4672-4d57-a9bd-39b8178906e9"), new DateTime(2021, 8, 3, 0, 58, 42, 790, DateTimeKind.Utc).AddTicks(7025) });

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 3, 0, 58, 42, 790, DateTimeKind.Utc).AddTicks(2002));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 3, 0, 58, 42, 790, DateTimeKind.Utc).AddTicks(3512));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 3, 0, 58, 42, 790, DateTimeKind.Utc).AddTicks(3517));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 3, 0, 58, 42, 790, DateTimeKind.Utc).AddTicks(3519));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 3, 0, 58, 42, 790, DateTimeKind.Utc).AddTicks(3521));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 3, 0, 58, 42, 790, DateTimeKind.Utc).AddTicks(3522));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 3, 0, 58, 42, 790, DateTimeKind.Utc).AddTicks(3524));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 3, 0, 58, 42, 790, DateTimeKind.Utc).AddTicks(3525));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 3, 0, 58, 42, 790, DateTimeKind.Utc).AddTicks(3533));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 3, 0, 58, 42, 790, DateTimeKind.Utc).AddTicks(3534));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 3, 0, 58, 42, 790, DateTimeKind.Utc).AddTicks(3536));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 3, 0, 58, 42, 790, DateTimeKind.Utc).AddTicks(3537));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 3, 0, 58, 42, 790, DateTimeKind.Utc).AddTicks(3538));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 3, 0, 58, 42, 790, DateTimeKind.Utc).AddTicks(7328));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 3, 0, 58, 42, 790, DateTimeKind.Utc).AddTicks(8282));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 3, 0, 58, 42, 790, DateTimeKind.Utc).AddTicks(8285));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 3, 0, 58, 42, 790, DateTimeKind.Utc).AddTicks(8287));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 3, 0, 58, 42, 790, DateTimeKind.Utc).AddTicks(8289));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 3, 0, 58, 42, 790, DateTimeKind.Utc).AddTicks(8290));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 3, 0, 58, 42, 790, DateTimeKind.Utc).AddTicks(8291));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 3, 0, 58, 40, 252, DateTimeKind.Utc).AddTicks(585));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 3, 0, 58, 40, 252, DateTimeKind.Utc).AddTicks(2956));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 3, 0, 58, 40, 518, DateTimeKind.Utc).AddTicks(1560), "$2a$11$KKXVNleMbo9EWIA8IrNTiOZbphw7R0JkCYmhwYlla9491FiJPXgW." });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 3, 0, 58, 40, 768, DateTimeKind.Utc).AddTicks(4744), "$2a$11$UwtTL3eJZO.Qd2hkj0p5JeBVppP5e/gAtRshp/R066xtPAfSZsl92" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 3, 0, 58, 41, 18, DateTimeKind.Utc).AddTicks(8125), "$2a$11$JPgyvrnLJo3Mu5liend0o.jJBAcsNkq544o0yiY7NpRH36uIHpQG." });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 3, 0, 58, 41, 269, DateTimeKind.Utc).AddTicks(6160), "$2a$11$uFVMmWgZggysSix04QBqb.QLoDcOd09P7X31Pq.nc6ugiZELu2Lgq" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 3, 0, 58, 41, 519, DateTimeKind.Utc).AddTicks(8178), "$2a$11$kcIyUWXkoXni4.AQ2ck9xeEuo3/vZcCv4okHlKq1oDeTUzR3qsJse" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 3, 0, 58, 41, 773, DateTimeKind.Utc).AddTicks(4300), "$2a$11$i8oWix56l8.92ndqdrF1c.AT15NNGxsaZ2WkNsnAFgpm/3jqtxwya" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 3, 0, 58, 42, 25, DateTimeKind.Utc).AddTicks(4000), "$2a$11$WARsQXIR1s7d.APsu/VTleZC8/avlB1jzQ0AHlJi36yo0XkjEcdz6" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 3, 0, 58, 42, 278, DateTimeKind.Utc).AddTicks(7313), "$2a$11$lHKMvN/8L8VmxinzQBTtpO7n8lEv336ipFNNn2lvOPrhWzVykvOt." });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 3, 0, 58, 42, 530, DateTimeKind.Utc).AddTicks(7000), "$2a$11$JtqUg3sc.vGzmfhWaOkXCe29sOydTy0eC.t6gwQitczAPYrd.1wtm" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 3, 0, 58, 42, 789, DateTimeKind.Utc).AddTicks(7124), "$2a$11$PzxTazjAPuhEQ425MvOsbuwPfSeFfmaDACx6li3Gx/0SSaOl667JG" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCriacao", "Titulo" },
                values: new object[] { new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(2142), "Banheiro Com Problema" });

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCriacao", "Titulo" },
                values: new object[] { new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(3143), "Corrimão da Escada da COINF Descascando" });

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataCriacao", "Titulo" },
                values: new object[] { new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(3147), "Demora para Aprovar Máteria de TCC 1" });

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataCriacao", "Titulo" },
                values: new object[] { new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(3148), "Melhorias no Processo de Atendimento" });

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataCriacao", "Titulo" },
                values: new object[] { new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(3150), "Pessoal da Limpeza Top" });

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CampusId", "DataCriacao", "Titulo" },
                values: new object[] { 6, new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(3152), "Problemas com o Wifi do Campus" });

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DataCriacao", "Titulo" },
                values: new object[] { new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(3154), "Ifs Techday Top" });

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DataCriacao", "Titulo" },
                values: new object[] { new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(3157), "Semana Academica Divertida" });

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DataCriacao", "Titulo" },
                values: new object[] { new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(3160), "Semana Academica Algumas Palestras Massantes" });

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DataCriacao", "Titulo" },
                values: new object[] { new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(3161), "Lab da COINF precisão limpar o filtro do Ar" });

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DataCriacao", "Titulo" },
                values: new object[] { new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(3162), "Lab de Redes com acustica prejudicada" });

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 1, 20, 29, 5, 472, DateTimeKind.Utc).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 1, 20, 29, 5, 472, DateTimeKind.Utc).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 1, 20, 29, 5, 472, DateTimeKind.Utc).AddTicks(9543));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 1, 20, 29, 5, 472, DateTimeKind.Utc).AddTicks(9545));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 1, 20, 29, 5, 472, DateTimeKind.Utc).AddTicks(9546));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 1, 20, 29, 5, 472, DateTimeKind.Utc).AddTicks(9547));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 1, 20, 29, 5, 472, DateTimeKind.Utc).AddTicks(9548));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 1, 20, 29, 5, 472, DateTimeKind.Utc).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 1, 20, 29, 5, 472, DateTimeKind.Utc).AddTicks(9619));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 1, 20, 29, 5, 472, DateTimeKind.Utc).AddTicks(9622));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 1, 20, 29, 5, 472, DateTimeKind.Utc).AddTicks(9623));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(1914));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(1916));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(1918));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(1919));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(1924));

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "Id", "DataAtualizacao", "DataCriacao", "Nome" },
                values: new object[] { 6, null, new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(1925), "Biblioteca" });

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 1, 20, 29, 3, 392, DateTimeKind.Utc).AddTicks(6173));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 1, 20, 29, 3, 392, DateTimeKind.Utc).AddTicks(7887));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 1, 20, 29, 3, 392, DateTimeKind.Utc).AddTicks(7897));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 1, 20, 29, 3, 392, DateTimeKind.Utc).AddTicks(7898));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 1, 20, 29, 3, 392, DateTimeKind.Utc).AddTicks(7900));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 1, 20, 29, 3, 392, DateTimeKind.Utc).AddTicks(7901));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 1, 20, 29, 3, 392, DateTimeKind.Utc).AddTicks(7904));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 1, 20, 29, 3, 392, DateTimeKind.Utc).AddTicks(7907));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 1, 20, 29, 3, 392, DateTimeKind.Utc).AddTicks(7908));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 1, 20, 29, 3, 392, DateTimeKind.Utc).AddTicks(7910));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("21361548-9dc6-4d4e-9d37-1561483b1bdd"), new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(3474) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("4bb22560-e672-4d01-9d22-b37134a429c4"), new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(5140) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("c192ea5d-9cf9-4d0a-ab3b-dcabc3c47a69"), new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(5209) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("549a9a74-cd16-49d2-b4a5-421ec09ac4f8"), new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(5214) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("2cff4b2e-897d-45a0-81ff-c588b91c3d31"), new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(5217) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("57a95ea2-d174-48b7-bf79-6182fec4ee53"), new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(5219) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("f97eacba-080d-45aa-bf5d-902793609cd4"), new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(5222) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("f7035b64-19e8-464d-9e2b-bbea35066399"), new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(5238) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("f2ac8e97-17f1-4739-8471-767086953e24"), new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(5241) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("9747325f-c0b4-4424-87de-4db0caaab963"), new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(5243) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("1b1d05b4-3cf8-48cd-94f9-b8a662183dcf"), new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(5246) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("29708691-a3b4-44fb-9627-c7a60631325a"), new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(5249) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("209a780f-799f-4f0c-b830-e402eb3f2b08"), new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(5252) });

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(279));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(1584));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(1589));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(1592));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(1594));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(1595));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(1597));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(1598));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(1601));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(1613));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(1616));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(1619));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(1620));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(5926));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(7629));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(7634));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(7635));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(7638));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(7639));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(7641));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 1, 20, 29, 3, 394, DateTimeKind.Utc).AddTicks(4557));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 1, 20, 29, 3, 394, DateTimeKind.Utc).AddTicks(5359));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 1, 20, 29, 3, 602, DateTimeKind.Utc).AddTicks(1906), "$2a$11$loxQRVzc68HS3weBck71oOqdEMxjzzQGKK8jfHQdb5U5/x5.DuGSW" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 1, 20, 29, 3, 799, DateTimeKind.Utc).AddTicks(8624), "$2a$11$boi/dwzRz0J0zxUbKEtkquRt6Xa.m4p97074d3gmNqCNV3eee9oe2" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 1, 20, 29, 3, 998, DateTimeKind.Utc).AddTicks(7599), "$2a$11$KyrAC04zE2qOw0MwuuRVMeLlHwqN3JXpmu9xa8CghD3z1U24AXeCK" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 1, 20, 29, 4, 199, DateTimeKind.Utc).AddTicks(7300), "$2a$11$gkyuMEf751h89l5vHuS3nOKSojbUKEnE64QS6EuEPg1Im5TlyRDBq" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 1, 20, 29, 4, 404, DateTimeKind.Utc).AddTicks(8305), "$2a$11$RCWHlWNXW8tjZPpQbv9ekerrs6UH2XVL0CNW3cjIwlGG0qwM6dUvm" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 1, 20, 29, 4, 605, DateTimeKind.Utc).AddTicks(5791), "$2a$11$FTCIBE1To7vrodLXEzJEj.Gsc5r3OkdXioFVFtqaMnJP2XUC5rMYe" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 1, 20, 29, 4, 828, DateTimeKind.Utc).AddTicks(7962), "$2a$11$cYueODg46BwL0CVeIZBi7.w6LjZ2h4o5qdzU8c16eFy3bRItaWDA2" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 1, 20, 29, 5, 49, DateTimeKind.Utc).AddTicks(5151), "$2a$11$eqxFAjzV0ZILsXiq3bqWXu540dM8u5l/olmgqOHq4yusSAw2h1dkW" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 1, 20, 29, 5, 264, DateTimeKind.Utc).AddTicks(3089), "$2a$11$eUbu6/kA6vjx8YDy1LtA0.Epwc5N6VCIk3owYJPhqIZzGKOBNdj3q" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 1, 20, 29, 5, 472, DateTimeKind.Utc).AddTicks(7457), "$2a$11$XsTg712D5LpDyzgR4.fKzuoO9aoG5JngbfhZtrs8xtqrfT5aXN5f2" });

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CategoriaId", "DataCriacao", "Titulo" },
                values: new object[] { 6, new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(3163), "Nenhum Livro de Loiane Groner" });

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CategoriaId", "DataCriacao", "Titulo" },
                values: new object[] { 6, new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(3167), "Livro de Cálculo com página rasurada" });
        }
    }
}
