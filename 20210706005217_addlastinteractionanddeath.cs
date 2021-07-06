using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TamagotchiAPIJune29.Migrations
{
    public partial class addlastinteractionanddeath : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Feedings_Pets_PetID",
                table: "Feedings");

            migrationBuilder.DropForeignKey(
                name: "FK_Playtimes_Pets_PetID",
                table: "Playtimes");

            migrationBuilder.DropForeignKey(
                name: "FK_Scoldings_Pets_PetID",
                table: "Scoldings");

            migrationBuilder.RenameColumn(
                name: "PetID",
                table: "Scoldings",
                newName: "PetId");

            migrationBuilder.RenameIndex(
                name: "IX_Scoldings_PetID",
                table: "Scoldings",
                newName: "IX_Scoldings_PetId");

            migrationBuilder.RenameColumn(
                name: "PetID",
                table: "Playtimes",
                newName: "PetId");

            migrationBuilder.RenameIndex(
                name: "IX_Playtimes_PetID",
                table: "Playtimes",
                newName: "IX_Playtimes_PetId");

            migrationBuilder.RenameColumn(
                name: "PetID",
                table: "Feedings",
                newName: "PetId");

            migrationBuilder.RenameIndex(
                name: "IX_Feedings_PetID",
                table: "Feedings",
                newName: "IX_Feedings_PetId");

            migrationBuilder.AddColumn<bool>(
                name: "IsDead",
                table: "Pets",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastInteractedWithDate",
                table: "Pets",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddForeignKey(
                name: "FK_Feedings_Pets_PetId",
                table: "Feedings",
                column: "PetId",
                principalTable: "Pets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Playtimes_Pets_PetId",
                table: "Playtimes",
                column: "PetId",
                principalTable: "Pets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Scoldings_Pets_PetId",
                table: "Scoldings",
                column: "PetId",
                principalTable: "Pets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Feedings_Pets_PetId",
                table: "Feedings");

            migrationBuilder.DropForeignKey(
                name: "FK_Playtimes_Pets_PetId",
                table: "Playtimes");

            migrationBuilder.DropForeignKey(
                name: "FK_Scoldings_Pets_PetId",
                table: "Scoldings");

            migrationBuilder.DropColumn(
                name: "IsDead",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "LastInteractedWithDate",
                table: "Pets");

            migrationBuilder.RenameColumn(
                name: "PetId",
                table: "Scoldings",
                newName: "PetID");

            migrationBuilder.RenameIndex(
                name: "IX_Scoldings_PetId",
                table: "Scoldings",
                newName: "IX_Scoldings_PetID");

            migrationBuilder.RenameColumn(
                name: "PetId",
                table: "Playtimes",
                newName: "PetID");

            migrationBuilder.RenameIndex(
                name: "IX_Playtimes_PetId",
                table: "Playtimes",
                newName: "IX_Playtimes_PetID");

            migrationBuilder.RenameColumn(
                name: "PetId",
                table: "Feedings",
                newName: "PetID");

            migrationBuilder.RenameIndex(
                name: "IX_Feedings_PetId",
                table: "Feedings",
                newName: "IX_Feedings_PetID");

            migrationBuilder.AddForeignKey(
                name: "FK_Feedings_Pets_PetID",
                table: "Feedings",
                column: "PetID",
                principalTable: "Pets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Playtimes_Pets_PetID",
                table: "Playtimes",
                column: "PetID",
                principalTable: "Pets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Scoldings_Pets_PetID",
                table: "Scoldings",
                column: "PetID",
                principalTable: "Pets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
