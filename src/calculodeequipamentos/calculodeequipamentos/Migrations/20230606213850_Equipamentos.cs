using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace calculodeequipamentos.Migrations
{
    /// <inheritdoc />
    public partial class Equipamentos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MapeamentoConsumo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    Potencia = table.Column<int>(type: "int", nullable: false),
                    TempoDeUso = table.Column<int>(type: "int", nullable: false),
                    Consumo = table.Column<double>(type: "float", nullable: false),
                    ConsumoTotal = table.Column<double>(type: "float", nullable: false),
                    PlacasSolares = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MapeamentoConsumo", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MapeamentoConsumo");
        }
    }
}
