using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cars.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_Brand_BrandId",
                table: "Vehicle");

            migrationBuilder.AlterColumn<int>(
                name: "BrandId",
                table: "Vehicle",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<string>(
                name: "BrandName",
                table: "Vehicle",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_Brand_BrandId",
                table: "Vehicle",
                column: "BrandId",
                principalTable: "Brand",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_Brand_BrandId",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "BrandName",
                table: "Vehicle");

            migrationBuilder.AlterColumn<int>(
                name: "BrandId",
                table: "Vehicle",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_Brand_BrandId",
                table: "Vehicle",
                column: "BrandId",
                principalTable: "Brand",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
