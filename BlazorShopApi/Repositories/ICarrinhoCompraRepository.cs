using BlazorShopApi.Entities;
using BlazorShopModels.DTOs;

namespace BlazorShopApi.Repositories
{
    public interface ICarrinhoCompraRepository
    {
        Task<CarrinhoItem> AdicionaItem(CarrinhoItemAdicionaDto carrinhoItemAdicionaDto);
        Task<CarrinhoItem> AtualizaQuantidade(int id, CarrinhoItemAttQuantidadeDto carrinhoItemAtualizaQuantidadeDto);
        Task<CarrinhoItem> DeletaItem(int id);
        Task<CarrinhoItem> GetItem (int id);
        Task<IEnumerable<CarrinhoItem>> GetItens(int id);

    }
}
