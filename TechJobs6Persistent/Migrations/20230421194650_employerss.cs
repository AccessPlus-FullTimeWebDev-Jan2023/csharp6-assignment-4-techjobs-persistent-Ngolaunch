using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechJobs6Persistent.Migrations
{
    public partial class employerss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_“JobSkills”_Jobs_JobsId",
                table: "“JobSkills”");

            migrationBuilder.DropForeignKey(
                name: "FK_“JobSkills”_Skills_SkillsId",
                table: "“JobSkills”");

            migrationBuilder.DropPrimaryKey(
                name: "PK_“JobSkills”",
                table: "“JobSkills”");

            migrationBuilder.RenameTable(
                name: "“JobSkills”",
                newName: "JobSkills");

            migrationBuilder.RenameIndex(
                name: "IX_“JobSkills”_SkillsId",
                table: "JobSkills",
                newName: "IX_JobSkills_SkillsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobSkills",
                table: "JobSkills",
                columns: new[] { "JobsId", "SkillsId" });

            migrationBuilder.AddForeignKey(
                name: "FK_JobSkills_Jobs_JobsId",
                table: "JobSkills",
                column: "JobsId",
                principalTable: "Jobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobSkills_Skills_SkillsId",
                table: "JobSkills",
                column: "SkillsId",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobSkills_Jobs_JobsId",
                table: "JobSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_JobSkills_Skills_SkillsId",
                table: "JobSkills");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobSkills",
                table: "JobSkills");

            migrationBuilder.RenameTable(
                name: "JobSkills",
                newName: "“JobSkills”");

            migrationBuilder.RenameIndex(
                name: "IX_JobSkills_SkillsId",
                table: "“JobSkills”",
                newName: "IX_“JobSkills”_SkillsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_“JobSkills”",
                table: "“JobSkills”",
                columns: new[] { "JobsId", "SkillsId" });

            migrationBuilder.AddForeignKey(
                name: "FK_“JobSkills”_Jobs_JobsId",
                table: "“JobSkills”",
                column: "JobsId",
                principalTable: "Jobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_“JobSkills”_Skills_SkillsId",
                table: "“JobSkills”",
                column: "SkillsId",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
