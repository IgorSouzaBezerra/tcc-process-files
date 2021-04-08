using Microsoft.EntityFrameworkCore.Migrations;

namespace ProcessFile.API.Infra.Migrations
{
    public partial class AddColumnProcessStatusInProcess : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProcesStatus",
                table: "Process",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProcesStatus",
                table: "Process");
        }
    }
}
