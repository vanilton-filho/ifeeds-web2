using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IfeedsApi.Migrations
{
    public partial class MigrationsV11AddRelacionamentoFormularioAvaliacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Feedbacks_Avaliacoes_AvaliacaoId",
                table: "Feedbacks");

            migrationBuilder.DropIndex(
                name: "IX_Feedbacks_AvaliacaoId",
                table: "Feedbacks");

            migrationBuilder.DropColumn(
                name: "AvaliacaoId",
                table: "Feedbacks");

            migrationBuilder.AddColumn<int>(
                name: "AvaliacaoId",
                table: "FormulariosAvaliacaos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 13, 0, 22, 5, 421, DateTimeKind.Utc).AddTicks(5524));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 13, 0, 22, 5, 421, DateTimeKind.Utc).AddTicks(6351));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 13, 0, 22, 5, 421, DateTimeKind.Utc).AddTicks(6354));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 13, 0, 22, 5, 421, DateTimeKind.Utc).AddTicks(6356));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 13, 0, 22, 5, 421, DateTimeKind.Utc).AddTicks(6358));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 13, 0, 22, 5, 421, DateTimeKind.Utc).AddTicks(6359));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 13, 0, 22, 5, 421, DateTimeKind.Utc).AddTicks(6360));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 13, 0, 22, 5, 421, DateTimeKind.Utc).AddTicks(6361));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 13, 0, 22, 5, 421, DateTimeKind.Utc).AddTicks(6362));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 13, 0, 22, 5, 421, DateTimeKind.Utc).AddTicks(6364));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 13, 0, 22, 5, 421, DateTimeKind.Utc).AddTicks(6366));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 13, 0, 22, 5, 421, DateTimeKind.Utc).AddTicks(6367));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 13, 0, 22, 5, 421, DateTimeKind.Utc).AddTicks(6368));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 13, 0, 22, 5, 421, DateTimeKind.Utc).AddTicks(2144));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 13, 0, 22, 5, 421, DateTimeKind.Utc).AddTicks(3297));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 13, 0, 22, 5, 421, DateTimeKind.Utc).AddTicks(3300));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 13, 0, 22, 5, 421, DateTimeKind.Utc).AddTicks(3301));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 13, 0, 22, 5, 421, DateTimeKind.Utc).AddTicks(3303));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 13, 0, 22, 5, 421, DateTimeKind.Utc).AddTicks(3304));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 13, 0, 22, 5, 421, DateTimeKind.Utc).AddTicks(3339));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 13, 0, 22, 5, 421, DateTimeKind.Utc).AddTicks(3340));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 13, 0, 22, 5, 421, DateTimeKind.Utc).AddTicks(3341));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 13, 0, 22, 5, 421, DateTimeKind.Utc).AddTicks(3342));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 13, 0, 22, 5, 421, DateTimeKind.Utc).AddTicks(3343));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 13, 0, 22, 5, 421, DateTimeKind.Utc).AddTicks(5377));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 13, 0, 22, 5, 421, DateTimeKind.Utc).AddTicks(5379));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 13, 0, 22, 5, 421, DateTimeKind.Utc).AddTicks(5380));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 13, 0, 22, 5, 421, DateTimeKind.Utc).AddTicks(5381));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 13, 0, 22, 5, 421, DateTimeKind.Utc).AddTicks(5382));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 13, 0, 22, 3, 361, DateTimeKind.Utc).AddTicks(1519));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 13, 0, 22, 3, 361, DateTimeKind.Utc).AddTicks(2729));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 13, 0, 22, 3, 361, DateTimeKind.Utc).AddTicks(2734));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 13, 0, 22, 3, 361, DateTimeKind.Utc).AddTicks(2736));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 13, 0, 22, 3, 361, DateTimeKind.Utc).AddTicks(2738));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 13, 0, 22, 3, 361, DateTimeKind.Utc).AddTicks(2739));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 13, 0, 22, 3, 361, DateTimeKind.Utc).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 13, 0, 22, 3, 361, DateTimeKind.Utc).AddTicks(2741));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 13, 0, 22, 3, 361, DateTimeKind.Utc).AddTicks(2742));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 13, 0, 22, 3, 361, DateTimeKind.Utc).AddTicks(2743));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("7448f4a6-31d7-4e14-b680-6266d68b192f"), new DateTime(2021, 8, 13, 0, 22, 5, 421, DateTimeKind.Utc).AddTicks(6624) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("297f0764-0c60-481a-8ce5-e7c8ae6fb011"), new DateTime(2021, 8, 13, 0, 22, 5, 421, DateTimeKind.Utc).AddTicks(7545) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("ef0ba6f8-769f-4678-b3c0-e94acec6ed0f"), new DateTime(2021, 8, 13, 0, 22, 5, 421, DateTimeKind.Utc).AddTicks(7549) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("43cc0dc6-3baa-4d6c-9cc8-2fdd3a8e7af0"), new DateTime(2021, 8, 13, 0, 22, 5, 421, DateTimeKind.Utc).AddTicks(7551) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("4aa64569-b9f6-4649-b7eb-ee45f3e8fb18"), new DateTime(2021, 8, 13, 0, 22, 5, 421, DateTimeKind.Utc).AddTicks(7566) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("1846e218-405b-4ea8-bbc2-904ddf169a93"), new DateTime(2021, 8, 13, 0, 22, 5, 421, DateTimeKind.Utc).AddTicks(7567) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("20ad233c-8b32-40eb-bd2b-93e8d1471c10"), new DateTime(2021, 8, 13, 0, 22, 5, 421, DateTimeKind.Utc).AddTicks(7569) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("2b3aad79-1d24-47bf-9635-ac2c964b135c"), new DateTime(2021, 8, 13, 0, 22, 5, 421, DateTimeKind.Utc).AddTicks(7571) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("a2aef7a7-2548-4e4b-8a8d-957107168c08"), new DateTime(2021, 8, 13, 0, 22, 5, 421, DateTimeKind.Utc).AddTicks(7572) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("8b5bd077-752c-4493-a843-9d5585bec387"), new DateTime(2021, 8, 13, 0, 22, 5, 421, DateTimeKind.Utc).AddTicks(7574) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("e5572f83-2554-47cd-b0ce-1adfb2267753"), new DateTime(2021, 8, 13, 0, 22, 5, 421, DateTimeKind.Utc).AddTicks(7576) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("18e5b35c-55c4-4f19-aa2a-0424f7d173f2"), new DateTime(2021, 8, 13, 0, 22, 5, 421, DateTimeKind.Utc).AddTicks(7578) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("c6aefbee-9e7e-4bb2-8bb4-dec0a40cc225"), new DateTime(2021, 8, 13, 0, 22, 5, 421, DateTimeKind.Utc).AddTicks(7582) });

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AvaliacaoId", "DataCriacao" },
                values: new object[] { 1, new DateTime(2021, 8, 13, 0, 22, 5, 421, DateTimeKind.Utc).AddTicks(3942) });

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AvaliacaoId", "DataCriacao" },
                values: new object[] { 2, new DateTime(2021, 8, 13, 0, 22, 5, 421, DateTimeKind.Utc).AddTicks(5093) });

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AvaliacaoId", "DataCriacao" },
                values: new object[] { 3, new DateTime(2021, 8, 13, 0, 22, 5, 421, DateTimeKind.Utc).AddTicks(5097) });

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AvaliacaoId", "DataCriacao" },
                values: new object[] { 4, new DateTime(2021, 8, 13, 0, 22, 5, 421, DateTimeKind.Utc).AddTicks(5098) });

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AvaliacaoId", "DataCriacao" },
                values: new object[] { 5, new DateTime(2021, 8, 13, 0, 22, 5, 421, DateTimeKind.Utc).AddTicks(5099) });

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AvaliacaoId", "DataCriacao" },
                values: new object[] { 6, new DateTime(2021, 8, 13, 0, 22, 5, 421, DateTimeKind.Utc).AddTicks(5100) });

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AvaliacaoId", "DataCriacao" },
                values: new object[] { 7, new DateTime(2021, 8, 13, 0, 22, 5, 421, DateTimeKind.Utc).AddTicks(5102) });

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AvaliacaoId", "DataCriacao" },
                values: new object[] { 8, new DateTime(2021, 8, 13, 0, 22, 5, 421, DateTimeKind.Utc).AddTicks(5103) });

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AvaliacaoId", "DataCriacao" },
                values: new object[] { 8, new DateTime(2021, 8, 13, 0, 22, 5, 421, DateTimeKind.Utc).AddTicks(5109) });

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AvaliacaoId", "DataCriacao" },
                values: new object[] { 10, new DateTime(2021, 8, 13, 0, 22, 5, 421, DateTimeKind.Utc).AddTicks(5111) });

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AvaliacaoId", "DataCriacao" },
                values: new object[] { 11, new DateTime(2021, 8, 13, 0, 22, 5, 421, DateTimeKind.Utc).AddTicks(5169) });

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AvaliacaoId", "DataCriacao" },
                values: new object[] { 6, new DateTime(2021, 8, 13, 0, 22, 5, 421, DateTimeKind.Utc).AddTicks(5171) });

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AvaliacaoId", "DataCriacao" },
                values: new object[] { 6, new DateTime(2021, 8, 13, 0, 22, 5, 421, DateTimeKind.Utc).AddTicks(5173) });

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 13, 0, 22, 5, 421, DateTimeKind.Utc).AddTicks(7810));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 13, 0, 22, 5, 421, DateTimeKind.Utc).AddTicks(8530));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 13, 0, 22, 5, 421, DateTimeKind.Utc).AddTicks(8533));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 13, 0, 22, 5, 421, DateTimeKind.Utc).AddTicks(8534));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 13, 0, 22, 5, 421, DateTimeKind.Utc).AddTicks(8536));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 13, 0, 22, 5, 421, DateTimeKind.Utc).AddTicks(8537));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 13, 0, 22, 5, 421, DateTimeKind.Utc).AddTicks(8538));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 13, 0, 22, 3, 362, DateTimeKind.Utc).AddTicks(6034));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 13, 0, 22, 3, 362, DateTimeKind.Utc).AddTicks(6823));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 13, 0, 22, 3, 576, DateTimeKind.Utc).AddTicks(5059), "$2a$11$AoRbwBX2uC2Og4.QtiqU6OPsiSxK2IIUvSIQLA20BmK8uiJu0CmmK" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 13, 0, 22, 3, 781, DateTimeKind.Utc).AddTicks(6882), "$2a$11$pRrrU2S64lXe3551DwvKeuYpdbcYVf3c8M8wQeNwFCoYjyhrpqV1G" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 13, 0, 22, 3, 987, DateTimeKind.Utc).AddTicks(3381), "$2a$11$rcJK0nZl5l.s4ta25fF/bORxcO7J98oX8fkzqmPV6TJru059T8NJC" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 13, 0, 22, 4, 188, DateTimeKind.Utc).AddTicks(2800), "$2a$11$Z.5bsHH4J8ENexbSKkaib.A19qkUovJ8pXKe9qUsgU9S6CJ8BYzvW" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 13, 0, 22, 4, 390, DateTimeKind.Utc).AddTicks(1547), "$2a$11$LVkvtbNuZCpRKeNkVHnbH.myvUiuim0D1NG9zdmDBm4ycUMyVX5za" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 13, 0, 22, 4, 594, DateTimeKind.Utc).AddTicks(1670), "$2a$11$8/6u4OrDR3V.m3fjhT3rXeWMko2R5NI6MK1cGGGqo2Y5xC6laPYm2" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 13, 0, 22, 4, 796, DateTimeKind.Utc).AddTicks(5294), "$2a$11$G1QVfix6FdPljqD2h6xHzOOHArnecr5MvZtqI2fjT45WTk2CQBnKi" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 13, 0, 22, 5, 3, DateTimeKind.Utc).AddTicks(726), "$2a$11$SG0TkJVvNX4Y6dMmdabVJeirzUG6SYbqFMxlEMwdXgwQd0WsVhlL." });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 13, 0, 22, 5, 206, DateTimeKind.Utc).AddTicks(2889), "$2a$11$J6CVXe4wx0hiA2mKrsGdFuWKuBJfTvvgPQk38LkowXcaFxJQNFYtu" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 13, 0, 22, 5, 421, DateTimeKind.Utc).AddTicks(1343), "$2a$11$rT56dfa/bevtb7frK.xlLOWboDpaT8JuOqDGVEwuwEWe9TyMqAFjK" });

            migrationBuilder.CreateIndex(
                name: "IX_FormulariosAvaliacaos_AvaliacaoId",
                table: "FormulariosAvaliacaos",
                column: "AvaliacaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_FormulariosAvaliacaos_Avaliacoes_AvaliacaoId",
                table: "FormulariosAvaliacaos",
                column: "AvaliacaoId",
                principalTable: "Avaliacoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FormulariosAvaliacaos_Avaliacoes_AvaliacaoId",
                table: "FormulariosAvaliacaos");

            migrationBuilder.DropIndex(
                name: "IX_FormulariosAvaliacaos_AvaliacaoId",
                table: "FormulariosAvaliacaos");

            migrationBuilder.DropColumn(
                name: "AvaliacaoId",
                table: "FormulariosAvaliacaos");

            migrationBuilder.AddColumn<int>(
                name: "AvaliacaoId",
                table: "Feedbacks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(2159));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(3443));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(3449));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(3451));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(3452));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(3454));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(3456));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(3458));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(3461));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(3463));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(3464));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 12, 0, 47, 46, 300, DateTimeKind.Utc).AddTicks(7583));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 12, 0, 47, 46, 300, DateTimeKind.Utc).AddTicks(9138));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 12, 0, 47, 46, 300, DateTimeKind.Utc).AddTicks(9294));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 12, 0, 47, 46, 300, DateTimeKind.Utc).AddTicks(9297));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 12, 0, 47, 46, 300, DateTimeKind.Utc).AddTicks(9299));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 12, 0, 47, 46, 300, DateTimeKind.Utc).AddTicks(9300));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 12, 0, 47, 46, 300, DateTimeKind.Utc).AddTicks(9302));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 12, 0, 47, 46, 300, DateTimeKind.Utc).AddTicks(9304));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 12, 0, 47, 46, 300, DateTimeKind.Utc).AddTicks(9328));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 12, 0, 47, 46, 300, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 12, 0, 47, 46, 300, DateTimeKind.Utc).AddTicks(9331));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(1924));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(1926));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(1928));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(1930));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(1931));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 12, 0, 47, 44, 366, DateTimeKind.Utc).AddTicks(4077));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 12, 0, 47, 44, 366, DateTimeKind.Utc).AddTicks(5697));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 12, 0, 47, 44, 366, DateTimeKind.Utc).AddTicks(5702));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 12, 0, 47, 44, 366, DateTimeKind.Utc).AddTicks(5703));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 12, 0, 47, 44, 366, DateTimeKind.Utc).AddTicks(5705));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 12, 0, 47, 44, 366, DateTimeKind.Utc).AddTicks(5706));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 12, 0, 47, 44, 366, DateTimeKind.Utc).AddTicks(5707));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 12, 0, 47, 44, 366, DateTimeKind.Utc).AddTicks(5708));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 12, 0, 47, 44, 366, DateTimeKind.Utc).AddTicks(5709));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 12, 0, 47, 44, 366, DateTimeKind.Utc).AddTicks(5711));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AvaliacaoId", "Codigo", "DataCriacao" },
                values: new object[] { 1, new Guid("9869569c-0e80-4d03-91ae-625f5746706d"), new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(3928) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AvaliacaoId", "Codigo", "DataCriacao" },
                values: new object[] { 2, new Guid("fee394bd-308f-4b6f-99d9-958fe1c972eb"), new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(5265) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AvaliacaoId", "Codigo", "DataCriacao" },
                values: new object[] { 3, new Guid("21fcd079-cfa0-48a4-b2fa-336bd35525f2"), new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(5273) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AvaliacaoId", "Codigo", "DataCriacao" },
                values: new object[] { 4, new Guid("db966de6-68da-4188-88b5-cde7ae72d045"), new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(5275) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AvaliacaoId", "Codigo", "DataCriacao" },
                values: new object[] { 5, new Guid("893b5c26-4a9c-4dff-a157-0f40580bbdee"), new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(5277) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AvaliacaoId", "Codigo", "DataCriacao" },
                values: new object[] { 6, new Guid("cb1b92c3-80c7-4b93-9470-8b8f3ad724a0"), new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(5281) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AvaliacaoId", "Codigo", "DataCriacao" },
                values: new object[] { 7, new Guid("085b9abd-4677-468d-b27e-18345be407c9"), new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(5283) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AvaliacaoId", "Codigo", "DataCriacao" },
                values: new object[] { 8, new Guid("df87e857-fab3-4797-8032-7ec7c55ccc23"), new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(5300) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AvaliacaoId", "Codigo", "DataCriacao" },
                values: new object[] { 8, new Guid("135ec232-64b3-4793-9e1e-335909f77aa5"), new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(5305) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AvaliacaoId", "Codigo", "DataCriacao" },
                values: new object[] { 10, new Guid("8be5c4ff-50f1-43df-81cb-f8046f5df350"), new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(5307) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AvaliacaoId", "Codigo", "DataCriacao" },
                values: new object[] { 11, new Guid("4bd8fadf-7a0b-4424-a124-b15f023f4b93"), new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(5309) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AvaliacaoId", "Codigo", "DataCriacao" },
                values: new object[] { 6, new Guid("e12aaac0-44e5-4995-8dc8-19f5d26135a5"), new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(5312) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AvaliacaoId", "Codigo", "DataCriacao" },
                values: new object[] { 6, new Guid("77133dd7-0530-4d27-8eca-b88acfe73086"), new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(5314) });

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(101));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(1630));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(1635));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(1638));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(1640));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(1643));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(1645));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(1646));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(1648));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(1656));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(1658));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(1659));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(1661));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(5727));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(6756));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(6759));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(6762));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(6763));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(6765));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 12, 0, 47, 44, 367, DateTimeKind.Utc).AddTicks(8278));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 12, 0, 47, 44, 367, DateTimeKind.Utc).AddTicks(9033));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 12, 0, 47, 44, 573, DateTimeKind.Utc).AddTicks(751), "$2a$11$kkWAt4G5NPGFqUS/F0oy.uzFKTY5vMI4yrl4gOmDg4551dZ.yzNbe" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 12, 0, 47, 44, 767, DateTimeKind.Utc).AddTicks(584), "$2a$11$R8dKnQEOiZHfyz53GGjjOeFBqlKnciOKg92.AzZhK4vI78BfhhgPe" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 12, 0, 47, 44, 959, DateTimeKind.Utc).AddTicks(7599), "$2a$11$/G8QoKwVMs0klKXf75HYyeAjZk0f.x90kRpIdyMPXYzilENJQclSW" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 12, 0, 47, 45, 151, DateTimeKind.Utc).AddTicks(3551), "$2a$11$IX01Yme.DNK92givzUFd/OvhuZmf9Wrk6yqQ6mrp6k..9Z.2XL5mS" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 12, 0, 47, 45, 342, DateTimeKind.Utc).AddTicks(5069), "$2a$11$gMGu3U9rHD4FNERGHVPf7eAZTnd8FY7wo5cjh1lqajT2O7FbLaLYm" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 12, 0, 47, 45, 535, DateTimeKind.Utc).AddTicks(459), "$2a$11$VcazKi.R3QSmZst/2cJ3QenLA/D6J2E9Y35h4Si2VmBub.R3gCE9y" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 12, 0, 47, 45, 728, DateTimeKind.Utc).AddTicks(2617), "$2a$11$SqoGIi92BOjTVVtdZ9QCMu/N3uwB.24UOaJwvCqR/pUm8m6o4paqS" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 12, 0, 47, 45, 918, DateTimeKind.Utc).AddTicks(116), "$2a$11$Tke8v3agQyMHyADukOFZbOweVKblQ3gJ4gyZZROdgXsWafg2xrX5S" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 12, 0, 47, 46, 108, DateTimeKind.Utc).AddTicks(2802), "$2a$11$qZmxxUgXvWI5oowICU6jTOE1XhXz7bhZBKKv7l43Nkkcq9Zq9Z64y" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 12, 0, 47, 46, 300, DateTimeKind.Utc).AddTicks(6758), "$2a$11$QZii17HfUiHWou65oiAiBeJtq3HKlV/4UUi1KvyiABsYUnwFDPi2G" });

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_AvaliacaoId",
                table: "Feedbacks",
                column: "AvaliacaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Feedbacks_Avaliacoes_AvaliacaoId",
                table: "Feedbacks",
                column: "AvaliacaoId",
                principalTable: "Avaliacoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
