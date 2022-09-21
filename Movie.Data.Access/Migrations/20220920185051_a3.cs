using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movie.Data.Access.Migrations
{
    public partial class a3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "TblMovie",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "TblGeneralAudienceTypeId",
                table: "TblMovie",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TblGeneralAudienceType",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblGeneralAudienceType", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TblMovie_TblGeneralAudienceTypeId",
                table: "TblMovie",
                column: "TblGeneralAudienceTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_TblMovie_TblGeneralAudienceType_TblGeneralAudienceTypeId",
                table: "TblMovie",
                column: "TblGeneralAudienceTypeId",
                principalTable: "TblGeneralAudienceType",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblMovie_TblGeneralAudienceType_TblGeneralAudienceTypeId",
                table: "TblMovie");

            migrationBuilder.DropTable(
                name: "TblGeneralAudienceType");

            migrationBuilder.DropIndex(
                name: "IX_TblMovie_TblGeneralAudienceTypeId",
                table: "TblMovie");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "TblMovie");

            migrationBuilder.DropColumn(
                name: "TblGeneralAudienceTypeId",
                table: "TblMovie");
        }
    }
}
