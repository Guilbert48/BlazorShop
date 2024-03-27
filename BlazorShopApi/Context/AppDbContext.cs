using BlazorShopApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorShopApi.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Carrinho> Carrinhos { get; set; }
        public DbSet<CarrinhoItem> carrinhoItems { get; set; }

        public DbSet<Categorias> Categorias { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Produtos

            //Beleza
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 1,
                Nome = "Gloss - Beleza kit",
                Descricao = "Kit de beleza e cuidados com a pele",
                ImagemUrl = "Imagens/Beleza/b1.png",
                Preco = 100,
                Quantidade = 100,
                CategoriasId = 1,
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 2,
                Nome = "Curology - Kit para Pele",
                Descricao = "Um kit fornecido pela Curology, contendo produtos para cuidados com a pele",
                ImagemUrl = "/Imagens/Beleza/b2.png",
                Preco = 50,
                Quantidade = 45,
                CategoriasId = 1

            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 3,
                Nome = "Óleo de Coco Orgânico",
                Descricao = "Um kit fornecido pela Glossier, contendo produtos para cuidados com a pele",
                ImagemUrl = "/Imagens/Beleza/b3.png",
                Preco = 20,
                Quantidade = 30,
                CategoriasId = 1

            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 4,
                Nome = "Schwarzkopf - Kit de cuidados com a pele e cabelo",
                Descricao = "Um kit fornecido pela Curology, contendo produtos para cuidados com a pele",
                ImagemUrl = "/Imagens/Beleza/b4.png",
                Preco = 50,
                Quantidade = 60,
                CategoriasId = 1

            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 5,
                Nome = "Kit de cuidados com a pele",
                Descricao = "Kit de cuidados com a pele, contendo produtos para cuidados com a pele e cabelos",
                ImagemUrl = "/Imagens/Beleza/b5.png",
                Preco = 30,
                Quantidade = 85,
                CategoriasId = 1

            });
            //eletronico Category
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 6,
                Nome = "Fones de ouvidos",
                Descricao = "Air Pods - fones de ouvido sem fio intra-auriculares",
                ImagemUrl = "/Imagens/Eletronicos/e1.png",
                Preco = 100,
                Quantidade = 120,
                CategoriasId = 3

            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 7,
                Nome = "Fones de ouvido dourados",
                Descricao = "Fones de ouvido dourados na orelha - esses fones de ouvido não são sem fio",
                ImagemUrl = "/Imagens/Eletronicos/e2.png",
                Preco = 40,
                Quantidade = 200,
                CategoriasId = 3

            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 8,
                Nome = "Fones de ouvido pretos",
                Descricao = "Fones de ouvido pretos na orelha - esses fones de ouvido não são sem fio",
                ImagemUrl = "/Imagens/Eletronicos/e3.png",
                Preco = 40,
                Quantidade = 300,
                CategoriasId = 3

            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 9,
                Nome = "Câmera digital Sennheiser com tripé",
                Descricao = "Câmera Digital Sennheiser - Câmera digital de alta qualidade fornecida pela Sennheiser - inclui tripé",
                ImagemUrl = "/Imagens/Eletronicos/e4.png",
                Preco = 600,
                Quantidade = 20,
                CategoriasId = 3

            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 10,
                Nome = "Câmera Digital Canon",
                Descricao = "Canon Digital Camera - Câmera digital de alta qualidade fornecida pela Canon",
                ImagemUrl = "/Imagens/Eletronicos/e5.png",
                Preco = 500,
                Quantidade = 15,
                CategoriasId = 3

            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 11,
                Nome = "Nintendo Gameboy",
                Descricao = "Gameboy - Fornecido por Nintendo",
                ImagemUrl = "/Imagens/Eletronicos/e6.png",
                Preco = 100,
                Quantidade = 60,
                CategoriasId = 3
            });
            //Moveis Category
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 12,
                Nome = "Cadeira de escritório de couro preto",
                Descricao = "Cadeira de escritório em couro preto muito confortável",
                ImagemUrl = "/Imagens/Moveis/m1.png",
                Preco = 50,
                Quantidade = 212,
                CategoriasId = 2
            });

            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 13,
                Nome = "Cadeira de escritório de couro rosa",
                Descricao = "Cadeira de escritório em couro rosa muito confortável",
                ImagemUrl = "/Imagens/Moveis/m2.png",
                Preco = 50,
                Quantidade = 112,
                CategoriasId = 2
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 14,
                Nome = "Espreguiçadeira",
                Descricao = "Poltrona muito confortável",
                ImagemUrl = "/Imagens/Moveis/m3.png",
                Preco = 70,
                Quantidade = 90,
                CategoriasId = 2
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 15,
                Nome = "Silver Lounge Chair",
                Descricao = "Poltrona prateada muito confortável",
                ImagemUrl = "/Imagens/Moveis/m4.png",
                Preco = 120,
                Quantidade = 95,
                CategoriasId = 2
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 16,
                Nome = "Luminária de mesa de porcelana",
                Descricao = "Abajur de mesa de porcelana branco e azul",
                ImagemUrl = "/Imagens/Moveis/m6.png",
                Preco = 15,
                Quantidade = 100,
                CategoriasId = 2
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 17,
                Nome = "Office Table Lamp",
                Descricao = "Abajur de mesa de escritório",
                ImagemUrl = "/Imagens/Moveis/m7.png",
                Preco = 20,
                Quantidade = 73,
                CategoriasId = 2
            });
            //Calcados Category
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 18,
                Nome = "Tênis Puma",
                Descricao = "Tênis Puma confortáveis na maioria dos tamanhos",
                ImagemUrl = "/Imagens/Calcados/c1.png",
                Preco = 100,
                Quantidade = 50,
                CategoriasId = 4
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 19,
                Nome = "Tênis Colodiros",
                Descricao = "Tênis coloridos - disponíveis na maioria dos tamanhos",
                ImagemUrl = "/Imagens/Calcados/c2.png",
                Preco = 150,
                Quantidade = 60,
                CategoriasId = 4
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 20,
                Nome = "Tênis Nike Azul",
                Descricao = "Tênis Nike azul - disponível na maioria dos tamanhos",
                ImagemUrl = "/Imagens/Calcados/c3.png",
                Preco = 200,
                Quantidade = 70,
                CategoriasId = 4
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 21,
                Nome = "Tênis Hummel Coloridos",
                Descricao = "Treinadores Hummel coloridos - disponíveis na maioria dos tamanhos",
                ImagemUrl = "/Imagens/Calcados/c4.png",
                Preco = 120,
                Quantidade = 120,
                CategoriasId = 4
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 22,
                Nome = "Tênis Nike Vermelho",
                Descricao = "Tênis Nike vermelho - disponível na maioria dos tamanhos",
                ImagemUrl = "/Imagens/Calcados/c5.png",
                Preco = 200,
                Quantidade = 100,
                CategoriasId = 4
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 23,
                Nome = "Sandálidas Birkenstock",
                Descricao = "Sandálias Birkenstock - disponíveis na maioria dos tamanhos",
                ImagemUrl = "/Imagens/Calcados/c6.png",
                Preco = 50,
                Quantidade = 150,
                CategoriasId = 4
            });

            //Usuários
            modelBuilder.Entity<Usuario>().HasData(new Usuario
            {
                Id = 1,
                NomeUsuario = "Guil"

            });
            modelBuilder.Entity<Usuario>().HasData(new Usuario
            {
                Id = 2,
                NomeUsuario = "Anne"

            });

            //Adicionar Categorias

            modelBuilder.Entity<Categorias>().HasData(new Categorias
            {
                Id = 1,
                Nome = "Beleza",
                IconCSS = "fas fa-spa"
            });
            modelBuilder.Entity<Categorias>().HasData(new Categorias
            {
                Id = 2,
                Nome = "Moveis",
                IconCSS = "fas fa-couch"
            });
            modelBuilder.Entity<Categorias>().HasData(new Categorias
            {
                Id = 3,
                Nome = "Eletronicos",
                IconCSS = "fas fa-headphones"
            });
            modelBuilder.Entity<Categorias>().HasData(new Categorias
            {
                Id = 4,
                Nome = "Calcados",
                IconCSS = "fas fa-shoe-prints"
            });
        }
    }

   
}
