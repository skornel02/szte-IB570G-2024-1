using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hazi3.Migrations;

/// <inheritdoc />
public partial class OwnerMigration : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        _ = migrationBuilder.AddColumn<long>(
            name: "OwnerId",
            table: "Pets",
            type: "INTEGER",
            nullable: true);

        _ = migrationBuilder.CreateTable(
            name: "OwnerEntity",
            columns: table => new
            {
                Id = table.Column<long>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                Name = table.Column<string>(type: "TEXT", nullable: false),
                PhoneNumber = table.Column<string>(type: "TEXT", nullable: false),
                HomeType = table.Column<int>(type: "INTEGER", nullable: false),
                ExperiencedKeeper = table.Column<bool>(type: "INTEGER", nullable: false)
            },
            constraints: table =>
            {
                _ = table.PrimaryKey("PK_OwnerEntity", x => x.Id);
            });

        _ = migrationBuilder.CreateIndex(
            name: "IX_Pets_OwnerId",
            table: "Pets",
            column: "OwnerId");

        _ = migrationBuilder.AddForeignKey(
            name: "FK_Pets_OwnerEntity_OwnerId",
            table: "Pets",
            column: "OwnerId",
            principalTable: "OwnerEntity",
            principalColumn: "Id",
            onDelete: ReferentialAction.SetNull);
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        _ = migrationBuilder.DropForeignKey(
            name: "FK_Pets_OwnerEntity_OwnerId",
            table: "Pets");

        _ = migrationBuilder.DropTable(
            name: "OwnerEntity");

        _ = migrationBuilder.DropIndex(
            name: "IX_Pets_OwnerId",
            table: "Pets");

        _ = migrationBuilder.DropColumn(
            name: "OwnerId",
            table: "Pets");
    }
}
