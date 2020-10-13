using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDo.Api.DataModels.Migrations
{
    public partial class Init_Database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(maxLength: 50, nullable: false),
                    Password = table.Column<string>(maxLength: 100, nullable: false),
                    FullName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ToDoTask",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TaskName = table.Column<string>(maxLength: 50, nullable: false),
                    TaskDescription = table.Column<string>(maxLength: 200, nullable: false),
                    TaskSchedule = table.Column<DateTime>(nullable: false),
                    IsComplete = table.Column<bool>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToDoTask", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ToDoTask_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ToDoSubTask",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SubTaskName = table.Column<string>(maxLength: 100, nullable: true),
                    Description = table.Column<string>(maxLength: 200, nullable: true),
                    IsComplete = table.Column<bool>(nullable: false),
                    ToDoTaskId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToDoSubTask", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ToDoSubTask_ToDoTask_ToDoTaskId",
                        column: x => x.ToDoTaskId,
                        principalTable: "ToDoTask",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "FullName", "Password", "UserName" },
                values: new object[] { 1, "Ilija Pecevski", "???8m?;T???{8}?", "pecevski" });

            migrationBuilder.InsertData(
                table: "ToDoTask",
                columns: new[] { "Id", "IsComplete", "TaskDescription", "TaskName", "TaskSchedule", "UserId" },
                values: new object[] { 1, false, "To build a service for TODO List", "Homework", new DateTime(2020, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "ToDoTask",
                columns: new[] { "Id", "IsComplete", "TaskDescription", "TaskName", "TaskSchedule", "UserId" },
                values: new object[] { 2, false, "Watch the soccer game between Macedonia and Kosovo", "Relaxing time", new DateTime(2020, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "ToDoTask",
                columns: new[] { "Id", "IsComplete", "TaskDescription", "TaskName", "TaskSchedule", "UserId" },
                values: new object[] { 3, false, "Study Entity Framework, ADO.Net and Dapper", "Studing", new DateTime(2020, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "ToDoSubTask",
                columns: new[] { "Id", "Description", "IsComplete", "SubTaskName", "ToDoTaskId" },
                values: new object[] { 1, "Study Entity Framework", false, "Entity Framework", 3 });

            migrationBuilder.InsertData(
                table: "ToDoSubTask",
                columns: new[] { "Id", "Description", "IsComplete", "SubTaskName", "ToDoTaskId" },
                values: new object[] { 2, "Study ADO.Net", false, "ADO.Net", 3 });

            migrationBuilder.InsertData(
                table: "ToDoSubTask",
                columns: new[] { "Id", "Description", "IsComplete", "SubTaskName", "ToDoTaskId" },
                values: new object[] { 3, "Study Dapper", false, "Dapper", 3 });

            migrationBuilder.CreateIndex(
                name: "IX_ToDoSubTask_ToDoTaskId",
                table: "ToDoSubTask",
                column: "ToDoTaskId");

            migrationBuilder.CreateIndex(
                name: "IX_ToDoTask_UserId",
                table: "ToDoTask",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ToDoSubTask");

            migrationBuilder.DropTable(
                name: "ToDoTask");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
