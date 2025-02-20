using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstDb.Migrations
{
    /// <inheritdoc />
    public partial class init20 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClassCourses_Classes_ClassID",
                table: "ClassCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassCourses_Courses_CourseId",
                table: "ClassCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Classes_ClassID",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_ClassID",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_ClassCourses_ClassID",
                table: "ClassCourses");

            migrationBuilder.DropIndex(
                name: "IX_ClassCourses_CourseId",
                table: "ClassCourses");

            migrationBuilder.DropColumn(
                name: "ClassID",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ClassID",
                table: "ClassCourses");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "ClassCourses");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClassId_FK",
                table: "Students",
                column: "ClassId_FK");

            migrationBuilder.CreateIndex(
                name: "IX_ClassCourses_ClassID_Fk",
                table: "ClassCourses",
                column: "ClassID_Fk");

            migrationBuilder.CreateIndex(
                name: "IX_ClassCourses_CourseID_Fk",
                table: "ClassCourses",
                column: "CourseID_Fk");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassCourses_Classes_ClassID_Fk",
                table: "ClassCourses",
                column: "ClassID_Fk",
                principalTable: "Classes",
                principalColumn: "ClassID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassCourses_Courses_CourseID_Fk",
                table: "ClassCourses",
                column: "CourseID_Fk",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Classes_ClassId_FK",
                table: "Students",
                column: "ClassId_FK",
                principalTable: "Classes",
                principalColumn: "ClassID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClassCourses_Classes_ClassID_Fk",
                table: "ClassCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassCourses_Courses_CourseID_Fk",
                table: "ClassCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Classes_ClassId_FK",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_ClassId_FK",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_ClassCourses_ClassID_Fk",
                table: "ClassCourses");

            migrationBuilder.DropIndex(
                name: "IX_ClassCourses_CourseID_Fk",
                table: "ClassCourses");

            migrationBuilder.AddColumn<int>(
                name: "ClassID",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClassID",
                table: "ClassCourses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "ClassCourses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClassID",
                table: "Students",
                column: "ClassID");

            migrationBuilder.CreateIndex(
                name: "IX_ClassCourses_ClassID",
                table: "ClassCourses",
                column: "ClassID");

            migrationBuilder.CreateIndex(
                name: "IX_ClassCourses_CourseId",
                table: "ClassCourses",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassCourses_Classes_ClassID",
                table: "ClassCourses",
                column: "ClassID",
                principalTable: "Classes",
                principalColumn: "ClassID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassCourses_Courses_CourseId",
                table: "ClassCourses",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Classes_ClassID",
                table: "Students",
                column: "ClassID",
                principalTable: "Classes",
                principalColumn: "ClassID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
