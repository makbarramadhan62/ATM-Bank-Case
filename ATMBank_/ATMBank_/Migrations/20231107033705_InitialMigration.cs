using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATMBank_.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ATMs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NamaATM = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ATMs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nasabahs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NamaNasabah = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NoRekening = table.Column<int>(type: "int", nullable: false),
                    Saldo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nasabahs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Casettes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ATMId = table.Column<int>(type: "int", nullable: false),
                    Nominal = table.Column<int>(type: "int", nullable: false),
                    Jumlah = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Casettes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Casettes_ATMs_ATMId",
                        column: x => x.ATMId,
                        principalTable: "ATMs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Casettes_ATMId",
                table: "Casettes",
                column: "ATMId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Casettes");

            migrationBuilder.DropTable(
                name: "Nasabahs");

            migrationBuilder.DropTable(
                name: "ATMs");
        }
    }
}
