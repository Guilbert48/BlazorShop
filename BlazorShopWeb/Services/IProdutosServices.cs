using BlazorShopModels.DTOs;

namespace BlazorShopWeb.Services
{
    public interface IProdutosServices
    {
        Task<IEnumerable<ProdutoDTO>> GetItens();
        Task<ProdutoDTO> GetItem(int id);
    }
}
