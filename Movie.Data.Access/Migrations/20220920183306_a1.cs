using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movie.Data.Access.Migrations
{
    public partial class a1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TblMovieTypeId",
                table: "TblMovie",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TblMovieType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblMovieType", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TblMovie_TblMovieTypeId",
                table: "TblMovie",
                column: "TblMovieTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_TblMovie_TblMovieType_TblMovieTypeId",
                table: "TblMovie",
                column: "TblMovieTypeId",
                principalTable: "TblMovieType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblMovie_TblMovieType_TblMovieTypeId",
                table: "TblMovie");

            migrationBuilder.DropTable(
                name: "TblMovieType");

            migrationBuilder.DropIndex(
                name: "IX_TblMovie_TblMovieTypeId",
                table: "TblMovie");

            migrationBuilder.DropColumn(
                name: "TblMovieTypeId",
                table: "TblMovie");
        }
    }
}
