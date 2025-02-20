using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstDb.Migrations
{
    /// <inheritdoc />
    public partial class addNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Classes_ClassId_FK",
                table: "Students");

            migrationBuilder.AlterColumn<int>(
                name: "ClassId_FK",
                table: "Students",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Classes_ClassId_FK",
                table: "Students",
                column: "ClassId_FK",
                principalTable: "Classes",
                principalColumn: "ClassID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Classes_ClassId_FK",
                table: "Students");

            migrationBuilder.AlterColumn<int>(
                name: "ClassId_FK",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Classes_ClassId_FK",
                table: "Students",
                column: "ClassId_FK",
                principalTable: "Classes",
                principalColumn: "ClassID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
