using BlazorShopApi.Context;
using BlazorShopApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorShopApi.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly AppDbContext _context;

        public ProdutoRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Produto> GetItem(int id)
        {
            var produto = await _context.Produtos
                .Include(c => c.Categorias)
                .SingleOrDefaultAsync(c => c.Id == id);

            return produto;
        }

        public async Task<IEnumerable<Produto>> GetItens()
        {
            var produtos = await _context.Produtos.Include(c => c.Categorias).ToListAsync();
            return produtos;
        }

        public async Task<IEnumerable<Produto>> GetItensPorCategoria(int id)
        {
            var produtos =  await _context.Produtos
                .Include(p => p.Categorias)
                .Where(p => p.CategoriaId == id)
                .ToListAsync();

            return produtos;
        }
    }
}
