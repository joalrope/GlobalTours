using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
  public partial class InitialMigrations : Migration
  {
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.AlterDatabase()
          .Annotation("MySql:CharSet", "utf8mb4");

      migrationBuilder.CreateTable(
          name: "Place",
          columns: table => new
          {
            Id = table.Column<int>(type: "int", nullable: false)
                  .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            Name = table.Column<string>(type: "longtext", nullable: true)
                  .Annotation("MySql:CharSet", "utf8mb4")
          },
          constraints: table =>
          {
            table.PrimaryKey("PK_Place", x => x.Id);
          })
          .Annotation("MySql:CharSet", "utf8mb4");
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.DropTable(
          name: "Place");
    }
  }
}
