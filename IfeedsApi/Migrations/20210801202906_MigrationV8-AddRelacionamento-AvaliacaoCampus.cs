using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IfeedsApi.Migrations
{
    public partial class MigrationV8AddRelacionamentoAvaliacaoCampus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CampusId",
                table: "Avaliacoes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CampusId", "DataCriacao" },
                values: new object[] { 1, new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(2142) });

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CampusId", "DataCriacao" },
                values: new object[] { 2, new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(3143) });

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CampusId", "DataCriacao" },
                values: new object[] { 3, new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(3147) });

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CampusId", "DataCriacao" },
                values: new object[] { 4, new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(3148) });

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CampusId", "DataCriacao" },
                values: new object[] { 5, new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(3150) });

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CampusId", "DataCriacao" },
                values: new object[] { 6, new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(3152) });

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CampusId", "DataCriacao" },
                values: new object[] { 7, new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(3154) });

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CampusId", "DataCriacao" },
                values: new object[] { 8, new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(3157) });

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CampusId", "DataCriacao" },
                values: new object[] { 9, new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(3160) });

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CampusId", "DataCriacao" },
                values: new object[] { 10, new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(3161) });

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CampusId", "DataCriacao" },
                values: new object[] { 11, new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(3162) });

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CampusId", "DataCriacao" },
                values: new object[] { 1, new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(3163) });

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CampusId", "DataCriacao" },
                values: new object[] { 6, new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(3167) });

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

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 8, 1, 20, 29, 5, 473, DateTimeKind.Utc).AddTicks(1925));

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

            migrationBuilder.CreateIndex(
                name: "IX_Avaliacoes_CampusId",
                table: "Avaliacoes",
                column: "CampusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Avaliacoes_Campus_CampusId",
                table: "Avaliacoes",
                column: "CampusId",
                principalTable: "Campus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Avaliacoes_Campus_CampusId",
                table: "Avaliacoes");

            migrationBuilder.DropIndex(
                name: "IX_Avaliacoes_CampusId",
                table: "Avaliacoes");

            migrationBuilder.DropColumn(
                name: "CampusId",
                table: "Avaliacoes");

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(5414));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(6383));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(6386));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(6388));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(6389));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(6391));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(6392));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(6394));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(6395));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(6397));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(6398));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(6402));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(1164));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(2719));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(2723));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(2725));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(2726));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(2729));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(2773));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(2775));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(2776));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(2777));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(2786));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(5167));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(5171));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(5173));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(5174));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(5175));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 19, 2, 27, 802, DateTimeKind.Utc).AddTicks(6071));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 19, 2, 27, 802, DateTimeKind.Utc).AddTicks(7607));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 19, 2, 27, 802, DateTimeKind.Utc).AddTicks(7613));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 19, 2, 27, 802, DateTimeKind.Utc).AddTicks(7615));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 19, 2, 27, 802, DateTimeKind.Utc).AddTicks(7619));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 19, 2, 27, 802, DateTimeKind.Utc).AddTicks(7621));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 19, 2, 27, 802, DateTimeKind.Utc).AddTicks(7622));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 19, 2, 27, 802, DateTimeKind.Utc).AddTicks(7623));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 19, 2, 27, 802, DateTimeKind.Utc).AddTicks(7627));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 19, 2, 27, 802, DateTimeKind.Utc).AddTicks(7629));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("896e137c-656d-4eed-b433-cebb3e2a295d"), new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(6772) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("e960a809-0b6a-45e3-932d-2fdb29a68883"), new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(8145) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("4c4e7dab-cddc-45a3-8bd4-f280097fb2ea"), new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(8150) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("6ae9ea9c-adf8-401e-9208-a464337a9afe"), new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(8152) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("d540c216-9397-4c9a-9476-9b33d29f70c8"), new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(8154) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("a1e2e9be-e6a8-4fda-bb1c-82409831ea8e"), new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(8156) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("81162864-e685-43e6-934b-adcedaed3b87"), new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(8158) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("fb33504d-2d98-4723-ae7e-5bd80b0d3278"), new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(8176) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("7cc6f7ec-3b13-4e59-90a1-301de0370b5c"), new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(8179) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("c08ef761-ccb6-4ce2-9c07-5a1f56e0b5ba"), new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(8181) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("ce5a6638-ca7f-4d49-a569-505cd4f59f14"), new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(8183) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("e067812d-12a8-4f5a-89f7-70705d0ac129"), new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(8185) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("6d63730d-8fa1-43d1-be54-e38087d5d6cd"), new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(8188) });

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(3560));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(4903));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(4907));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(4909));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(4912));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(4914));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(4916));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(4917));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(4924));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(4926));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(4927));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(4929));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(4930));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(9952));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(9956));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(9957));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(9959));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(9960));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(9961));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 19, 2, 27, 804, DateTimeKind.Utc).AddTicks(4437));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 19, 2, 27, 804, DateTimeKind.Utc).AddTicks(5645));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 7, 28, 19, 2, 28, 78, DateTimeKind.Utc).AddTicks(1783), "$2a$11$zqE0OnZ5D.2lPZ5Sf7vlXO2HYE1hAZLRw7KjtFrjdoXbFeMVcOm/a" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 7, 28, 19, 2, 28, 327, DateTimeKind.Utc).AddTicks(8818), "$2a$11$PiAH5KafzkjLygI0wPwxLeV93YRyxMuSUVKYOHaT82UoJn9o9v7IC" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 7, 28, 19, 2, 28, 586, DateTimeKind.Utc).AddTicks(5213), "$2a$11$aoNQDdmMWsEgMVa5jJH4reoW7HufK7xhJq45.xRV/m0qBKQH/A8D." });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 7, 28, 19, 2, 28, 837, DateTimeKind.Utc).AddTicks(5166), "$2a$11$zNyVXfRg3gstVdqBurNglOVah3nYlH481KBxQNkSGcH769smtKKri" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 7, 28, 19, 2, 29, 89, DateTimeKind.Utc).AddTicks(6855), "$2a$11$aJbID5oolELyWlv0LXn4Tujtm1CgfEam7noRUzd5fAZ6gx422LuEW" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 7, 28, 19, 2, 29, 344, DateTimeKind.Utc).AddTicks(5792), "$2a$11$smv0odvV7bRkP0g5Bq.H8eJtnMYLTYS0LGLrQr7zNGm1d68fE/iOW" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 7, 28, 19, 2, 29, 591, DateTimeKind.Utc).AddTicks(193), "$2a$11$zHStYLnRpNL.59PZp7NH..kp2JNJQqH0YPaWQTweRmA56Fbk4Qive" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 7, 28, 19, 2, 29, 839, DateTimeKind.Utc).AddTicks(7614), "$2a$11$tJodLgpVS0Whdk0exV2qvO.aRNu5.kJX8pJ0/cwE.eYRtNdw6gYNS" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 7, 28, 19, 2, 30, 94, DateTimeKind.Utc).AddTicks(8214), "$2a$11$4DYX4J6HdhFsqGCKZG1jaOMsI9DliLJh4a7a.fhthhs/VNP/JsJmu" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(249), "$2a$11$MqCwe6JTkMYGyptI.VEqC.SKYi8/dqzMOu/vMP4ulYr.7V479A6s2" });
        }
    }
}
