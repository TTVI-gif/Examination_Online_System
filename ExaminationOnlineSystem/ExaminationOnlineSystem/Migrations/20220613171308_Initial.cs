using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExaminationOnlineSystem.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Exam",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<int>(type: "int", maxLength: 3, nullable: false),
                    Score = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    QuestionAmount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exam", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QuestionRecord",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    A = table.Column<bool>(type: "bit", nullable: false),
                    B = table.Column<bool>(type: "bit", nullable: false),
                    C = table.Column<bool>(type: "bit", nullable: false),
                    D = table.Column<bool>(type: "bit", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    StudentDoExemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionRecord", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    BirthDay = table.Column<DateTime>(type: "datetime2", maxLength: 30, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Role = table.Column<int>(type: "int", maxLength: 30, nullable: false),
                    scoreId = table.Column<int>(type: "int", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salt = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Question",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExamId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Question_Exam_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exam",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentDoExam",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateDoExam = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Score = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Survey = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    ExamId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentDoExam", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentDoExam_User_StudentId",
                        column: x => x.StudentId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Answer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsRight = table.Column<bool>(type: "bit", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answer_Question_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Question",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Exam",
                columns: new[] { "Id", "Content", "Duration", "QuestionAmount", "Score" },
                values: new object[,]
                {
                    { 1, "Final C#", 90, 5, 10m },
                    { 2, "Final SQL", 90, 5, 10m },
                    { 3, "Final EF", 90, 5, 10m }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "BirthDay", "Email", "FirstName", "LastName", "Password", "PhoneNumber", "Role", "Salt", "UserName", "scoreId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 6, 14, 0, 13, 8, 7, DateTimeKind.Local).AddTicks(999), "vi@gmail.com", "student", "student", "8EV+KQXOH/AoAFLogVtXBkaTYSYIENM3TmFxdQ51jFA=", "123456789", 0, "36QMZig4rhy6MqXvLezwsg==", "student", 1 },
                    { 2, new DateTime(2022, 6, 14, 0, 13, 8, 8, DateTimeKind.Local).AddTicks(1167), "teacher@gmail.com", "Teacher", "Teacher", "HJsgtnmQbtXkRBDqlFaV9Izotrt7V/kFBq/S8hup2cg=", "123456789", 2, "JhMo1Weqm04bK5sFMe1lmA==", "teacher", null },
                    { 3, new DateTime(2022, 6, 14, 0, 13, 8, 8, DateTimeKind.Local).AddTicks(1186), "admin@gmail.com", "admin", "admin", "l9njb+XPV9ttNEzhbHtHDqbf1o63TtffxUzfDj6AlMc=", "635478921", 1, "pdQFAj9pdPRMRLpYijKnaQ==", "admin", null }
                });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "Id", "Content", "ExamId", "ImageUrl" },
                values: new object[,]
                {
                    { 1, "1 + 1", 1, null },
                    { 15, "Data anotation", 3, null },
                    { 14, "route", 3, null },
                    { 13, "Make http request", 3, null },
                    { 12, "Fluent API", 3, null },
                    { 11, "DbContext", 3, null },
                    { 5, "1 + 1", 3, null },
                    { 4, "2 + 2", 3, null },
                    { 10, "Join la gi?", 2, null },
                    { 9, "syntax store procedure", 2, null },
                    { 8, "2 * 2", 2, null },
                    { 7, "Tieng meo keu?", 2, null },
                    { 6, "Tieng cho sua?", 2, null },
                    { 2, "2 + 2", 1, null },
                    { 3, "1 + 3", 3, null }
                });

            migrationBuilder.InsertData(
                table: "StudentDoExam",
                columns: new[] { "Id", "DateDoExam", "ExamId", "Score", "StudentId", "Survey" },
                values: new object[,]
                {
                    { 2, new DateTime(2022, 6, 14, 0, 13, 8, 8, DateTimeKind.Local).AddTicks(3141), 2, 8m, 1, "good" },
                    { 1, new DateTime(2022, 6, 14, 0, 13, 8, 8, DateTimeKind.Local).AddTicks(1977), 1, 6m, 1, "good" },
                    { 3, new DateTime(2022, 6, 14, 0, 13, 8, 8, DateTimeKind.Local).AddTicks(3146), 3, 7m, 1, "good" }
                });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "Id", "Content", "ImageUrl", "IsRight", "QuestionId" },
                values: new object[,]
                {
                    { 1, "a", null, true, 1 },
                    { 13, "a", null, false, 4 },
                    { 14, "b", null, true, 4 },
                    { 15, "c", null, false, 4 },
                    { 16, "d", null, false, 4 },
                    { 17, "a", null, false, 5 },
                    { 18, "b", null, false, 5 },
                    { 19, "c", null, false, 5 },
                    { 20, "d", null, true, 5 },
                    { 41, "a", null, false, 11 },
                    { 42, "b", null, false, 11 },
                    { 43, "c", null, true, 11 },
                    { 44, "d", null, false, 11 },
                    { 12, "b", null, false, 3 },
                    { 45, "a", null, false, 12 },
                    { 47, "c", null, false, 12 },
                    { 48, "d", null, true, 12 },
                    { 49, "a", null, false, 13 },
                    { 50, "b", null, true, 13 },
                    { 51, "c", null, true, 13 },
                    { 52, "d", null, false, 13 },
                    { 53, "a", null, false, 14 },
                    { 54, "b", null, false, 14 },
                    { 55, "c", null, true, 14 },
                    { 56, "d", null, false, 14 },
                    { 57, "a", null, true, 15 },
                    { 58, "b", null, false, 15 },
                    { 46, "b", null, false, 12 },
                    { 11, "c", null, false, 3 },
                    { 10, "b", null, false, 3 },
                    { 9, "a", null, true, 3 },
                    { 2, "b", null, false, 1 },
                    { 3, "c", null, false, 1 },
                    { 4, "d", null, false, 1 },
                    { 5, "a", null, false, 2 },
                    { 6, "b", null, true, 2 },
                    { 7, "c", null, false, 2 },
                    { 8, "d", null, false, 2 },
                    { 21, "a", null, true, 6 },
                    { 22, "b", null, false, 6 },
                    { 23, "c", null, false, 6 },
                    { 24, "d", null, false, 6 }
                });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "Id", "Content", "ImageUrl", "IsRight", "QuestionId" },
                values: new object[,]
                {
                    { 25, "a", null, false, 7 },
                    { 26, "b", null, true, 7 },
                    { 27, "c", null, false, 7 },
                    { 28, "d", null, true, 7 },
                    { 29, "a", null, false, 8 },
                    { 30, "b", null, true, 8 },
                    { 31, "c", null, false, 8 },
                    { 32, "d", null, false, 8 },
                    { 33, "a", null, false, 9 },
                    { 34, "b", null, false, 9 },
                    { 35, "c", null, true, 9 },
                    { 36, "d", null, false, 9 },
                    { 37, "a", null, false, 10 },
                    { 38, "b", null, true, 10 },
                    { 39, "c", null, false, 10 },
                    { 40, "d", null, false, 10 },
                    { 59, "c", null, false, 15 },
                    { 60, "d", null, false, 15 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answer_QuestionId",
                table: "Answer",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Question_ExamId",
                table: "Question",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentDoExam_StudentId",
                table: "StudentDoExam",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answer");

            migrationBuilder.DropTable(
                name: "QuestionRecord");

            migrationBuilder.DropTable(
                name: "StudentDoExam");

            migrationBuilder.DropTable(
                name: "Question");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Exam");
        }
    }
}
