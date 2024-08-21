using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class fixedpropertiesnames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InoutRegister_Clubs_ClubId",
                table: "InoutRegister");

            migrationBuilder.DropForeignKey(
                name: "FK_InoutRegister_Members_MemberId",
                table: "InoutRegister");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InoutRegister",
                table: "InoutRegister");

            migrationBuilder.RenameTable(
                name: "InoutRegister",
                newName: "InOutRegisters");

            migrationBuilder.RenameColumn(
                name: "Trohpies",
                table: "TrophyRegister",
                newName: "Trophies");

            migrationBuilder.RenameIndex(
                name: "IX_InoutRegister_MemberId",
                table: "InOutRegisters",
                newName: "IX_InOutRegisters_MemberId");

            migrationBuilder.RenameIndex(
                name: "IX_InoutRegister_ClubId",
                table: "InOutRegisters",
                newName: "IX_InOutRegisters_ClubId");

            migrationBuilder.AddColumn<int>(
                name: "Trophies",
                table: "Members",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_InOutRegisters",
                table: "InOutRegisters",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InOutRegisters_Clubs_ClubId",
                table: "InOutRegisters",
                column: "ClubId",
                principalTable: "Clubs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InOutRegisters_Members_MemberId",
                table: "InOutRegisters",
                column: "MemberId",
                principalTable: "Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InOutRegisters_Clubs_ClubId",
                table: "InOutRegisters");

            migrationBuilder.DropForeignKey(
                name: "FK_InOutRegisters_Members_MemberId",
                table: "InOutRegisters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InOutRegisters",
                table: "InOutRegisters");

            migrationBuilder.DropColumn(
                name: "Trophies",
                table: "Members");

            migrationBuilder.RenameTable(
                name: "InOutRegisters",
                newName: "InoutRegister");

            migrationBuilder.RenameColumn(
                name: "Trophies",
                table: "TrophyRegister",
                newName: "Trohpies");

            migrationBuilder.RenameIndex(
                name: "IX_InOutRegisters_MemberId",
                table: "InoutRegister",
                newName: "IX_InoutRegister_MemberId");

            migrationBuilder.RenameIndex(
                name: "IX_InOutRegisters_ClubId",
                table: "InoutRegister",
                newName: "IX_InoutRegister_ClubId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InoutRegister",
                table: "InoutRegister",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InoutRegister_Clubs_ClubId",
                table: "InoutRegister",
                column: "ClubId",
                principalTable: "Clubs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InoutRegister_Members_MemberId",
                table: "InoutRegister",
                column: "MemberId",
                principalTable: "Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
