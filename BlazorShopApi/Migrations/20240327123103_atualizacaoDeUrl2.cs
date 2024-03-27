using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorShopApi.Migrations
{
    /// <inheritdoc />
    public partial class atualizacaoDeUrl2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImagemUrl",
                value: "Imagens/Beleza/b1.png");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImagemUrl",
                value: "/Imagens/Beleza/b2.png");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImagemUrl",
                value: "/Imagens/Beleza/b3.png");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImagemUrl",
                value: "/Imagens/Beleza/b4.png");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImagemUrl",
                value: "/Imagens/Beleza/b5.png");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImagemUrl",
                value: "/Imagens/Eletronicos/e1.png");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImagemUrl",
                value: "/Imagens/Eletronicos/e2.png");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImagemUrl",
                value: "/Imagens/Eletronicos/e3.png");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImagemUrl",
                value: "/Imagens/Eletronicos/e4.png");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImagemUrl",
                value: "/Imagens/Eletronicos/e5.png");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImagemUrl",
                value: "/Imagens/Eletronicos/e6.png");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImagemUrl",
                value: "/Imagens/Moveis/m1.png");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImagemUrl",
                value: "/Imagens/Moveis/m2.png");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImagemUrl",
                value: "/Imagens/Moveis/m3.png");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImagemUrl",
                value: "/Imagens/Moveis/m4.png");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImagemUrl",
                value: "/Imagens/Moveis/m6.png");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 17,
                column: "ImagemUrl",
                value: "/Imagens/Moveis/m7.png");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 18,
                column: "ImagemUrl",
                value: "/Imagens/Calcados/c1.png");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 19,
                column: "ImagemUrl",
                value: "/Imagens/Calcados/c2.png");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 20,
                column: "ImagemUrl",
                value: "/Imagens/Calcados/c3.png");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 21,
                column: "ImagemUrl",
                value: "/Imagens/Calcados/c4.png");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 22,
                column: "ImagemUrl",
                value: "/Imagens/Calcados/c5.png");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 23,
                column: "ImagemUrl",
                value: "/Imagens/Calcados/c6.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImagemUrl",
                value: "Imagens/Beleza/Beleza1.png");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImagemUrl",
                value: "/Imagens/Beleza/Beleza2.png");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImagemUrl",
                value: "/Imagens/Beleza/Beleza3.png");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImagemUrl",
                value: "/Imagens/Beleza/Beleza4.png");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImagemUrl",
                value: "/Imagens/Beleza/Beleza5.png");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImagemUrl",
                value: "/Imagens/Eletronicos/eletronico1.png");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImagemUrl",
                value: "/Imagens/Eletronicos/eletronico2.png");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImagemUrl",
                value: "/Imagens/Eletronicos/eletronico3.png");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImagemUrl",
                value: "/Imagens/Eletronicos/eletronico4.png");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImagemUrl",
                value: "/Imagens/Eletronicos/eletronico5.png");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImagemUrl",
                value: "/Imagens/Eletronicos/tecnologia6.png");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImagemUrl",
                value: "/Imagens/Moveis/moveis1.png");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImagemUrl",
                value: "/Imagens/Moveis/moveis2.png");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImagemUrl",
                value: "/Imagens/Moveis/moveis3.png");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImagemUrl",
                value: "/Imagens/Moveis/moveis4.png");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImagemUrl",
                value: "/Imagens/Moveis/moveis6.png");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 17,
                column: "ImagemUrl",
                value: "/Imagens/Moveis/moveis7.png");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 18,
                column: "ImagemUrl",
                value: "/Imagens/Calcados/calcado1.png");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 19,
                column: "ImagemUrl",
                value: "/Imagens/Calcados/calcado2.png");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 20,
                column: "ImagemUrl",
                value: "/Imagens/Calcados/calcado3.png");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 21,
                column: "ImagemUrl",
                value: "/Imagens/Calcados/calcado4.png");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 22,
                column: "ImagemUrl",
                value: "/Imagens/Calcados/calcado5.png");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 23,
                column: "ImagemUrl",
                value: "/Imagens/Calcados/calcado6.png");
        }
    }
}
