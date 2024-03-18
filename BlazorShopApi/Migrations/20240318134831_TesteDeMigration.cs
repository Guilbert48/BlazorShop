using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorShopApi.Migrations
{
    /// <inheritdoc />
    public partial class TesteDeMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "Id", "IconCSS", "Nome" },
                values: new object[,]
                {
                    { 2, "fas fa-couch", "Moveis" },
                    { 3, "fas fa-headphones", "Eletronicos" },
                    { 4, "fas fa-shoe-prints", "Calcados" }
                });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "CategoriasId", "Descricao", "ImagemUrl", "Nome", "Preco", "Quantidade" },
                values: new object[] { 2, 1, "Um kit fornecido pela Curology, contendo produtos para cuidados com a pele", "/Imagens/Beleza/Beleza2.png", "Curology - Kit para Pele", 50m, 45 });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "NomeUsuario" },
                values: new object[,]
                {
                    { 1, "Guil" },
                    { 2, "Anne" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
