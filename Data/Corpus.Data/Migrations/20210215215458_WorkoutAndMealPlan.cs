using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Corpus.Data.Migrations
{
    public partial class WorkoutAndMealPlan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MealPlanId",
                table: "Foods",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WorkoutId",
                table: "Еxercises",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MealPlans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealPlans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Workouts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workouts", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Foods_MealPlanId",
                table: "Foods",
                column: "MealPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Еxercises_WorkoutId",
                table: "Еxercises",
                column: "WorkoutId");

            migrationBuilder.CreateIndex(
                name: "IX_MealPlans_IsDeleted",
                table: "MealPlans",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Workouts_IsDeleted",
                table: "Workouts",
                column: "IsDeleted");

            migrationBuilder.AddForeignKey(
                name: "FK_Еxercises_Workouts_WorkoutId",
                table: "Еxercises",
                column: "WorkoutId",
                principalTable: "Workouts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_MealPlans_MealPlanId",
                table: "Foods",
                column: "MealPlanId",
                principalTable: "MealPlans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Еxercises_Workouts_WorkoutId",
                table: "Еxercises");

            migrationBuilder.DropForeignKey(
                name: "FK_Foods_MealPlans_MealPlanId",
                table: "Foods");

            migrationBuilder.DropTable(
                name: "MealPlans");

            migrationBuilder.DropTable(
                name: "Workouts");

            migrationBuilder.DropIndex(
                name: "IX_Foods_MealPlanId",
                table: "Foods");

            migrationBuilder.DropIndex(
                name: "IX_Еxercises_WorkoutId",
                table: "Еxercises");

            migrationBuilder.DropColumn(
                name: "MealPlanId",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "WorkoutId",
                table: "Еxercises");
        }
    }
}
