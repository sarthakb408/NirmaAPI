using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusDetails.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Statuss",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    status_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    appointment_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    con_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    con_loaded = table.Column<bool>(type: "bit", nullable: false),
                    container_status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    destination = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    departure_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ship_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    arriving_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    receiver_delivery_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    con_loaded_date = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuss", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Statuss");
        }
    }
}
