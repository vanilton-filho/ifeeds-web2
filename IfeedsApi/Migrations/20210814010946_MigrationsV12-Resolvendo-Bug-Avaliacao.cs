using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IfeedsApi.Migrations
{
    public partial class MigrationsV12ResolvendoBugAvaliacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Avaliacoes",
                columns: new[] { "Id", "CampusId", "CategoriaId", "DataAtualizacao", "DataCriacao", "MediaAvaliacao", "Titulo" },
                values: new object[,]
                {
                    { 12, 1, 1, null, new DateTime(2021, 8, 14, 1, 9, 45, 391, DateTimeKind.Utc).AddTicks(7609), 0.0m, "Refeitório" },
                    { 13, 6, 1, null, new DateTime(2021, 8, 14, 1, 9, 45, 391, DateTimeKind.Utc).AddTicks(7610), 0.0m, "Quadra Poliesportiva" }
                });

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 9, 45, 391, DateTimeKind.Utc).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 9, 45, 391, DateTimeKind.Utc).AddTicks(5702));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 9, 45, 391, DateTimeKind.Utc).AddTicks(5707));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 9, 45, 391, DateTimeKind.Utc).AddTicks(5709));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 9, 45, 391, DateTimeKind.Utc).AddTicks(5710));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 9, 45, 391, DateTimeKind.Utc).AddTicks(5711));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 9, 45, 391, DateTimeKind.Utc).AddTicks(5721));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 9, 45, 391, DateTimeKind.Utc).AddTicks(5723));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 9, 45, 391, DateTimeKind.Utc).AddTicks(5724));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 9, 45, 391, DateTimeKind.Utc).AddTicks(5725));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 9, 45, 391, DateTimeKind.Utc).AddTicks(5726));

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
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 9, 45, 392, DateTimeKind.Utc).AddTicks(1382));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 9, 45, 392, DateTimeKind.Utc).AddTicks(3066));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 9, 45, 392, DateTimeKind.Utc).AddTicks(3072));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 9, 45, 392, DateTimeKind.Utc).AddTicks(3074));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 9, 45, 392, DateTimeKind.Utc).AddTicks(3076));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 9, 45, 392, DateTimeKind.Utc).AddTicks(3077));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 9, 45, 392, DateTimeKind.Utc).AddTicks(3079));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(4843));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(5910));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(5914));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(5921));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(5923));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(5924));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(5928));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(5930));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(5932));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(5935));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(5937));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(2627));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(4086));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(4089));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(4091));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(4093));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(4107));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(4111));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(4112));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(4341));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(4343));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(4345));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(4346));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(4347));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 7, 39, 887, DateTimeKind.Utc).AddTicks(6176));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 7, 39, 887, DateTimeKind.Utc).AddTicks(7106));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 7, 39, 887, DateTimeKind.Utc).AddTicks(7109));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 7, 39, 887, DateTimeKind.Utc).AddTicks(7111));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 7, 39, 887, DateTimeKind.Utc).AddTicks(7112));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 7, 39, 887, DateTimeKind.Utc).AddTicks(7113));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 7, 39, 887, DateTimeKind.Utc).AddTicks(7114));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 7, 39, 887, DateTimeKind.Utc).AddTicks(7115));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 7, 39, 887, DateTimeKind.Utc).AddTicks(7116));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 7, 39, 887, DateTimeKind.Utc).AddTicks(7117));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("58ba8ed7-b525-4542-ab74-aa3ee1be29d5"), new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(6281) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("d0bedbc6-33d9-4b50-9a1d-0797a80db74c"), new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(7364) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("608c2fc6-8669-4e01-b0d2-da8f20d507a0"), new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(7382) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("40ae75ff-c404-4cb7-aa87-a13d71571ff9"), new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(7385) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("0222e997-6e53-4e12-ad3e-7a2665048245"), new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(7387) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("52e6e3de-b121-4f24-bc8c-bdcf86f2b190"), new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(7388) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("010bdb86-d460-47a4-a8b5-d8e34ad06eb1"), new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(7390) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("56a44130-51c8-490f-ad93-613523c90e1c"), new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(7392) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("be3441f3-b8dd-471a-8ad2-a4943092ffaf"), new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(7400) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("97d589e0-9501-433b-880d-b5aca23ab82f"), new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(7403) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("87690238-e8e3-4e7e-b7eb-d89c539b153b"), new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(7406) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("f8cc9a8b-4e3c-4b1c-8df8-4496cee4737e"), new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(7409) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("62b2f636-0a23-4a95-b10c-b1709a6b9e93"), new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(7411) });

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(7635));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(8585));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(8588));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(8590));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(8594));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(8595));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 7, 39, 888, DateTimeKind.Utc).AddTicks(9605));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 14, 1, 7, 39, 889, DateTimeKind.Utc).AddTicks(333));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 14, 1, 7, 40, 99, DateTimeKind.Utc).AddTicks(7760), "$2a$11$emQw0f1sX3ALxG43UwRwCeBFWm2JJI/SCnbUNZP4mwfP4vAcC84VW" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 14, 1, 7, 40, 304, DateTimeKind.Utc).AddTicks(9347), "$2a$11$umzXSCUH62xVytx.1B19QOV36M2b5Kt9NphJUsn.KMTWyBJDbnfGG" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 14, 1, 7, 40, 508, DateTimeKind.Utc).AddTicks(125), "$2a$11$oLT1HUIZc8QZwBqXlFN8qOrQ4YI1veGmvG4e2qdzFLUYXMHzT7Zem" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 14, 1, 7, 40, 706, DateTimeKind.Utc).AddTicks(3499), "$2a$11$QhPkJuFN7sxB0DySYdvLjuPkydnlbnpq7xm3W2V92N9v5TCpH0A5e" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 14, 1, 7, 40, 906, DateTimeKind.Utc).AddTicks(2691), "$2a$11$O2M9Hwda48uoiaFDXjiOWOs9sk5tkoWvJyGi55JlHWXokINaWv.ZK" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 14, 1, 7, 41, 107, DateTimeKind.Utc).AddTicks(5597), "$2a$11$tWlsrKfVgnfnCAtfAIaA6e4fFz.XZeWz2jBMbfp9TNatEcA8hRijK" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 14, 1, 7, 41, 313, DateTimeKind.Utc).AddTicks(7285), "$2a$11$iaJ/jzdZ9kqgWvmGKqt8M.1XNWv19porm8srsP8SXMtir44LYX5b." });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 14, 1, 7, 41, 522, DateTimeKind.Utc).AddTicks(7469), "$2a$11$a5Ve6qc5Fm3zNbkASPQWz.jUhXwM6o8pgoGw2h0kIRX5Wy0gZB8LG" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 14, 1, 7, 41, 725, DateTimeKind.Utc).AddTicks(6188), "$2a$11$h3oTw.IUzu5mzRdXXkwt.eajC1LG5WcUphgrdE2pLuhiSx/Q4A64m" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(1701), "$2a$11$fvD4XEnZ7sbGwEZPgjKzr.b4I2lcwijH466IWVbPa34V/9CQiIxgu" });
        }
    }
}
