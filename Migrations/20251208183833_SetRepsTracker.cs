using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessTracker.Migrations
{
    /// <inheritdoc />
    public partial class SetRepsTracker : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TrackedPerson",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Weight = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrackedPerson", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkoutTrackers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    NormalSets = table.Column<int>(type: "INTEGER", nullable: false),
                    NormalReps = table.Column<int>(type: "INTEGER", nullable: false),
                    StartDay = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkoutTrackers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SetsRepsTracker",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Set = table.Column<int>(type: "INTEGER", nullable: false),
                    Reps = table.Column<int>(type: "INTEGER", nullable: false),
                    CurrentDay = table.Column<DateTime>(type: "TEXT", nullable: false),
                    WorkoutTrackerId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SetsRepsTracker", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SetsRepsTracker_WorkoutTrackers_WorkoutTrackerId",
                        column: x => x.WorkoutTrackerId,
                        principalTable: "WorkoutTrackers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SetsRepsTracker_WorkoutTrackerId",
                table: "SetsRepsTracker",
                column: "WorkoutTrackerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SetsRepsTracker");

            migrationBuilder.DropTable(
                name: "TrackedPerson");

            migrationBuilder.DropTable(
                name: "WorkoutTrackers");
        }
    }
}
