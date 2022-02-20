using Microsoft.EntityFrameworkCore.Migrations;

namespace AuditApp.Migrations
{
    public partial class AddedaUserBaseprop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserLastname",
                schema: "Identity",
                table: "AspNetUsers",
                newName: "UserLastName");

            migrationBuilder.AddColumn<string>(
                name: "UserFirstName",
                schema: "Identity",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserFirstName",
                schema: "Identity",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "UserLastName",
                schema: "Identity",
                table: "AspNetUsers",
                newName: "UserLastname");
        }
    }
}
