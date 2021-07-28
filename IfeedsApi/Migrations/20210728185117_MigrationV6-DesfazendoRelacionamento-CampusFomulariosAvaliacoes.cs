using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IfeedsApi.Migrations
{
    public partial class MigrationV6DesfazendoRelacionamentoCampusFomulariosAvaliacoes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CampusFormularioAvaliacao");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 20, 26, 24, 889, DateTimeKind.Utc).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 20, 26, 24, 889, DateTimeKind.Utc).AddTicks(5871));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 20, 26, 24, 889, DateTimeKind.Utc).AddTicks(5875));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 20, 26, 24, 889, DateTimeKind.Utc).AddTicks(5877));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 20, 26, 24, 889, DateTimeKind.Utc).AddTicks(5879));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 20, 26, 24, 889, DateTimeKind.Utc).AddTicks(5881));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 20, 26, 24, 889, DateTimeKind.Utc).AddTicks(5883));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 20, 26, 24, 889, DateTimeKind.Utc).AddTicks(5884));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 20, 26, 24, 889, DateTimeKind.Utc).AddTicks(5886));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 20, 26, 24, 889, DateTimeKind.Utc).AddTicks(5888));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 20, 26, 24, 889, DateTimeKind.Utc).AddTicks(5890));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 20, 26, 24, 889, DateTimeKind.Utc).AddTicks(5892));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 20, 26, 24, 889, DateTimeKind.Utc).AddTicks(5894));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 20, 26, 24, 882, DateTimeKind.Utc).AddTicks(2140));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 20, 26, 24, 882, DateTimeKind.Utc).AddTicks(3869));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 20, 26, 24, 882, DateTimeKind.Utc).AddTicks(3875));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 20, 26, 24, 882, DateTimeKind.Utc).AddTicks(3878));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 20, 26, 24, 882, DateTimeKind.Utc).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 20, 26, 24, 882, DateTimeKind.Utc).AddTicks(3881));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 20, 26, 24, 882, DateTimeKind.Utc).AddTicks(4003));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 20, 26, 24, 882, DateTimeKind.Utc).AddTicks(4005));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 20, 26, 24, 882, DateTimeKind.Utc).AddTicks(4007));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 20, 26, 24, 882, DateTimeKind.Utc).AddTicks(4008));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 20, 26, 24, 882, DateTimeKind.Utc).AddTicks(4010));

            migrationBuilder.InsertData(
                table: "CampusFormularioAvaliacao",
                columns: new[] { "CampusId", "FormulariosAvaliacoesId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 10, 9 },
                    { 9, 10 },
                    { 8, 8 },
                    { 7, 6 },
                    { 6, 7 },
                    { 5, 5 },
                    { 4, 3 },
                    { 3, 4 },
                    { 2, 2 }
                });

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 20, 26, 24, 889, DateTimeKind.Utc).AddTicks(4111));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 20, 26, 24, 889, DateTimeKind.Utc).AddTicks(4132));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 20, 26, 24, 889, DateTimeKind.Utc).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 20, 26, 24, 889, DateTimeKind.Utc).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 20, 26, 24, 889, DateTimeKind.Utc).AddTicks(4137));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 20, 26, 24, 889, DateTimeKind.Utc).AddTicks(4158));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 20, 26, 21, 954, DateTimeKind.Utc).AddTicks(1551));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 20, 26, 21, 954, DateTimeKind.Utc).AddTicks(3017));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 20, 26, 21, 954, DateTimeKind.Utc).AddTicks(3025));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 20, 26, 21, 954, DateTimeKind.Utc).AddTicks(3028));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 20, 26, 21, 954, DateTimeKind.Utc).AddTicks(3030));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 20, 26, 21, 954, DateTimeKind.Utc).AddTicks(3031));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 20, 26, 21, 954, DateTimeKind.Utc).AddTicks(3033));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 20, 26, 21, 954, DateTimeKind.Utc).AddTicks(3035));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 20, 26, 21, 954, DateTimeKind.Utc).AddTicks(3036));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 20, 26, 21, 954, DateTimeKind.Utc).AddTicks(3038));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("3891b54b-256c-453a-87b6-1a41a7652f41"), new DateTime(2021, 7, 24, 20, 26, 24, 890, DateTimeKind.Utc).AddTicks(3861) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("556a9dd1-6100-4350-a187-16fd57014695"), new DateTime(2021, 7, 24, 20, 26, 24, 890, DateTimeKind.Utc).AddTicks(5754) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("9f3008af-98f5-4747-b581-533e796d3a8e"), new DateTime(2021, 7, 24, 20, 26, 24, 890, DateTimeKind.Utc).AddTicks(5763) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("a896b911-3255-44fd-bd2d-2538c13140b1"), new DateTime(2021, 7, 24, 20, 26, 24, 890, DateTimeKind.Utc).AddTicks(5766) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("f36f3355-d34f-4993-a414-f8d5857a5fbd"), new DateTime(2021, 7, 24, 20, 26, 24, 890, DateTimeKind.Utc).AddTicks(5769) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("9ea0a1a4-a640-410a-92eb-5e44d10faae1"), new DateTime(2021, 7, 24, 20, 26, 24, 890, DateTimeKind.Utc).AddTicks(5788) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("596d1995-f379-459a-9cb9-da3802c7f9ae"), new DateTime(2021, 7, 24, 20, 26, 24, 890, DateTimeKind.Utc).AddTicks(5790) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("1c701885-61c0-4fb5-bb23-52fd9c0fd916"), new DateTime(2021, 7, 24, 20, 26, 24, 890, DateTimeKind.Utc).AddTicks(5793) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("a9d8864d-5217-4753-a0c4-6b688e6f6b96"), new DateTime(2021, 7, 24, 20, 26, 24, 890, DateTimeKind.Utc).AddTicks(5795) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("2bbc4a08-5073-45c7-a206-4798e7b96952"), new DateTime(2021, 7, 24, 20, 26, 24, 890, DateTimeKind.Utc).AddTicks(5797) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("33ce240d-1fca-494f-84db-1b1a62885941"), new DateTime(2021, 7, 24, 20, 26, 24, 890, DateTimeKind.Utc).AddTicks(5799) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("b0f3999b-2449-406a-b1dc-f95c5b47d79f"), new DateTime(2021, 7, 24, 20, 26, 24, 890, DateTimeKind.Utc).AddTicks(5802) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("a6501348-7b63-4996-babe-8a255a5589be"), new DateTime(2021, 7, 24, 20, 26, 24, 890, DateTimeKind.Utc).AddTicks(5805) });

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 20, 26, 24, 882, DateTimeKind.Utc).AddTicks(5054));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 20, 26, 24, 882, DateTimeKind.Utc).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 20, 26, 24, 882, DateTimeKind.Utc).AddTicks(6618));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 20, 26, 24, 882, DateTimeKind.Utc).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 20, 26, 24, 882, DateTimeKind.Utc).AddTicks(6623));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 20, 26, 24, 882, DateTimeKind.Utc).AddTicks(6625));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 20, 26, 24, 882, DateTimeKind.Utc).AddTicks(6627));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 20, 26, 24, 882, DateTimeKind.Utc).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 20, 26, 24, 882, DateTimeKind.Utc).AddTicks(6641));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 20, 26, 24, 882, DateTimeKind.Utc).AddTicks(6642));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 20, 26, 24, 882, DateTimeKind.Utc).AddTicks(6644));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 20, 26, 24, 882, DateTimeKind.Utc).AddTicks(6646));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 20, 26, 24, 882, DateTimeKind.Utc).AddTicks(6647));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 20, 26, 24, 890, DateTimeKind.Utc).AddTicks(6214));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 20, 26, 24, 890, DateTimeKind.Utc).AddTicks(7857));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 20, 26, 24, 890, DateTimeKind.Utc).AddTicks(7862));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 20, 26, 24, 890, DateTimeKind.Utc).AddTicks(7864));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 20, 26, 24, 890, DateTimeKind.Utc).AddTicks(7865));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 20, 26, 24, 890, DateTimeKind.Utc).AddTicks(7866));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 20, 26, 24, 890, DateTimeKind.Utc).AddTicks(7868));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 20, 26, 21, 955, DateTimeKind.Utc).AddTicks(8745));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 20, 26, 21, 955, DateTimeKind.Utc).AddTicks(9848));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 7, 24, 20, 26, 22, 249, DateTimeKind.Utc).AddTicks(2630), "$2a$11$.JdbsVVpQyQ4gGpEGdWhBuQ3C/.gWm8pH/36ZI32nmDi7LMjOj7x2" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 7, 24, 20, 26, 22, 537, DateTimeKind.Utc).AddTicks(4770), "$2a$11$az9udGBUJp1tqQ1odqfaAuOh44Lpq4.T7NJwDnSZwgRVFixZIsnPu" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 7, 24, 20, 26, 22, 814, DateTimeKind.Utc).AddTicks(7924), "$2a$11$XBzGGCVzdQzhbApqJmjTa.qaTvr5pG8XO1s21JVCpB0muessrIVM2" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 7, 24, 20, 26, 23, 90, DateTimeKind.Utc).AddTicks(4538), "$2a$11$yXo3BjqsH7x2zxabbVPnweZP6WCiQ0TAiT9lKmRj5TlbS9qK8VT7y" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 7, 24, 20, 26, 23, 407, DateTimeKind.Utc).AddTicks(9200), "$2a$11$ASLUUrYHqqTNC6MQQk4i0utjdWNzZdKZSAroJmazqRUoGX1m0P4vW" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 7, 24, 20, 26, 23, 709, DateTimeKind.Utc).AddTicks(5045), "$2a$11$ij6VsWZw0sK7uorkVvErA.A4hD8HG0CxZUJn/qMAodi81bWv7Vvqy" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 7, 24, 20, 26, 24, 40, DateTimeKind.Utc).AddTicks(88), "$2a$11$OwwHPGF.xqP3nCVf8ABcG.rYEVUyqXyNdEIEX86c67bg0W0LsgZSS" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 7, 24, 20, 26, 24, 323, DateTimeKind.Utc).AddTicks(6082), "$2a$11$Q8XciZHy9PtHvIsfUo3tyOi91feZRlvbZUJvxLFgIOtyPMelybqvK" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 7, 24, 20, 26, 24, 601, DateTimeKind.Utc).AddTicks(5004), "$2a$11$RvvZdxCean8U7rRoMfEOleBxH5N/WrTrf7lY3o8ZbgJH03x9.L.AG" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DataCriacao", "Senha" },
                values: new object[] { new DateTime(2021, 7, 24, 20, 26, 24, 882, DateTimeKind.Utc).AddTicks(1178), "$2a$11$rG8uyO4xrTvPFggZtzgcN.1MuXMeb/MRvJdoKG6AgPaQmV7sBFDUi" });

            migrationBuilder.CreateIndex(
                name: "IX_CampusFormularioAvaliacao_FormulariosAvaliacoesId",
                table: "CampusFormularioAvaliacao",
                column: "FormulariosAvaliacoesId");
        }
    }
}
