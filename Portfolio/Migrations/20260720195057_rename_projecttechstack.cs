using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portfolio.Migrations
{
    /// <inheritdoc />
    public partial class rename_projecttechstack : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectTechStack_Projects_ProjectId",
                table: "ProjectTechStack");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectTechStack_TechStacks_TechStackId",
                table: "ProjectTechStack");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjectTechStack",
                table: "ProjectTechStack");

            migrationBuilder.RenameTable(
                name: "ProjectTechStack",
                newName: "ProjectTechStacks");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectTechStack_TechStackId",
                table: "ProjectTechStacks",
                newName: "IX_ProjectTechStacks_TechStackId");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectTechStack_ProjectId",
                table: "ProjectTechStacks",
                newName: "IX_ProjectTechStacks_ProjectId");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Projects",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjectTechStacks",
                table: "ProjectTechStacks",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectTechStacks_Projects_ProjectId",
                table: "ProjectTechStacks",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectTechStacks_TechStacks_TechStackId",
                table: "ProjectTechStacks",
                column: "TechStackId",
                principalTable: "TechStacks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectTechStacks_Projects_ProjectId",
                table: "ProjectTechStacks");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectTechStacks_TechStacks_TechStackId",
                table: "ProjectTechStacks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjectTechStacks",
                table: "ProjectTechStacks");

            migrationBuilder.RenameTable(
                name: "ProjectTechStacks",
                newName: "ProjectTechStack");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectTechStacks_TechStackId",
                table: "ProjectTechStack",
                newName: "IX_ProjectTechStack_TechStackId");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectTechStacks_ProjectId",
                table: "ProjectTechStack",
                newName: "IX_ProjectTechStack_ProjectId");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjectTechStack",
                table: "ProjectTechStack",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectTechStack_Projects_ProjectId",
                table: "ProjectTechStack",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectTechStack_TechStacks_TechStackId",
                table: "ProjectTechStack",
                column: "TechStackId",
                principalTable: "TechStacks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
