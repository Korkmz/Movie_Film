using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movie.Data.Access.Migrations
{
    public partial class updateTblMovie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "TblMovie",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "TblMovie",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "TblMovie",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Score",
                table: "TblMovie",
                type: "decimal(18,2)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "TblMovie");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "TblMovie");

            migrationBuilder.DropColumn(
                name: "Score",
                table: "TblMovie");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "TblMovie",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
