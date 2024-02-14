using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jale2.Migrations
{
    public partial class addedJaleandAsiman : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Jales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jales", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Asimans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JaleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asimans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Asimans_Jales_JaleId",
                        column: x => x.JaleId,
                        principalTable: "Jales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Asimans_JaleId",
                table: "Asimans",
                column: "JaleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Asimans");

            migrationBuilder.DropTable(
                name: "Jales");
        }
    }
}
