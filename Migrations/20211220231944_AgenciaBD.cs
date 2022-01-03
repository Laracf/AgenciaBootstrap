using Microsoft.EntityFrameworkCore.Migrations;

namespace Agencia.Migrations
{
    public partial class AgenciaBD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    IdCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCliente = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("FK_Clientes", x => x.IdCliente);
                });

            migrationBuilder.CreateTable(
                name: "Destinos",
                columns: table => new
                {
                    IdDestino = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeDestino = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("FK_Destinos", x => x.IdDestino);
                });

            migrationBuilder.CreateTable(
                name: "Compras",
                columns: table => new
                {
                    IdCompra = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataIda = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DataVolta = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    valor = table.Column<int>(type: "int", nullable: false),
                    FK_IdCliente = table.Column<int>(type: "int", nullable: false),
                    ClienteIdCliente = table.Column<int>(type: "int", nullable: true),
                    FK_IdDestino = table.Column<int>(type: "int", nullable: false),
                    DestinoIdDestino = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("FK_Compras", x => x.IdCompra);
                    table.ForeignKey(
                        name: "FK_Compras_Clientes_ClienteIdCliente",
                        column: x => x.ClienteIdCliente,
                        principalTable: "Clientes",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Restrict);
                    table.PrimaryKey("FK_Compras", x => x.IdCompra);
                    table.ForeignKey(
                        name: "FK_Compras_Destinos_DestinoIdDestino",
                        column: x => x.DestinoIdDestino,
                        principalTable: "Destinos",
                        principalColumn: "IdDestino",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Compras_ClienteIdCliente",
                table: "Compras",
                column: "ClienteIdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Compras_DestinoIdDestino",
                table: "Compras",
                column: "DestinoIdDestino");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Compras");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Destinos");
        }
    }
}
