using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IfeedsApi.Migrations
{
    public partial class MigrationsV13AlterandoCampoStatusRespostaFeedbackFeedback : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "RespostasFeedbacks");

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Feedbacks",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 16, 0, 25, 30, 778, DateTimeKind.Utc).AddTicks(4503));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 16, 0, 25, 30, 778, DateTimeKind.Utc).AddTicks(6707));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 16, 0, 25, 30, 778, DateTimeKind.Utc).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 16, 0, 25, 30, 778, DateTimeKind.Utc).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 16, 0, 25, 30, 778, DateTimeKind.Utc).AddTicks(6743));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 16, 0, 25, 30, 778, DateTimeKind.Utc).AddTicks(6745));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 16, 0, 25, 30, 778, DateTimeKind.Utc).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 16, 0, 25, 30, 778, DateTimeKind.Utc).AddTicks(6752));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 16, 0, 25, 30, 778, DateTimeKind.Utc).AddTicks(6754));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 16, 0, 25, 30, 778, DateTimeKind.Utc).AddTicks(6757));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 16, 0, 25, 30, 778, DateTimeKind.Utc).AddTicks(6767));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 16, 0, 25, 30, 778, DateTimeKind.Utc).AddTicks(6770));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 16, 0, 25, 30, 778, DateTimeKind.Utc).AddTicks(6773));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCriacao", "Nome" },
                values: new object[] { new DateTime(2021, 8, 16, 0, 25, 30, 778, DateTimeKind.Utc), "Campus Lagarto" });

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCriacao", "Nome" },
                values: new object[] { new DateTime(2021, 8, 16, 0, 25, 30, 778, DateTimeKind.Utc).AddTicks(2847), "Campus Glória" });

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataCriacao", "Nome" },
                values: new object[] { new DateTime(2021, 8, 16, 0, 25, 30, 778, DateTimeKind.Utc).AddTicks(2862), "Campus Estância" });

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataCriacao", "Nome" },
                values: new object[] { new DateTime(2021, 8, 16, 0, 25, 30, 778, DateTimeKind.Utc).AddTicks(2864), "Campus São Cristovão" });

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataCriacao", "Nome" },
                values: new object[] { new DateTime(2021, 8, 16, 0, 25, 30, 778, DateTimeKind.Utc).AddTicks(2866), "Campus Itabaiana" });

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataCriacao", "Nome" },
                values: new object[] { new DateTime(2021, 8, 16, 0, 25, 30, 778, DateTimeKind.Utc).AddTicks(2870), "Campus Aracaju" });

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DataCriacao", "Nome" },
                values: new object[] { new DateTime(2021, 8, 16, 0, 25, 30, 778, DateTimeKind.Utc).AddTicks(2880), "Campus Tobias Barreto" });

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DataCriacao", "Nome" },
                values: new object[] { new DateTime(2021, 8, 16, 0, 25, 30, 778, DateTimeKind.Utc).AddTicks(2883), "Campus Poço Redondo" });

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DataCriacao", "Nome" },
                values: new object[] { new DateTime(2021, 8, 16, 0, 25, 30, 778, DateTimeKind.Utc).AddTicks(2885), "Campus Propriá" });

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DataCriacao", "Nome" },
                values: new object[] { new DateTime(2021, 8, 16, 0, 25, 30, 778, DateTimeKind.Utc).AddTicks(2887), "Campus Socorro" });

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DataCriacao", "Nome" },
                values: new object[] { new DateTime(2021, 8, 16, 0, 25, 30, 778, DateTimeKind.Utc).AddTicks(2890), "Educação a Distancia" });

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 16, 0, 25, 30, 778, DateTimeKind.Utc).AddTicks(3488));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 16, 0, 25, 30, 778, DateTimeKind.Utc).AddTicks(3494));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 16, 0, 25, 30, 778, DateTimeKind.Utc).AddTicks(3496));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 16, 0, 25, 30, 778, DateTimeKind.Utc).AddTicks(3498));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 16, 0, 25, 30, 778, DateTimeKind.Utc).AddTicks(3500));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 16, 0, 25, 28, 29, DateTimeKind.Utc).AddTicks(6621));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 16, 0, 25, 28, 29, DateTimeKind.Utc).AddTicks(8303));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 16, 0, 25, 28, 29, DateTimeKind.Utc).AddTicks(8311));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 16, 0, 25, 28, 29, DateTimeKind.Utc).AddTicks(8313));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 16, 0, 25, 28, 29, DateTimeKind.Utc).AddTicks(8314));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 16, 0, 25, 28, 29, DateTimeKind.Utc).AddTicks(8316));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 16, 0, 25, 28, 29, DateTimeKind.Utc).AddTicks(8317));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 16, 0, 25, 28, 29, DateTimeKind.Utc).AddTicks(8319));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 16, 0, 25, 28, 29, DateTimeKind.Utc).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 16, 0, 25, 28, 29, DateTimeKind.Utc).AddTicks(8323));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Codigo", "DataCriacao", "Status" },
                values: new object[] { new Guid("f6bf96aa-69e6-40e2-9e9c-b6c27938dd75"), new DateTime(2021, 8, 16, 0, 25, 30, 778, DateTimeKind.Utc).AddTicks(7661), true });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Codigo", "DataCriacao", "Status" },
                values: new object[] { new Guid("ec0acd35-86a0-411d-b72a-d652109a7a2c"), new DateTime(2021, 8, 16, 0, 25, 30, 779, DateTimeKind.Utc).AddTicks(1988), true });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Codigo", "DataCriacao", "Status" },
                values: new object[] { new Guid("86c73813-9fee-4d15-b123-fe0a5568ad99"), new DateTime(2021, 8, 16, 0, 25, 30, 779, DateTimeKind.Utc).AddTicks(2091), true });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Codigo", "DataCriacao", "Status" },
                values: new object[] { new Guid("b0cb5078-3133-4c6b-bf68-8853a83732e4"), new DateTime(2021, 8, 16, 0, 25, 30, 779, DateTimeKind.Utc).AddTicks(2098), true });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Codigo", "DataCriacao", "Status" },
                values: new object[] { new Guid("9e5ee5d6-af59-43b1-af73-d1ad6e0bdb85"), new DateTime(2021, 8, 16, 0, 25, 30, 779, DateTimeKind.Utc).AddTicks(2103), true });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Codigo", "DataCriacao", "Status" },
                values: new object[] { new Guid("dd331ec8-d42d-4399-a6d8-95b236c1d3fa"), new DateTime(2021, 8, 16, 0, 25, 30, 779, DateTimeKind.Utc).AddTicks(2107), true });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("6c267bd4-764e-43e1-bb46-f3ac42e8421e"), new DateTime(2021, 8, 16, 0, 25, 30, 779, DateTimeKind.Utc).AddTicks(2110) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Codigo", "DataCriacao", "Status" },
                values: new object[] { new Guid("637f04eb-2c38-41c0-95ea-428673e1bb3c"), new DateTime(2021, 8, 16, 0, 25, 30, 779, DateTimeKind.Utc).AddTicks(2114), true });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("295b5800-52d6-4289-a8e0-c47daccfde5f"), new DateTime(2021, 8, 16, 0, 25, 30, 779, DateTimeKind.Utc).AddTicks(2118) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("ede8f07d-2b1c-452d-88d0-b23418ce42f5"), new DateTime(2021, 8, 16, 0, 25, 30, 779, DateTimeKind.Utc).AddTicks(2122) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("897e5744-622f-4037-ac80-fd0187330ed0"), new DateTime(2021, 8, 16, 0, 25, 30, 779, DateTimeKind.Utc).AddTicks(2131) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("0017baeb-2f2e-4bfe-8c54-4e4e8dbaa96f"), new DateTime(2021, 8, 16, 0, 25, 30, 779, DateTimeKind.Utc).AddTicks(2135) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("41394c21-84e2-4bde-a388-17ece2dcb8bd"), new DateTime(2021, 8, 16, 0, 25, 30, 779, DateTimeKind.Utc).AddTicks(2141) });

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 16, 0, 25, 30, 779, DateTimeKind.Utc).AddTicks(3291));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 16, 0, 25, 30, 779, DateTimeKind.Utc).AddTicks(5459));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 16, 0, 25, 30, 779, DateTimeKind.Utc).AddTicks(5468));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 16, 0, 25, 30, 779, DateTimeKind.Utc).AddTicks(5472));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 16, 0, 25, 30, 779, DateTimeKind.Utc).AddTicks(5474));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 16, 0, 25, 30, 779, DateTimeKind.Utc).AddTicks(5477));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 16, 0, 25, 30, 779, DateTimeKind.Utc).AddTicks(5479));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 16, 0, 25, 28, 31, DateTimeKind.Utc).AddTicks(9443));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 16, 0, 25, 28, 32, DateTimeKind.Utc).AddTicks(621));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 16, 0, 25, 28, 318, DateTimeKind.Utc).AddTicks(8289), "$2a$11$QiISyFmX.oid/yBmAEvBPeFg/Oas/5097kdQZ9F6PFaZ0JDSk/K.y" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 16, 0, 25, 28, 581, DateTimeKind.Utc).AddTicks(8013), "$2a$11$fwEKMnenadqRgA/aVgqn3uvGOEsaLjs/PwVB2B5a0GkB1QjjE6y0K" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 16, 0, 25, 28, 849, DateTimeKind.Utc).AddTicks(9637), "$2a$11$I/4AG6UMEzfGBa58GKR1KOSt9IkUq7dWg/WvAch.FFIP5i/eZiRDO" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 16, 0, 25, 29, 114, DateTimeKind.Utc).AddTicks(536), "$2a$11$Ci5yKc1t6ixPQ8kLUUzp2uCIVj.wrKX0Lg96./QuNbVUVGBKYLRai" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 16, 0, 25, 29, 381, DateTimeKind.Utc).AddTicks(4430), "$2a$11$RgCfrpI3525Nvcymz7mXX.uS..CDBAuzTScKAfrn.Ks5vlIkukAYa" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 16, 0, 25, 29, 669, DateTimeKind.Utc).AddTicks(1596), "$2a$11$q98c4w7TFX8N6zb9Itaq1OuwiHZCyy9WBk895N0D78LSHh87jX5W6" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 16, 0, 25, 29, 956, DateTimeKind.Utc).AddTicks(7965), "$2a$11$Z4KSHdBg0Ozm0KWLChiaKeTRUC99bQw0gAIjMd4jx4AaxP.vWGF7C" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 16, 0, 25, 30, 215, DateTimeKind.Utc).AddTicks(4317), "$2a$11$s/2s8x1B7x4SReLVUmlZGuKC8LV5cA0WvVAClGa/EuzZ0/G/TyfbO" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 16, 0, 25, 30, 478, DateTimeKind.Utc).AddTicks(1308), "$2a$11$E2EDnEIUqdU3bYQNKBqxIeUsGgXJ0bdP62dW2HTG3PCBU5Nqq0kF6" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 16, 0, 25, 30, 777, DateTimeKind.Utc).AddTicks(6586), "$2a$11$UfTjnH451zAid2cMWxvgJOHFg7GD9CKJpBA2pw7ielyf/u/De525m" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Feedbacks");

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "RespostasFeedbacks",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 9, 45, 391, DateTimeKind.Utc).AddTicks(6448));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 9, 45, 391, DateTimeKind.Utc).AddTicks(7563));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 9, 45, 391, DateTimeKind.Utc).AddTicks(7568));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 9, 45, 391, DateTimeKind.Utc).AddTicks(7575));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 9, 45, 391, DateTimeKind.Utc).AddTicks(7577));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 9, 45, 391, DateTimeKind.Utc).AddTicks(7578));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 9, 45, 391, DateTimeKind.Utc).AddTicks(7580));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 9, 45, 391, DateTimeKind.Utc).AddTicks(7581));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 9, 45, 391, DateTimeKind.Utc).AddTicks(7582));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 9, 45, 391, DateTimeKind.Utc).AddTicks(7606));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 9, 45, 391, DateTimeKind.Utc).AddTicks(7608));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 9, 45, 391, DateTimeKind.Utc).AddTicks(7609));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 9, 45, 391, DateTimeKind.Utc).AddTicks(7610));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCriacao", "Nome" },
                values: new object[] { new DateTime(2021, 8, 14, 1, 9, 45, 391, DateTimeKind.Utc).AddTicks(4193), "IFS-Campus Lagarto" });

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCriacao", "Nome" },
                values: new object[] { new DateTime(2021, 8, 14, 1, 9, 45, 391, DateTimeKind.Utc).AddTicks(5702), "IFS-Campus Glória" });

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataCriacao", "Nome" },
                values: new object[] { new DateTime(2021, 8, 14, 1, 9, 45, 391, DateTimeKind.Utc).AddTicks(5707), "IFS-Campus Estância" });

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataCriacao", "Nome" },
                values: new object[] { new DateTime(2021, 8, 14, 1, 9, 45, 391, DateTimeKind.Utc).AddTicks(5709), "IFS-Campus São Cristovão" });

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataCriacao", "Nome" },
                values: new object[] { new DateTime(2021, 8, 14, 1, 9, 45, 391, DateTimeKind.Utc).AddTicks(5710), "IFS-Campus Itabaiana" });

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataCriacao", "Nome" },
                values: new object[] { new DateTime(2021, 8, 14, 1, 9, 45, 391, DateTimeKind.Utc).AddTicks(5711), "IFS-Campus Aracaju" });

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DataCriacao", "Nome" },
                values: new object[] { new DateTime(2021, 8, 14, 1, 9, 45, 391, DateTimeKind.Utc).AddTicks(5721), "IFS-Campus Tobias Barreto" });

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DataCriacao", "Nome" },
                values: new object[] { new DateTime(2021, 8, 14, 1, 9, 45, 391, DateTimeKind.Utc).AddTicks(5723), "IFS-Campus Poço Redondo" });

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DataCriacao", "Nome" },
                values: new object[] { new DateTime(2021, 8, 14, 1, 9, 45, 391, DateTimeKind.Utc).AddTicks(5724), "IFS-Campus Propriá" });

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DataCriacao", "Nome" },
                values: new object[] { new DateTime(2021, 8, 14, 1, 9, 45, 391, DateTimeKind.Utc).AddTicks(5725), "IFS-Campus Socorro" });

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DataCriacao", "Nome" },
                values: new object[] { new DateTime(2021, 8, 14, 1, 9, 45, 391, DateTimeKind.Utc).AddTicks(5726), "IFS-Educação a Distancia" });

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 9, 45, 391, DateTimeKind.Utc).AddTicks(5972));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 9, 45, 391, DateTimeKind.Utc).AddTicks(5974));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 9, 45, 391, DateTimeKind.Utc).AddTicks(5975));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 9, 45, 391, DateTimeKind.Utc).AddTicks(5976));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 9, 45, 391, DateTimeKind.Utc).AddTicks(5977));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 9, 43, 306, DateTimeKind.Utc).AddTicks(747));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 9, 43, 306, DateTimeKind.Utc).AddTicks(1713));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 9, 43, 306, DateTimeKind.Utc).AddTicks(1717));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 9, 43, 306, DateTimeKind.Utc).AddTicks(1718));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 9, 43, 306, DateTimeKind.Utc).AddTicks(1719));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 9, 43, 306, DateTimeKind.Utc).AddTicks(1721));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 9, 43, 306, DateTimeKind.Utc).AddTicks(1724));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 9, 43, 306, DateTimeKind.Utc).AddTicks(1725));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 9, 43, 306, DateTimeKind.Utc).AddTicks(1727));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 9, 43, 306, DateTimeKind.Utc).AddTicks(1728));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("541d42e9-41bd-4173-8c1b-6c6d18cec9ba"), new DateTime(2021, 8, 14, 1, 9, 45, 391, DateTimeKind.Utc).AddTicks(8004) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("b850d98a-3825-4e72-8a87-a17aa37887aa"), new DateTime(2021, 8, 14, 1, 9, 45, 392, DateTimeKind.Utc).AddTicks(652) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("de01982c-3256-4cad-ba57-cd6a7e9d1253"), new DateTime(2021, 8, 14, 1, 9, 45, 392, DateTimeKind.Utc).AddTicks(709) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("67d68912-3f64-45be-9913-4d1603c7390d"), new DateTime(2021, 8, 14, 1, 9, 45, 392, DateTimeKind.Utc).AddTicks(714) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("c5e12b34-9a6c-47fb-aa79-82b34090d416"), new DateTime(2021, 8, 14, 1, 9, 45, 392, DateTimeKind.Utc).AddTicks(717) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("b9a9dcf5-9a9a-407e-86f3-6d465b830199"), new DateTime(2021, 8, 14, 1, 9, 45, 392, DateTimeKind.Utc).AddTicks(720) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("6276ccc7-8eb0-4839-bfc1-78ee36eab5ae"), new DateTime(2021, 8, 14, 1, 9, 45, 392, DateTimeKind.Utc).AddTicks(722) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("9fb87538-113d-4302-9944-f8785fd5bc41"), new DateTime(2021, 8, 14, 1, 9, 45, 392, DateTimeKind.Utc).AddTicks(724) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("4aca2b8a-88fa-46b8-9ac2-d6c462f29bdf"), new DateTime(2021, 8, 14, 1, 9, 45, 392, DateTimeKind.Utc).AddTicks(739) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("fa691280-3308-4641-bcb8-919d1daf9c17"), new DateTime(2021, 8, 14, 1, 9, 45, 392, DateTimeKind.Utc).AddTicks(742) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("9aa2b70a-4201-4bd7-ac2f-437250719a81"), new DateTime(2021, 8, 14, 1, 9, 45, 392, DateTimeKind.Utc).AddTicks(745) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("c5222ff7-9720-4241-a729-597630b0fd7c"), new DateTime(2021, 8, 14, 1, 9, 45, 392, DateTimeKind.Utc).AddTicks(748) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("c3c6c0e4-a407-4962-96b0-9ceca82c6d8e"), new DateTime(2021, 8, 14, 1, 9, 45, 392, DateTimeKind.Utc).AddTicks(750) });

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCriacao", "Status" },
                values: new object[] { new DateTime(2021, 8, 14, 1, 9, 45, 392, DateTimeKind.Utc).AddTicks(1382), true });

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCriacao", "Status" },
                values: new object[] { new DateTime(2021, 8, 14, 1, 9, 45, 392, DateTimeKind.Utc).AddTicks(3066), true });

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataCriacao", "Status" },
                values: new object[] { new DateTime(2021, 8, 14, 1, 9, 45, 392, DateTimeKind.Utc).AddTicks(3072), true });

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataCriacao", "Status" },
                values: new object[] { new DateTime(2021, 8, 14, 1, 9, 45, 392, DateTimeKind.Utc).AddTicks(3074), true });

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataCriacao", "Status" },
                values: new object[] { new DateTime(2021, 8, 14, 1, 9, 45, 392, DateTimeKind.Utc).AddTicks(3076), true });

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataCriacao", "Status" },
                values: new object[] { new DateTime(2021, 8, 14, 1, 9, 45, 392, DateTimeKind.Utc).AddTicks(3077), true });

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DataCriacao", "Status" },
                values: new object[] { new DateTime(2021, 8, 14, 1, 9, 45, 392, DateTimeKind.Utc).AddTicks(3079), true });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 9, 43, 307, DateTimeKind.Utc).AddTicks(4013));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 9, 43, 307, DateTimeKind.Utc).AddTicks(4777));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 14, 1, 9, 43, 520, DateTimeKind.Utc).AddTicks(9450), "$2a$11$zUYKTUphO/nN6hQScZ5SiuVhiteV7vA9DgUBOahHk3Saf.1gzOTaO" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 14, 1, 9, 43, 726, DateTimeKind.Utc).AddTicks(8948), "$2a$11$hQkqhiIYV3sZ6i.25.d9.OqbIQIqm/PkphcKDdux/1mqXbcNM0xD6" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 14, 1, 9, 43, 929, DateTimeKind.Utc).AddTicks(6263), "$2a$11$smw0O6rXDyzHDE6FTAs3ienQkOt4YPuIc9r9GBhfJS14/J.a34VCG" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 14, 1, 9, 44, 137, DateTimeKind.Utc).AddTicks(9138), "$2a$11$0C4NgaUU2ZUu.urXfMwa7.TVDOecmHHaWtDowP.g8VRjYdMOW4dGm" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 14, 1, 9, 44, 349, DateTimeKind.Utc).AddTicks(51), "$2a$11$xL/39YDzbx49B4taP7XTwu/F7Pa1Wi0tCTFXRcEAKpB2joF4p4gMO" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 14, 1, 9, 44, 556, DateTimeKind.Utc).AddTicks(6997), "$2a$11$PSZIopEcwilBrbNuNqlYt.l/bilDtDALvLbMIRbtlZ5pyj.ofwDnS" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 14, 1, 9, 44, 770, DateTimeKind.Utc).AddTicks(824), "$2a$11$F4Py0PGPkkzFbJHteTeqGeyPrOU3fTngbeF1hIRIyPYhN8xjH8iBi" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 14, 1, 9, 44, 981, DateTimeKind.Utc).AddTicks(8606), "$2a$11$NpY/sE8G/Rj3n.HngeZDlO9ZoGYAJMm49Utbkj9n9r7r6n02n78Ly" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 14, 1, 9, 45, 187, DateTimeKind.Utc).AddTicks(5350), "$2a$11$X0bQ/Lu7UnHcG1VaH7kipe8KHnEMTeHi7.iAjglgUM/T7QZWgTmvW" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 14, 1, 9, 45, 391, DateTimeKind.Utc).AddTicks(3051), "$2a$11$iB/ti7lsi1igUMPAPJcwSOVmLPvCS5wMjV64IIIP7DDKL/ZydNCT2" });
        }
    }
}
