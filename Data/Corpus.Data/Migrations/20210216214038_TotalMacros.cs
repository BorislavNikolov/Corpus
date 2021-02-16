using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Corpus.Data.Migrations
{
    public partial class TotalMacros : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DifficultLevel",
                table: "Workouts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalMacrosId",
                table: "MealPlans",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TargetMuscleGroup",
                table: "Еxercises",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TotalMacros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Calories = table.Column<double>(type: "float", nullable: false),
                    Proteins = table.Column<double>(type: "float", nullable: false),
                    Carbs = table.Column<double>(type: "float", nullable: false),
                    Fats = table.Column<double>(type: "float", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TotalMacros", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MealPlans_TotalMacrosId",
                table: "MealPlans",
                column: "TotalMacrosId");

            migrationBuilder.CreateIndex(
                name: "IX_TotalMacros_IsDeleted",
                table: "TotalMacros",
                column: "IsDeleted");

            migrationBuilder.AddForeignKey(
                name: "FK_MealPlans_TotalMacros_TotalMacrosId",
                table: "MealPlans",
                column: "TotalMacrosId",
                principalTable: "TotalMacros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MealPlans_TotalMacros_TotalMacrosId",
                table: "MealPlans");

            migrationBuilder.DropTable(
                name: "TotalMacros");

            migrationBuilder.DropIndex(
                name: "IX_MealPlans_TotalMacrosId",
                table: "MealPlans");

            migrationBuilder.DropColumn(
                name: "DifficultLevel",
                table: "Workouts");

            migrationBuilder.DropColumn(
                name: "TotalMacrosId",
                table: "MealPlans");

            migrationBuilder.DropColumn(
                name: "TargetMuscleGroup",
                table: "Еxercises");
        }
    }
}
