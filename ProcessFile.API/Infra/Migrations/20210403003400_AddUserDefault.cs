using Microsoft.EntityFrameworkCore.Migrations;

namespace ProcessFile.API.Infra.Migrations
{
    public partial class AddUserDefault : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Avatar", "Email", "Name", "Password", "UserStatus" },
                values: new object[] { 1L, null, "adm@adm.com", "Administrador", "B09C600FDDC573F117449B3723F23D64", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L);
        }
    }
}
