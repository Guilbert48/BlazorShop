using BlazorShopApi.Entities;

namespace BlazorShopApi.Repositories
{
    public interface IProdutoRepository
    {
        Task<IEnumerable<Produto>> GetItens();
        Task<Produto> GetItem(int id);
        Task<IEnumerable<Produto>> GetItensPorCategoria(int id);

    }
}
