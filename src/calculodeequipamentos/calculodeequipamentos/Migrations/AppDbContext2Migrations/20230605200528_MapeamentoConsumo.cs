using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace calculodeequipamentos.Migrations.AppDbContext2Migrations
{
    /// <inheritdoc />
    public partial class MapeamentoConsumo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "ConsumoTotal",
                table: "Equip",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "PlacasSolares",
                table: "Equip",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConsumoTotal",
                table: "Equip");

            migrationBuilder.DropColumn(
                name: "PlacasSolares",
                table: "Equip");
        }
    }
}
