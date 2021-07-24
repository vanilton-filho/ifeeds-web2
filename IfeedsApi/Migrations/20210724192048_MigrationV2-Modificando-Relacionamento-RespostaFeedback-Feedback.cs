using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IfeedsApi.Migrations
{
    public partial class MigrationV2ModificandoRelacionamentoRespostaFeedbackFeedback : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RespostasFeedbacks_Feedbacks_FeedbackId",
                table: "RespostasFeedbacks");

            migrationBuilder.DropIndex(
                name: "IX_RespostasFeedbacks_FeedbackId",
                table: "RespostasFeedbacks");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCriacao",
                table: "Roles",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValueSql: "(utc_timestamp())");

            migrationBuilder.AlterColumn<int>(
                name: "FeedbackId",
                table: "RespostasFeedbacks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCriacao",
                table: "FormulariosAvaliacaos",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValueSql: "(utc_timestamp())");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCriacao",
                table: "Contatos",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValueSql: "(utc_timestamp())");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCriacao",
                table: "Categorias",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValueSql: "(utc_timestamp())");

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 84, DateTimeKind.Utc).AddTicks(8003));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 84, DateTimeKind.Utc).AddTicks(9254));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 84, DateTimeKind.Utc).AddTicks(9259));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 84, DateTimeKind.Utc).AddTicks(9261));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 84, DateTimeKind.Utc).AddTicks(9263));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 84, DateTimeKind.Utc).AddTicks(9265));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 84, DateTimeKind.Utc).AddTicks(9267));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 84, DateTimeKind.Utc).AddTicks(9268));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 84, DateTimeKind.Utc).AddTicks(9270));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 84, DateTimeKind.Utc).AddTicks(9271));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 84, DateTimeKind.Utc).AddTicks(9273));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 84, DateTimeKind.Utc).AddTicks(9274));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 84, DateTimeKind.Utc).AddTicks(9276));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 78, DateTimeKind.Utc).AddTicks(6943));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 78, DateTimeKind.Utc).AddTicks(7728));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 78, DateTimeKind.Utc).AddTicks(7731));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 78, DateTimeKind.Utc).AddTicks(7733));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 78, DateTimeKind.Utc).AddTicks(7734));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 78, DateTimeKind.Utc).AddTicks(7736));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 78, DateTimeKind.Utc).AddTicks(7737));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 78, DateTimeKind.Utc).AddTicks(7738));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 78, DateTimeKind.Utc).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 78, DateTimeKind.Utc).AddTicks(7741));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 78, DateTimeKind.Utc).AddTicks(7743));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 84, DateTimeKind.Utc).AddTicks(7690));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 84, DateTimeKind.Utc).AddTicks(7716));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 84, DateTimeKind.Utc).AddTicks(7718));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 84, DateTimeKind.Utc).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 84, DateTimeKind.Utc).AddTicks(7721));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 84, DateTimeKind.Utc).AddTicks(7722));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 76, DateTimeKind.Utc).AddTicks(7805));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 76, DateTimeKind.Utc).AddTicks(9409));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 76, DateTimeKind.Utc).AddTicks(9418));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 76, DateTimeKind.Utc).AddTicks(9420));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 76, DateTimeKind.Utc).AddTicks(9421));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 76, DateTimeKind.Utc).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 76, DateTimeKind.Utc).AddTicks(9424));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 76, DateTimeKind.Utc).AddTicks(9426));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 76, DateTimeKind.Utc).AddTicks(9428));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 76, DateTimeKind.Utc).AddTicks(9429));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("b8a58490-b793-4e6d-aa79-926516853245"), new DateTime(2021, 7, 24, 19, 20, 47, 85, DateTimeKind.Utc).AddTicks(5327) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("e1e14593-b780-4091-9dbc-180e3c6c6fd5"), new DateTime(2021, 7, 24, 19, 20, 47, 85, DateTimeKind.Utc).AddTicks(6875) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("3b513805-28a3-462e-8ff9-5321fe341ed0"), new DateTime(2021, 7, 24, 19, 20, 47, 85, DateTimeKind.Utc).AddTicks(6888) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("d9fdac75-fca4-458d-ae3a-90d12d4578ad"), new DateTime(2021, 7, 24, 19, 20, 47, 85, DateTimeKind.Utc).AddTicks(6893) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("083b0772-3ad6-4071-bd4a-d7d8093d2ff1"), new DateTime(2021, 7, 24, 19, 20, 47, 85, DateTimeKind.Utc).AddTicks(6902) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("fef4d9ab-3d28-4266-9ff7-83583d573af4"), new DateTime(2021, 7, 24, 19, 20, 47, 85, DateTimeKind.Utc).AddTicks(6946) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("3e3636d0-cfad-417f-839d-de512c01d398"), new DateTime(2021, 7, 24, 19, 20, 47, 85, DateTimeKind.Utc).AddTicks(6952) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("a435fa7e-b9be-49e5-befc-d766f8f76195"), new DateTime(2021, 7, 24, 19, 20, 47, 85, DateTimeKind.Utc).AddTicks(6954) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("3cddf45f-869f-4718-815c-99d93a722972"), new DateTime(2021, 7, 24, 19, 20, 47, 85, DateTimeKind.Utc).AddTicks(6957) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("c7ef0e2b-9992-469a-96ea-2dfb02d5cb0d"), new DateTime(2021, 7, 24, 19, 20, 47, 85, DateTimeKind.Utc).AddTicks(6965) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("82b23db1-a950-47a5-8b98-46697c0693e7"), new DateTime(2021, 7, 24, 19, 20, 47, 85, DateTimeKind.Utc).AddTicks(6968) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("643a89ed-d1a2-460f-9347-7c3bd50adcb3"), new DateTime(2021, 7, 24, 19, 20, 47, 85, DateTimeKind.Utc).AddTicks(6972) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("87037dab-2f79-485b-9464-c19d890c8bf7"), new DateTime(2021, 7, 24, 19, 20, 47, 85, DateTimeKind.Utc).AddTicks(6975) });

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 78, DateTimeKind.Utc).AddTicks(8129));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 78, DateTimeKind.Utc).AddTicks(9098));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 78, DateTimeKind.Utc).AddTicks(9102));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 78, DateTimeKind.Utc).AddTicks(9104));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 78, DateTimeKind.Utc).AddTicks(9106));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 78, DateTimeKind.Utc).AddTicks(9107));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 78, DateTimeKind.Utc).AddTicks(9109));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 78, DateTimeKind.Utc).AddTicks(9110));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 78, DateTimeKind.Utc).AddTicks(9112));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 78, DateTimeKind.Utc).AddTicks(9115));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 78, DateTimeKind.Utc).AddTicks(9116));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 78, DateTimeKind.Utc).AddTicks(9118));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 78, DateTimeKind.Utc).AddTicks(9119));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 85, DateTimeKind.Utc).AddTicks(9693));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 86, DateTimeKind.Utc).AddTicks(2495));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 86, DateTimeKind.Utc).AddTicks(2512));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 86, DateTimeKind.Utc).AddTicks(2515));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataCriacao", "FeedbackId" },
                values: new object[] { new DateTime(2021, 7, 24, 19, 20, 47, 86, DateTimeKind.Utc).AddTicks(2519), 3 });

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 86, DateTimeKind.Utc).AddTicks(2521));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 86, DateTimeKind.Utc).AddTicks(2523));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 78, DateTimeKind.Utc).AddTicks(4267));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 78, DateTimeKind.Utc).AddTicks(5288));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 78, DateTimeKind.Utc).AddTicks(5565));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 78, DateTimeKind.Utc).AddTicks(6770));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 78, DateTimeKind.Utc).AddTicks(6776));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 78, DateTimeKind.Utc).AddTicks(6778));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 78, DateTimeKind.Utc).AddTicks(6779));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 78, DateTimeKind.Utc).AddTicks(6781));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 78, DateTimeKind.Utc).AddTicks(6783));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 78, DateTimeKind.Utc).AddTicks(6785));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 78, DateTimeKind.Utc).AddTicks(6789));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 78, DateTimeKind.Utc).AddTicks(6792));

            migrationBuilder.CreateIndex(
                name: "IX_RespostasFeedbacks_FeedbackId",
                table: "RespostasFeedbacks",
                column: "FeedbackId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_RespostasFeedbacks_Feedbacks_FeedbackId",
                table: "RespostasFeedbacks",
                column: "FeedbackId",
                principalTable: "Feedbacks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RespostasFeedbacks_Feedbacks_FeedbackId",
                table: "RespostasFeedbacks");

            migrationBuilder.DropIndex(
                name: "IX_RespostasFeedbacks_FeedbackId",
                table: "RespostasFeedbacks");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCriacao",
                table: "Roles",
                type: "datetime(6)",
                nullable: false,
                defaultValueSql: "(utc_timestamp())",
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<int>(
                name: "FeedbackId",
                table: "RespostasFeedbacks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCriacao",
                table: "FormulariosAvaliacaos",
                type: "datetime(6)",
                nullable: false,
                defaultValueSql: "(utc_timestamp())",
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCriacao",
                table: "Contatos",
                type: "datetime(6)",
                nullable: false,
                defaultValueSql: "(utc_timestamp())",
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCriacao",
                table: "Categorias",
                type: "datetime(6)",
                nullable: false,
                defaultValueSql: "(utc_timestamp())",
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(743));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(1673));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(1676));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(1677));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(1678));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(1679));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(1680));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(1681));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(1683));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(1684));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(1685));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(1686));

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(1688));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(4840));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(5414));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(5417));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(5418));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(5419));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(5421));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(5423));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(5424));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(5426));

            migrationBuilder.UpdateData(
                table: "Campus",
                keyColumn: "Id",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(5427));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(517));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(535));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(536));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(537));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(539));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(540));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 407, DateTimeKind.Utc).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 408, DateTimeKind.Utc).AddTicks(195));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 408, DateTimeKind.Utc).AddTicks(200));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 408, DateTimeKind.Utc).AddTicks(201));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 408, DateTimeKind.Utc).AddTicks(202));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 408, DateTimeKind.Utc).AddTicks(204));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 408, DateTimeKind.Utc).AddTicks(205));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 408, DateTimeKind.Utc).AddTicks(206));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 408, DateTimeKind.Utc).AddTicks(207));

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 408, DateTimeKind.Utc).AddTicks(208));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("2e8e624e-fa8a-451b-aa8f-4f557d6da49a"), new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(6356) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("fd4e3c65-4df1-435e-8396-c2042e3561cc"), new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(7194) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("f65fac06-8eab-4b6f-9189-fbf0b9e469ed"), new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(7199) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("2688f73b-b53f-4aa0-a58a-366bfded5868"), new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(7201) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("81f76f55-f8fc-43b5-83f2-0748c4c61382"), new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(7214) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("264b7ce5-7cdb-4d9b-a978-b3958eec0af3"), new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(7216) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("2076adfd-e6bb-4e62-8282-e11295443711"), new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(7218) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("7036489b-6ed2-402f-9254-92a71fb261d2"), new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(7220) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("5652a8e0-e7f0-411e-a2d7-08cbbaf2d19a"), new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(7221) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("45d9357d-c889-4eed-8ede-4cbebe52c17a"), new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(7223) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("4d69868b-4aeb-4c7c-a17c-e1b71ea6ad21"), new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(7225) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("debb667c-0472-4dc1-852b-a616aca99422"), new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(7226) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Codigo", "DataCriacao" },
                values: new object[] { new Guid("a114a4e3-41b0-4917-b2dc-9eb9171ca90d"), new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(7232) });

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(5762));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(6479));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(6482));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(6483));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(6484));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(6485));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(6487));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(6488));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(6489));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(6490));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(6491));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(6493));

            migrationBuilder.UpdateData(
                table: "FormulariosAvaliacaos",
                keyColumn: "Id",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(6494));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(7440));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(8127));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(8129));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataCriacao", "FeedbackId" },
                values: new object[] { new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(8132), 8 });

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(8133));

            migrationBuilder.UpdateData(
                table: "RespostasFeedbacks",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 413, DateTimeKind.Utc).AddTicks(8134));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(2809));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(3627));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(3868));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(4705));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(4708));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(4712));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(4713));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(4714));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(4717));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2021, 7, 17, 19, 0, 29, 409, DateTimeKind.Utc).AddTicks(4718));

            migrationBuilder.CreateIndex(
                name: "IX_RespostasFeedbacks_FeedbackId",
                table: "RespostasFeedbacks",
                column: "FeedbackId");

            migrationBuilder.AddForeignKey(
                name: "FK_RespostasFeedbacks_Feedbacks_FeedbackId",
                table: "RespostasFeedbacks",
                column: "FeedbackId",
                principalTable: "Feedbacks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
