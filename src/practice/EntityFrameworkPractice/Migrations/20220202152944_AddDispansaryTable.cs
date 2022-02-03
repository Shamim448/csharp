using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkPractice.Migrations
{
    public partial class AddDispansaryTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dispansary",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dispansary", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DispansaryMedicinInfo",
                columns: table => new
                {
                    MedicinInfoID = table.Column<int>(type: "int", nullable: false),
                    PharmecyID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DispansaryMedicinInfo", x => new { x.MedicinInfoID, x.PharmecyID });
                    table.ForeignKey(
                        name: "FK_DispansaryMedicinInfo_Dispansary_PharmecyID",
                        column: x => x.PharmecyID,
                        principalTable: "Dispansary",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DispansaryMedicinInfo_MedicinInfo_MedicinInfoID",
                        column: x => x.MedicinInfoID,
                        principalTable: "MedicinInfo",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DispansaryMedicinInfo_PharmecyID",
                table: "DispansaryMedicinInfo",
                column: "PharmecyID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DispansaryMedicinInfo");

            migrationBuilder.DropTable(
                name: "Dispansary");
        }
    }
}
