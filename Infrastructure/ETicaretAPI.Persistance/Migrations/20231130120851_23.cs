using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ETicaretAPI.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class _23 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdatedDated",
                table: "Products",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "UpdatedDated",
                table: "Orders",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "UpdatedDated",
                table: "Customers",
                newName: "UpdatedDate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "Products",
                newName: "UpdatedDated");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "Orders",
                newName: "UpdatedDated");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "Customers",
                newName: "UpdatedDated");
        }
    }
}
