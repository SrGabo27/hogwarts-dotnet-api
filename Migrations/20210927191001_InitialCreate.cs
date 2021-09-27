using Microsoft.EntityFrameworkCore.Migrations;

namespace hogwartsApi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Applications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Lastname = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Identification = table.Column<long>(type: "INTEGER", maxLength: 10, nullable: false),
                    Age = table.Column<int>(type: "INTEGER", maxLength: 2, nullable: false),
                    House = table.Column<byte>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Applications",
                columns: new[] { "Id", "Age", "House", "Identification", "Lastname", "Name" },
                values: new object[] { 100, 19, (byte)1, 28441688L, "Alvarez", "Gabriel" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Applications");
        }
    }
}
