using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BancoZeneide.Migrations
{
    public partial class OrtherEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    NomeCategoria = table.Column<string>(nullable: true),
                    NivelCategoria = table.Column<string>(nullable: true),
                    IdCategoria = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.IdCategoria);
                });

            migrationBuilder.CreateTable(
                name: "Pet",
                columns: table => new
                {
                    IdPet = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Sexo = table.Column<string>(nullable: false),
                    Raca = table.Column<string>(nullable: true),
                    Peso = table.Column<string>(nullable: true),
                    ClienteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pet", x => x.IdPet);
                    table.ForeignKey(
                        name: "FK_Pet_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vendedor",
                columns: table => new
                {
                    NomeVendedor = table.Column<string>(nullable: true),
                    CpfVendedor = table.Column<string>(nullable: true),
                    DataInicio = table.Column<DateTime>(nullable: false),
                    IdVendedor = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendedor", x => x.IdVendedor);
                });

            migrationBuilder.CreateTable(
                name: "Pedido",
                columns: table => new
                {
                    PedidoId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    VendedorIdVendedor = table.Column<int>(nullable: true),
                    ClienteId = table.Column<int>(nullable: true),
                    PetIdPet = table.Column<int>(nullable: true),
                    CategoriaIdCategoria = table.Column<int>(nullable: true),
                    DataVenda = table.Column<DateTime>(nullable: false),
                    QuantidadeItensComprada = table.Column<int>(nullable: false),
                    ValorTotal = table.Column<double>(nullable: false),
                    Amount = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedido", x => x.PedidoId);
                    table.ForeignKey(
                        name: "FK_Pedido_Categoria_CategoriaIdCategoria",
                        column: x => x.CategoriaIdCategoria,
                        principalTable: "Categoria",
                        principalColumn: "IdCategoria",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pedido_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pedido_Pet_PetIdPet",
                        column: x => x.PetIdPet,
                        principalTable: "Pet",
                        principalColumn: "IdPet",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pedido_Vendedor_VendedorIdVendedor",
                        column: x => x.VendedorIdVendedor,
                        principalTable: "Vendedor",
                        principalColumn: "IdVendedor",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    NomeProduto = table.Column<string>(nullable: true),
                    ValorProduto = table.Column<double>(nullable: false),
                    Descricao = table.Column<string>(nullable: true),
                    CategoriaIdCategoria = table.Column<int>(nullable: true),
                    ProdutoId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PedidoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.ProdutoId);
                    table.ForeignKey(
                        name: "FK_Produto_Categoria_CategoriaIdCategoria",
                        column: x => x.CategoriaIdCategoria,
                        principalTable: "Categoria",
                        principalColumn: "IdCategoria",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Produto_Pedido_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedido",
                        principalColumn: "PedidoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_CategoriaIdCategoria",
                table: "Pedido",
                column: "CategoriaIdCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_ClienteId",
                table: "Pedido",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_PetIdPet",
                table: "Pedido",
                column: "PetIdPet");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_VendedorIdVendedor",
                table: "Pedido",
                column: "VendedorIdVendedor");

            migrationBuilder.CreateIndex(
                name: "IX_Pet_ClienteId",
                table: "Pet",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_CategoriaIdCategoria",
                table: "Produto",
                column: "CategoriaIdCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_PedidoId",
                table: "Produto",
                column: "PedidoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropTable(
                name: "Pedido");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Pet");

            migrationBuilder.DropTable(
                name: "Vendedor");
        }
    }
}
