using Microsoft.EntityFrameworkCore.Migrations;

namespace AuditApp.Migrations
{
    public partial class NormalizedUserProps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Apellido",
                schema: "Identity",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Nombre",
                schema: "Identity",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "Telefono",
                schema: "Identity",
                table: "AspNetUsers",
                newName: "UserLastname");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserLastname",
                schema: "Identity",
                table: "AspNetUsers",
                newName: "Telefono");

            migrationBuilder.AddColumn<string>(
                name: "Apellido",
                schema: "Identity",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                schema: "Identity",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
