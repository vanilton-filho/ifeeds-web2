using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IfeedsApi.Migrations
{
    public partial class MigrationV7AddRelacionamentoUsuarioCampus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CampusId",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "CampusId", "DataCriacao", "Senha" },
                values: new object[] { 1, new DateTime(2021, 7, 28, 19, 2, 28, 78, DateTimeKind.Utc).AddTicks(1783), "$2a$11$zqE0OnZ5D.2lPZ5Sf7vlXO2HYE1hAZLRw7KjtFrjdoXbFeMVcOm/a" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CampusId", "DataCriacao", "Senha" },
                values: new object[] { 2, new DateTime(2021, 7, 28, 19, 2, 28, 327, DateTimeKind.Utc).AddTicks(8818), "$2a$11$PiAH5KafzkjLygI0wPwxLeV93YRyxMuSUVKYOHaT82UoJn9o9v7IC" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CampusId", "DataCriacao", "Senha" },
                values: new object[] { 3, new DateTime(2021, 7, 28, 19, 2, 28, 586, DateTimeKind.Utc).AddTicks(5213), "$2a$11$aoNQDdmMWsEgMVa5jJH4reoW7HufK7xhJq45.xRV/m0qBKQH/A8D." });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CampusId", "DataCriacao", "Senha" },
                values: new object[] { 1, new DateTime(2021, 7, 28, 19, 2, 28, 837, DateTimeKind.Utc).AddTicks(5166), "$2a$11$zNyVXfRg3gstVdqBurNglOVah3nYlH481KBxQNkSGcH769smtKKri" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CampusId", "DataCriacao", "Senha" },
                values: new object[] { 6, new DateTime(2021, 7, 28, 19, 2, 29, 89, DateTimeKind.Utc).AddTicks(6855), "$2a$11$aJbID5oolELyWlv0LXn4Tujtm1CgfEam7noRUzd5fAZ6gx422LuEW" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CampusId", "DataCriacao", "Senha" },
                values: new object[] { 7, new DateTime(2021, 7, 28, 19, 2, 29, 344, DateTimeKind.Utc).AddTicks(5792), "$2a$11$smv0odvV7bRkP0g5Bq.H8eJtnMYLTYS0LGLrQr7zNGm1d68fE/iOW" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CampusId", "DataCriacao", "Senha" },
                values: new object[] { 4, new DateTime(2021, 7, 28, 19, 2, 29, 591, DateTimeKind.Utc).AddTicks(193), "$2a$11$zHStYLnRpNL.59PZp7NH..kp2JNJQqH0YPaWQTweRmA56Fbk4Qive" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CampusId", "DataCriacao", "Senha" },
                values: new object[] { 2, new DateTime(2021, 7, 28, 19, 2, 29, 839, DateTimeKind.Utc).AddTicks(7614), "$2a$11$tJodLgpVS0Whdk0exV2qvO.aRNu5.kJX8pJ0/cwE.eYRtNdw6gYNS" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CampusId", "DataCriacao", "Senha" },
                values: new object[] { 4, new DateTime(2021, 7, 28, 19, 2, 30, 94, DateTimeKind.Utc).AddTicks(8214), "$2a$11$4DYX4J6HdhFsqGCKZG1jaOMsI9DliLJh4a7a.fhthhs/VNP/JsJmu" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CampusId", "DataCriacao", "Senha" },
                values: new object[] { 1, new DateTime(2021, 7, 28, 19, 2, 30, 344, DateTimeKind.Utc).AddTicks(249), "$2a$11$MqCwe6JTkMYGyptI.VEqC.SKYi8/dqzMOu/vMP4ulYr.7V479A6s2" });

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_CampusId",
                table: "Usuarios",
                column: "CampusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Campus_CampusId",
                table: "Usuarios",
                column: "CampusId",
                principalTable: "Campus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Campus_CampusId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_CampusId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "CampusId",
                table: "Usuarios");

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 18, 51, 16, 179, DateTimeKind.Utc).AddTicks(5471));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 18, 51, 16, 179, DateTimeKind.Utc).AddTicks(7412));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 18, 51, 16, 179, DateTimeKind.Utc).AddTicks(7418));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 18, 51, 16, 179, DateTimeKind.Utc).AddTicks(7420));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 18, 51, 16, 179, DateTimeKind.Utc).AddTicks(7422));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 18, 51, 16, 179, DateTimeKind.Utc).AddTicks(7424));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 18, 51, 16, 179, DateTimeKind.Utc).AddTicks(7426));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 18, 51, 16, 179, DateTimeKind.Utc).AddTicks(7427));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 18, 51, 16, 179, DateTimeKind.Utc).AddTicks(7429));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 18, 51, 16, 179, DateTimeKind.Utc).AddTicks(7431));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 18, 51, 16, 179, DateTimeKind.Utc).AddTicks(7433));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 18, 51, 16, 179, DateTimeKind.Utc).AddTicks(7435));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 18, 51, 16, 179, DateTimeKind.Utc).AddTicks(7436));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 18, 51, 16, 178, DateTimeKind.Utc).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 18, 51, 16, 178, DateTimeKind.Utc).AddTicks(5799));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 18, 51, 16, 178, DateTimeKind.Utc).AddTicks(5804));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 18, 51, 16, 178, DateTimeKind.Utc).AddTicks(5806));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 18, 51, 16, 178, DateTimeKind.Utc).AddTicks(5807));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 18, 51, 16, 178, DateTimeKind.Utc).AddTicks(5809));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 18, 51, 16, 178, DateTimeKind.Utc).AddTicks(5811));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 18, 51, 16, 178, DateTimeKind.Utc).AddTicks(5812));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 18, 51, 16, 178, DateTimeKind.Utc).AddTicks(5814));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 18, 51, 16, 178, DateTimeKind.Utc).AddTicks(5816));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 18, 51, 16, 178, DateTimeKind.Utc).AddTicks(5817));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 18, 51, 16, 179, DateTimeKind.Utc).AddTicks(3418));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 18, 51, 16, 179, DateTimeKind.Utc).AddTicks(3721));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 18, 51, 16, 179, DateTimeKind.Utc).AddTicks(3733));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 18, 51, 16, 179, DateTimeKind.Utc).AddTicks(3736));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 18, 51, 16, 179, DateTimeKind.Utc).AddTicks(3738));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 18, 51, 16, 179, DateTimeKind.Utc).AddTicks(3740));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 18, 51, 13, 289, DateTimeKind.Utc).AddTicks(1296));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 18, 51, 13, 289, DateTimeKind.Utc).AddTicks(2747));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 18, 51, 13, 289, DateTimeKind.Utc).AddTicks(2754));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 18, 51, 13, 289, DateTimeKind.Utc).AddTicks(2756));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 18, 51, 13, 289, DateTimeKind.Utc).AddTicks(2758));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 18, 51, 13, 289, DateTimeKind.Utc).AddTicks(2760));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 18, 51, 13, 289, DateTimeKind.Utc).AddTicks(2761));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 18, 51, 13, 289, DateTimeKind.Utc).AddTicks(2762));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 18, 51, 13, 289, DateTimeKind.Utc).AddTicks(2764));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 18, 51, 13, 289, DateTimeKind.Utc).AddTicks(2766));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("42b33f8c-f8e9-48fc-b355-bc613782b7dc"), new DateTime(2021, 7, 28, 18, 51, 16, 179, DateTimeKind.Utc).AddTicks(7872) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("b7cd8ecc-a243-4ac9-83be-56e9d31dde63"), new DateTime(2021, 7, 28, 18, 51, 16, 179, DateTimeKind.Utc).AddTicks(9049) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("be77012c-79c8-43aa-8d6b-5794b74ed493"), new DateTime(2021, 7, 28, 18, 51, 16, 179, DateTimeKind.Utc).AddTicks(9054) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("03d06982-37ba-4a33-a794-f67b6a274191"), new DateTime(2021, 7, 28, 18, 51, 16, 179, DateTimeKind.Utc).AddTicks(9057) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("420f436a-3365-4846-bc92-620d61250694"), new DateTime(2021, 7, 28, 18, 51, 16, 179, DateTimeKind.Utc).AddTicks(9075) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("90e63ca5-c3cc-41c2-9afc-93e637350589"), new DateTime(2021, 7, 28, 18, 51, 16, 179, DateTimeKind.Utc).AddTicks(9078) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("c54114f1-11d5-4dd3-9a74-53e65892fde7"), new DateTime(2021, 7, 28, 18, 51, 16, 179, DateTimeKind.Utc).AddTicks(9081) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("76951a85-050a-4581-8e8f-c8c48579f84e"), new DateTime(2021, 7, 28, 18, 51, 16, 179, DateTimeKind.Utc).AddTicks(9084) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("d005785f-3a79-426e-9707-3a4a23948361"), new DateTime(2021, 7, 28, 18, 51, 16, 179, DateTimeKind.Utc).AddTicks(9086) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("b3e9f92f-1188-4a6a-af19-75868d51829c"), new DateTime(2021, 7, 28, 18, 51, 16, 179, DateTimeKind.Utc).AddTicks(9088) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("aa8e648c-c6e1-45ce-a8a4-64917b31eeb5"), new DateTime(2021, 7, 28, 18, 51, 16, 179, DateTimeKind.Utc).AddTicks(9091) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("039cb1ab-3b5e-43ed-b448-d92972a50d8a"), new DateTime(2021, 7, 28, 18, 51, 16, 179, DateTimeKind.Utc).AddTicks(9093) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("eafb4c3c-d9db-45ae-ac31-e0fd5e286735"), new DateTime(2021, 7, 28, 18, 51, 16, 179, DateTimeKind.Utc).AddTicks(9099) });

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 18, 51, 16, 179, DateTimeKind.Utc).AddTicks(266));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 18, 51, 16, 179, DateTimeKind.Utc).AddTicks(2724));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 18, 51, 16, 179, DateTimeKind.Utc).AddTicks(2737));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 18, 51, 16, 179, DateTimeKind.Utc).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 18, 51, 16, 179, DateTimeKind.Utc).AddTicks(2742));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 18, 51, 16, 179, DateTimeKind.Utc).AddTicks(2744));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 18, 51, 16, 179, DateTimeKind.Utc).AddTicks(2746));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 18, 51, 16, 179, DateTimeKind.Utc).AddTicks(2748));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 18, 51, 16, 179, DateTimeKind.Utc).AddTicks(2766));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 18, 51, 16, 179, DateTimeKind.Utc).AddTicks(2768));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 18, 51, 16, 179, DateTimeKind.Utc).AddTicks(2769));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 18, 51, 16, 179, DateTimeKind.Utc).AddTicks(2771));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 18, 51, 16, 179, DateTimeKind.Utc).AddTicks(2773));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 18, 51, 16, 179, DateTimeKind.Utc).AddTicks(9391));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 18, 51, 16, 180, DateTimeKind.Utc).AddTicks(1055));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 18, 51, 16, 180, DateTimeKind.Utc).AddTicks(1059));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 18, 51, 16, 180, DateTimeKind.Utc).AddTicks(1061));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 18, 51, 16, 180, DateTimeKind.Utc).AddTicks(1063));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 18, 51, 16, 180, DateTimeKind.Utc).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 18, 51, 16, 180, DateTimeKind.Utc).AddTicks(1066));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 18, 51, 13, 292, DateTimeKind.Utc).AddTicks(643));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 28, 18, 51, 13, 292, DateTimeKind.Utc).AddTicks(1813));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 7, 28, 18, 51, 13, 621, DateTimeKind.Utc).AddTicks(2658), "$2a$11$c1m0NDW3yg5XMuCvaKBNh.SG98eLdsyPrkeOsuDKRQ76KiHlPhhkG" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 7, 28, 18, 51, 13, 904, DateTimeKind.Utc).AddTicks(4563), "$2a$11$G9VoCZUF9kzWBjwFXkw51.k0poWKK6ZQO1f9Mo4FF0MJAAFKosNe6" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 7, 28, 18, 51, 14, 183, DateTimeKind.Utc).AddTicks(4474), "$2a$11$DShakH2y1vZ/oYSbBzUSPuZuMajR1Nd5/PGDn3OvIMk1z18ng8Wiq" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 7, 28, 18, 51, 14, 480, DateTimeKind.Utc).AddTicks(5962), "$2a$11$P6ANiaq6pqz58HlbgllGzeTswTmNoCgT7XMzJ7vGDs7oMutnNu7bO" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 7, 28, 18, 51, 14, 755, DateTimeKind.Utc).AddTicks(230), "$2a$11$3h.beHuJbz0IZOWHdIVQjulwpML9K.P4ADCwDzII/bkLqZigF79Pq" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 7, 28, 18, 51, 15, 54, DateTimeKind.Utc).AddTicks(6159), "$2a$11$kLUuWVGxVxOIuR3fY3W5WOwAsKDPcqdoh55WEaby/x/cgEQwwIHLm" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 7, 28, 18, 51, 15, 336, DateTimeKind.Utc).AddTicks(9136), "$2a$11$DVpQrTsRekdkwgtihnkCHelMgWtaiR.UXCR.1u6WV9gdp5WXDozBa" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 7, 28, 18, 51, 15, 616, DateTimeKind.Utc).AddTicks(4402), "$2a$11$heVN6qXlIkWYxRB7IbtOGOaVlHA6.vcBNmVPuwBWyHf9Q3Xh.Gf8q" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 7, 28, 18, 51, 15, 899, DateTimeKind.Utc).AddTicks(4274), "$2a$11$OTK82CBhvegqfoPcJRxfEe2U0ukgicy8/YmLiqYk4D2szbMGLLTZq" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 7, 28, 18, 51, 16, 178, DateTimeKind.Utc).AddTicks(2375), "$2a$11$MP81gJUbiYMmca68cfeh2uN0v3w3bbDoqoIdsEWK96lBUNPvVmM2K" });
        }
    }
}
