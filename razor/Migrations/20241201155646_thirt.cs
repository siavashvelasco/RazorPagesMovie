using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace razor.Migrations
{
    /// <inheritdoc />
    public partial class thirt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[] { 5, 500, "Reza" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
