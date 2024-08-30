using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sample.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    userID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fullname = table.Column<string>(type: "varchar(50)", nullable: false),
                    Gender = table.Column<string>(type: "varchar(10)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Username = table.Column<string>(type: "varchar(50)", nullable: false),
                    Password = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.userID);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firstname = table.Column<string>(type: "varchar(50)", nullable: false),
                    Middlename = table.Column<string>(type: "varchar(50)", nullable: false),
                    Lastname = table.Column<string>(type: "varchar(50)", nullable: false),
                    Gender = table.Column<string>(type: "varchar(10)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Birthdate = table.Column<DateTime>(type: "Date", nullable: false),
                    CreatedON = table.Column<DateTime>(type: "Date", nullable: false),
                    StudentCode = table.Column<string>(type: "varchar(11)", nullable: false),
                    Createdby = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentID);
                    table.ForeignKey(
                        name: "FK_Students_User_Createdby",
                        column: x => x.Createdby,
                        principalTable: "User",
                        principalColumn: "userID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_Createdby",
                table: "Students",
                column: "Createdby");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
