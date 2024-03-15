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
            modelBuilder.Entity<Categorias>().HasData(new Categorias
            {
                Id = 1,
                Nome = "Beleza",
                IconCSS = "fas fa-spa"
            });

            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 1,
                Nome = "Gloss - Beleza kit",
                Descricao = "Kit de beleza e cuidados com a pele",
                ImagemUrl = "Imagens/Beleza/Beleza1.png",
                Preco = 100,
                Quantidade = 100,
                CategoriaId = 1,
            });

        }
    }

   
}
