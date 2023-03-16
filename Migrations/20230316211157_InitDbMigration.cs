using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace duett_tech_challenge_api.Migrations
{
    /// <inheritdoc />
    public partial class InitDbMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fruit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Description = table.Column<string>(type: "text", nullable: true),
                    ValueOne = table.Column<int>(type: "integer", nullable: false),
                    ValueTwo = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fruit", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Fruit",
                columns: new[] { "Id", "Description", "ValueOne", "ValueTwo" },
                values: new object[,]
                {
                    { 1, "Banana", 10, 2 },
                    { 2, "Maça", 0, 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fruit");
        }
    }
}
