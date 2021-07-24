using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IfeedsApi.Migrations
{
    public partial class MigrationV3NotNullFeedbackId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RespostasFeedbacks_Feedbacks_FeedbackId",
                table: "RespostasFeedbacks");

            migrationBuilder.AlterColumn<int>(
                name: "FeedbackId",
                table: "RespostasFeedbacks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_RespostasFeedbacks_Feedbacks_FeedbackId",
                table: "RespostasFeedbacks",
                column: "FeedbackId",
                principalTable: "Feedbacks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RespostasFeedbacks_Feedbacks_FeedbackId",
                table: "RespostasFeedbacks");

            migrationBuilder.AlterColumn<int>(
                name: "FeedbackId",
                table: "RespostasFeedbacks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
                column: "DataCriacao",
                value: new DateTime(2021, 7, 24, 19, 20, 47, 86, DateTimeKind.Utc).AddTicks(2519));

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

            migrationBuilder.AddForeignKey(
                name: "FK_RespostasFeedbacks_Feedbacks_FeedbackId",
                table: "RespostasFeedbacks",
                column: "FeedbackId",
                principalTable: "Feedbacks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
