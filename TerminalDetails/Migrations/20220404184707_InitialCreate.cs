using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TerminalDetails.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Terminals",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    terminal_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    terminal_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    terminal_mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    terminal_email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    terminal_username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    terminal_password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    terminal_location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    zipcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    terminal_logo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    terminal_status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    token = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Terminals", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Terminals");
        }
    }
}
