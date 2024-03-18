using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorShopApi.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoDeProdutoss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "CategoriasId", "Descricao", "ImagemUrl", "Nome", "Preco", "Quantidade" },
                values: new object[,]
                {
                    { 3, 1, "Um kit fornecido pela Glossier, contendo produtos para cuidados com a pele", "/Imagens/Beleza/Beleza3.png", "Óleo de Coco Orgânico", 20m, 30 },
                    { 4, 1, "Um kit fornecido pela Curology, contendo produtos para cuidados com a pele", "/Imagens/Beleza/Beleza4.png", "Schwarzkopf - Kit de cuidados com a pele e cabelo", 50m, 60 },
                    { 5, 1, "Kit de cuidados com a pele, contendo produtos para cuidados com a pele e cabelos", "/Imagens/Beleza/Beleza5.png", "Kit de cuidados com a pele", 30m, 85 },
                    { 6, 3, "Air Pods - fones de ouvido sem fio intra-auriculares", "/Imagens/Eletronicos/eletronico1.png", "Fones de ouvidos", 100m, 120 },
                    { 7, 3, "Fones de ouvido dourados na orelha - esses fones de ouvido não são sem fio", "/Imagens/Eletronicos/eletronico2.png", "Fones de ouvido dourados", 40m, 200 },
                    { 8, 3, "Fones de ouvido pretos na orelha - esses fones de ouvido não são sem fio", "/Imagens/Eletronicos/eletronico3.png", "Fones de ouvido pretos", 40m, 300 },
                    { 9, 3, "Câmera Digital Sennheiser - Câmera digital de alta qualidade fornecida pela Sennheiser - inclui tripé", "/Imagens/Eletronicos/eletronico4.png", "Câmera digital Sennheiser com tripé", 600m, 20 },
                    { 10, 3, "Canon Digital Camera - Câmera digital de alta qualidade fornecida pela Canon", "/Imagens/Eletronicos/eletronico5.png", "Câmera Digital Canon", 500m, 15 },
                    { 11, 3, "Gameboy - Fornecido por Nintendo", "/Imagens/Eletronicos/tecnologia6.png", "Nintendo Gameboy", 100m, 60 },
                    { 12, 2, "Cadeira de escritório em couro preto muito confortável", "/Imagens/Moveis/moveis1.png", "Cadeira de escritório de couro preto", 50m, 212 },
                    { 13, 2, "Cadeira de escritório em couro rosa muito confortável", "/Imagens/Moveis/moveis2.png", "Cadeira de escritório de couro rosa", 50m, 112 },
                    { 14, 2, "Poltrona muito confortável", "/Imagens/Moveis/moveis3.png", "Espreguiçadeira", 70m, 90 },
                    { 15, 2, "Poltrona prateada muito confortável", "/Imagens/Moveis/moveis4.png", "Silver Lounge Chair", 120m, 95 },
                    { 16, 2, "Abajur de mesa de porcelana branco e azul", "/Imagens/Moveis/moveis6.png", "Luminária de mesa de porcelana", 15m, 100 },
                    { 17, 2, "Abajur de mesa de escritório", "/Imagens/Moveis/moveis7.png", "Office Table Lamp", 20m, 73 },
                    { 18, 4, "Tênis Puma confortáveis na maioria dos tamanhos", "/Imagens/Calcados/calcado1.png", "Tênis Puma", 100m, 50 },
                    { 19, 4, "Tênis coloridos - disponíveis na maioria dos tamanhos", "/Imagens/Calcados/calcado2.png", "Tênis Colodiros", 150m, 60 },
                    { 20, 4, "Tênis Nike azul - disponível na maioria dos tamanhos", "/Imagens/Calcados/calcado3.png", "Tênis Nike Azul", 200m, 70 },
                    { 21, 4, "Treinadores Hummel coloridos - disponíveis na maioria dos tamanhos", "/Imagens/Calcados/calcado4.png", "Tênis Hummel Coloridos", 120m, 120 },
                    { 22, 4, "Tênis Nike vermelho - disponível na maioria dos tamanhos", "/Imagens/Calcados/calcado5.png", "Tênis Nike Vermelho", 200m, 100 },
                    { 23, 4, "Sandálias Birkenstock - disponíveis na maioria dos tamanhos", "/Imagens/Calcados/calcado6.png", "Sandálidas Birkenstock", 50m, 150 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 23);
        }
    }
}
