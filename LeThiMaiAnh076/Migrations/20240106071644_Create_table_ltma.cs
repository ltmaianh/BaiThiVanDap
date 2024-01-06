using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeThiMaiAnh076.Migrations
{
    /// <inheritdoc />
    public partial class Create_table_ltma : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeThiMaiAnh",
                columns: table => new
                {
                    HoTen = table.Column<string>(type: "TEXT", nullable: false),
                    MaSV = table.Column<int>(type: "INTEGER", nullable: false),
                    Diem = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeThiMaiAnh", x => x.HoTen);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeThiMaiAnh");
        }
    }
}
