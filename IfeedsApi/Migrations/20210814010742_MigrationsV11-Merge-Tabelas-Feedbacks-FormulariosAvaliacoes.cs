using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IfeedsApi.Migrations
{
    public partial class MigrationsV11MergeTabelasFeedbacksFormulariosAvaliacoes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Feedbacks_FormulariosAvaliacaos_FormularioAvaliacaoId",
                table: "Feedbacks");

            migrationBuilder.DropTable(
                name: "FormulariosAvaliacaos");

            migrationBuilder.DropIndex(
                name: "IX_Feedbacks_FormularioAvaliacaoId",
                table: "Feedbacks");

            migrationBuilder.DeleteData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DropColumn(
                name: "FormularioAvaliacaoId",
                table: "Feedbacks");

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Feedbacks",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<decimal>(
                name: "Nota",
                table: "Feedbacks",
                type: "decimal(5,1)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Titulo",
                table: "Feedbacks",
                type: "varchar(45)",
                maxLength: 45,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCriacao", "MediaAvaliacao" },
                values: new object[] { new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(4843), 3.5m });

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCriacao", "MediaAvaliacao" },
                values: new object[] { new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(5910), 3.0m });

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataCriacao", "MediaAvaliacao" },
                values: new object[] { new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(5914), 2.5m });

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataCriacao", "MediaAvaliacao" },
                values: new object[] { new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(5921), 3.0m });

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
                columns: new[] { "DataCriacao", "MediaAvaliacao" },
                values: new object[] { new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(5924), 3.5m });

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
                columns: new[] { "DataCriacao", "MediaAvaliacao" },
                values: new object[] { new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(5930), 3.5m });

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DataCriacao", "MediaAvaliacao" },
                values: new object[] { new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(5932), 0.0m });

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
                columns: new[] { "Codigo", "DataCriacao", "Descricao", "Nota", "Titulo" },
                values: new object[] { new Guid("58ba8ed7-b525-4542-ab74-aa3ee1be29d5"), new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(6281), "Banheiro com problema espelho quebrado", 3.50m, "Banheiro com problema" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Codigo", "DataCriacao", "Descricao", "Nota", "Titulo" },
                values: new object[] { new Guid("d0bedbc6-33d9-4b50-9a1d-0797a80db74c"), new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(7364), "Corrimão da Escada da COINF Descascando. Me cortei", 3m, "Problema no corrimão" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Codigo", "DataCriacao", "Descricao", "Nota", "Titulo" },
                values: new object[] { new Guid("608c2fc6-8669-4e01-b0d2-da8f20d507a0"), new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(7382), "Demora para Aprovar Máteria de TCC 1 - Estou com mais de um mes aguardando aprovação", 2.50m, "Dificuldade com TCC" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Codigo", "DataCriacao", "Descricao", "Nota", "Titulo" },
                values: new object[] { new Guid("40ae75ff-c404-4cb7-aa87-a13d71571ff9"), new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(7385), "Melhorias no Processo de Atendimento -  Deveriam automatizar mais os processos", 3m, "Sugestão de Melhoria" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Codigo", "DataCriacao", "Descricao", "Nota", "Titulo" },
                values: new object[] { new Guid("0222e997-6e53-4e12-ad3e-7a2665048245"), new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(7387), "Pessoal da Limpeza Top - Campus sempre muito bem conservado", 5m, "Elogio ao pessoal da limpeza" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Codigo", "DataCriacao", "Descricao", "Nota", "Titulo" },
                values: new object[] { new Guid("52e6e3de-b121-4f24-bc8c-bdcf86f2b190"), new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(7388), "Problemas com o Wifi do Campus - Internet lenta o que dificulta o acesso", 4m, "Problemas com WIFI" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Codigo", "DataCriacao", "Descricao", "Nota", "Titulo" },
                values: new object[] { new Guid("010bdb86-d460-47a4-a8b5-d8e34ad06eb1"), new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(7390), "Ifs Techday Top - Evento maravilhoso", 5m, "Elogio ao Techday" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Codigo", "DataCriacao", "Descricao", "Nota", "Titulo" },
                values: new object[] { new Guid("56a44130-51c8-490f-ad93-613523c90e1c"), new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(7392), "Semana Academica Divertida - Evento top", 4.50m, "Elogio ao evento" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Codigo", "DataCriacao", "Descricao", "Nota", "Titulo" },
                values: new object[] { new Guid("be3441f3-b8dd-471a-8ad2-a4943092ffaf"), new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(7400), "Semana Academica Algumas Palestras Massantes - palestras muito longas e cansativas", 2.50m, "Palestras cansativas na SEMAC" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Codigo", "DataCriacao", "Descricao", "Nota", "Titulo" },
                values: new object[] { new Guid("97d589e0-9501-433b-880d-b5aca23ab82f"), new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(7403), "Lab da COINF precisão limpar o filtro do Ar - nunca funciona corretamente", 3.50m, "Problema com Ar" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Codigo", "DataCriacao", "Descricao", "Nota", "Titulo" },
                values: new object[] { new Guid("87690238-e8e3-4e7e-b7eb-d89c539b153b"), new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(7406), "Lab de Redes com acustica prejudicada - Barulho da oficina atrapalha a aula", 2.50m, "Barulho no lab de redes" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Codigo", "DataCriacao", "Descricao", "Nota", "Titulo" },
                values: new object[] { new Guid("f8cc9a8b-4e3c-4b1c-8df8-4496cee4737e"), new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(7409), "Nenhum Livro de Loiane Groner - acervos desatualizados", 3m, "Sugestão de bibliográfia" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Codigo", "DataCriacao", "Descricao", "Nota", "Titulo" },
                values: new object[] { new Guid("62b2f636-0a23-4a95-b10c-b1709a6b9e93"), new DateTime(2021, 8, 14, 1, 7, 41, 929, DateTimeKind.Utc).AddTicks(7411), "Livro de Cálculo com página rasurada - o livro está com rasuras", 3m, "Rasuras no livro" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Feedbacks");

            migrationBuilder.DropColumn(
                name: "Nota",
                table: "Feedbacks");

            migrationBuilder.DropColumn(
                name: "Titulo",
                table: "Feedbacks");

            migrationBuilder.AddColumn<int>(
                name: "FormularioAvaliacaoId",
                table: "Feedbacks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "FormulariosAvaliacaos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Descricao = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    QuantidadeEstrelas = table.Column<decimal>(type: "decimal(5,1)", nullable: false),
                    Titulo = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormulariosAvaliacaos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCriacao", "MediaAvaliacao" },
                values: new object[] { new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(2159), 4.5m });

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCriacao", "MediaAvaliacao" },
                values: new object[] { new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(3443), 4.5m });

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataCriacao", "MediaAvaliacao" },
                values: new object[] { new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(3449), 3.5m });

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataCriacao", "MediaAvaliacao" },
                values: new object[] { new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(3451), 4.5m });

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
                columns: new[] { "DataCriacao", "MediaAvaliacao" },
                values: new object[] { new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(3454), 2.5m });

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
                columns: new[] { "DataCriacao", "MediaAvaliacao" },
                values: new object[] { new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(3456), 4.5m });

            migrationBuilder.UpdateData(
                table: "Avaliacoes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DataCriacao", "MediaAvaliacao" },
                values: new object[] { new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(3458), 3.0m });

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

            migrationBuilder.InsertData(
                table: "Avaliacoes",
                columns: new[] { "Id", "CampusId", "CategoriaId", "DataAtualizacao", "DataCriacao", "MediaAvaliacao", "Titulo" },
                values: new object[,]
                {
                    { 12, 1, 1, null, new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(3463), 2.5m, "Refeitório" },
                    { 13, 6, 1, null, new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(3464), 3.5m, "Quadra Poliesportiva" }
                });

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

            migrationBuilder.InsertData(
                table: "FormulariosAvaliacaos",
                columns: new[] { "Id", "DataAtualizacao", "DataCriacao", "Descricao", "QuantidadeEstrelas", "Titulo" },
                values: new object[,]
                {
                    { 13, null, new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(1661), "Livro de Cálculo com página rasurada - o livro está com rasuras", 3m, "Rasuras no livro" },
                    { 12, null, new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(1659), "Nenhum Livro de Loiane Groner - acervos desatualizados", 3m, "Sugestão de bibliográfia" },
                    { 1, null, new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(101), "Banheiro com problema espelho quebrado", 3.50m, "Banheiro com problema" },
                    { 2, null, new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(1630), "Corrimão da Escada da COINF Descascando. Me cortei", 3m, "Problema no corrimão" },
                    { 3, null, new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(1635), "Demora para Aprovar Máteria de TCC 1 - Estou com mais de um mes aguardando aprovação", 2.50m, "Dificuldade com TCC" },
                    { 4, null, new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(1638), "Melhorias no Processo de Atendimento -  Deveriam automatizar mais os processos", 3m, "Sugestão de Melhoria" },
                    { 5, null, new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(1640), "Pessoal da Limpeza Top - Campus sempre muito bem conservado", 5m, "Elogio ao pessoal da limpeza" },
                    { 6, null, new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(1643), "Problemas com o Wifi do Campus - Internet lenta o que dificulta o acesso", 4m, "Problemas com WIFI" },
                    { 7, null, new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(1645), "Ifs Techday Top - Evento maravilhoso", 5m, "Elogio ao Techday" },
                    { 8, null, new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(1646), "Semana Academica Divertida - Evento top", 4.50m, "Elogio ao evento" },
                    { 9, null, new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(1648), "Semana Academica Algumas Palestras Massantes - palestras muito longas e cansativas", 2.50m, "Palestras cansativas na SEMAC" },
                    { 10, null, new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(1656), "Lab da COINF precisão limpar o filtro do Ar - nunca funciona corretamente", 3.50m, "Problema com Ar" },
                    { 11, null, new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(1658), "Lab de Redes com acustica prejudicada - Barulho da oficina atrapalha a aula", 2.50m, "Barulho no lab de redes" }
                });

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

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Codigo", "DataCriacao", "FormularioAvaliacaoId" },
                values: new object[] { new Guid("9869569c-0e80-4d03-91ae-625f5746706d"), new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(3928), 1 });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Codigo", "DataCriacao", "FormularioAvaliacaoId" },
                values: new object[] { new Guid("fee394bd-308f-4b6f-99d9-958fe1c972eb"), new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(5265), 2 });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Codigo", "DataCriacao", "FormularioAvaliacaoId" },
                values: new object[] { new Guid("21fcd079-cfa0-48a4-b2fa-336bd35525f2"), new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(5273), 3 });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Codigo", "DataCriacao", "FormularioAvaliacaoId" },
                values: new object[] { new Guid("db966de6-68da-4188-88b5-cde7ae72d045"), new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(5275), 4 });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Codigo", "DataCriacao", "FormularioAvaliacaoId" },
                values: new object[] { new Guid("893b5c26-4a9c-4dff-a157-0f40580bbdee"), new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(5277), 5 });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Codigo", "DataCriacao", "FormularioAvaliacaoId" },
                values: new object[] { new Guid("cb1b92c3-80c7-4b93-9470-8b8f3ad724a0"), new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(5281), 6 });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Codigo", "DataCriacao", "FormularioAvaliacaoId" },
                values: new object[] { new Guid("085b9abd-4677-468d-b27e-18345be407c9"), new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(5283), 7 });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Codigo", "DataCriacao", "FormularioAvaliacaoId" },
                values: new object[] { new Guid("df87e857-fab3-4797-8032-7ec7c55ccc23"), new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(5300), 8 });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Codigo", "DataCriacao", "FormularioAvaliacaoId" },
                values: new object[] { new Guid("135ec232-64b3-4793-9e1e-335909f77aa5"), new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(5305), 9 });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Codigo", "DataCriacao", "FormularioAvaliacaoId" },
                values: new object[] { new Guid("8be5c4ff-50f1-43df-81cb-f8046f5df350"), new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(5307), 10 });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Codigo", "DataCriacao", "FormularioAvaliacaoId" },
                values: new object[] { new Guid("4bd8fadf-7a0b-4424-a124-b15f023f4b93"), new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(5309), 11 });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Codigo", "DataCriacao", "FormularioAvaliacaoId" },
                values: new object[] { new Guid("e12aaac0-44e5-4995-8dc8-19f5d26135a5"), new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(5312), 13 });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Codigo", "DataCriacao", "FormularioAvaliacaoId" },
                values: new object[] { new Guid("77133dd7-0530-4d27-8eca-b88acfe73086"), new DateTime(2021, 8, 12, 0, 47, 46, 301, DateTimeKind.Utc).AddTicks(5314), 12 });

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_FormularioAvaliacaoId",
                table: "Feedbacks",
                column: "FormularioAvaliacaoId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Feedbacks_FormulariosAvaliacaos_FormularioAvaliacaoId",
                table: "Feedbacks",
                column: "FormularioAvaliacaoId",
                principalTable: "FormulariosAvaliacaos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
