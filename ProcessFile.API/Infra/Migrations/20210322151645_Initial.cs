using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProcessFile.API.Infra.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ColumnControls",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColumnPosition = table.Column<int>(type: "int", nullable: false),
                    Start = table.Column<int>(type: "int", nullable: false),
                    End = table.Column<int>(type: "int", nullable: false),
                    Size = table.Column<int>(type: "int", nullable: false),
                    Field = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FieldCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Typing = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColumnControls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Process",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Process", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sulamericas",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sequencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Carteirinha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataRegistro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mais = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Valor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodigoAleatorio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nascimento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CNPJ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomeColaborador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProcessId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sulamericas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sulamericas_Process_ProcessId",
                        column: x => x.ProcessId,
                        principalTable: "Process",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Unimed",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoServico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataConsumo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodigoDependenteSistema = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Crm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValorDespesa = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Amb = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ControleUnimedLotacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ControleUnimedAcomodacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pago = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProcessId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unimed", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Unimed_Process_ProcessId",
                        column: x => x.ProcessId,
                        principalTable: "Process",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "ColumnControls",
                columns: new[] { "Id", "ColumnPosition", "Company", "End", "Field", "FieldCode", "Size", "Start", "Typing" },
                values: new object[,]
                {
                    { 1L, 0, "Sulamerica", 1, "Sequência", "sequencia", 2, 0, "Texto" },
                    { 21L, 9, "Unimed", 83, "Controle Unimed Lotação", "controleUnimedLotacao", 8, 76, "Texto" },
                    { 20L, 8, "Unimed", 75, "AMB", "amb", 8, 68, "Texto" },
                    { 19L, 7, "Unimed", 67, "Valor da Despesa", "valorDespesa", 12, 56, "Decimal" },
                    { 18L, 6, "Unimed", 55, "CRM", "crm", 8, 48, "Texto" },
                    { 17L, 5, "Unimed", 47, "Nome", "nome", 30, 18, "Texto" },
                    { 16L, 4, "Unimed", 17, "Código do Dependente no Sistema", "codigoDependenteSistema", 2, 16, "Texto" },
                    { 15L, 3, "Unimed", 15, "NE", "ne", 6, 10, "Texto" },
                    { 14L, 2, "Unimed", 9, "Data do Consumo", "dataConsumo", 8, 2, "Data" },
                    { 13L, 1, "Unimed", 1, "Tipo de Serviço", "tipoServico", 2, 0, "Texto" },
                    { 22L, 10, "Unimed", 84, "Controle Unimed Acomodação", "controleUnimedAcomodacao", 8, 84, "Texto" },
                    { 12L, 11, "Sulamerica", 161, "NE", "ne", 9, 153, "Texto" },
                    { 10L, 9, "Sulamerica", 120, "CNPJ", "cnpj", 15, 106, "Texto" },
                    { 9L, 8, "Sulamerica", 105, "Nascimento", "nascimento", 10, 96, "Data" },
                    { 8L, 7, "Sulamerica", 95, "Codigo Aleatorio", "codigoAleatorio", 5, 91, "Decimal" },
                    { 7L, 6, "Sulamerica", 90, "Valor", "valor", 15, 76, "Decimal" },
                    { 6L, 5, "Sulamerica", 75, "Mais", "mais", 1, 75, "Texto" },
                    { 5L, 4, "Sulamerica", 74, "Data do Registro", "dataRegistro", 7, 68, "Texto" },
                    { 4L, 3, "Sulamerica", 67, "CPF", "cpf", 11, 57, "Texto" },
                    { 3L, 2, "Sulamerica", 56, "Nome", "nome", 38, 18, "Texto" },
                    { 2L, 1, "Sulamerica", 17, "Carteirinha", "carteirinha", 16, 2, "Texto" },
                    { 11L, 10, "Sulamerica", 152, "Nome do Colaborador", "nomeColaborador", 32, 121, "Texto" },
                    { 23L, 11, "Unimed", 85, "Pago ou Não Pago", "pago", 1, 85, "Texto" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sulamericas_ProcessId",
                table: "Sulamericas",
                column: "ProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_Unimed_ProcessId",
                table: "Unimed",
                column: "ProcessId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ColumnControls");

            migrationBuilder.DropTable(
                name: "Sulamericas");

            migrationBuilder.DropTable(
                name: "Unimed");

            migrationBuilder.DropTable(
                name: "Process");
        }
    }
}
