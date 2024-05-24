using BlazorShopModels.DTOs;

namespace BlazorShopWeb.Services
{
    public interface ICarrinhoCompraService
    {
        Task<List<CarrinhoItemDto>> GetItens(string usuarioId);
        Task<CarrinhoItemDto> AdicionaItem(CarrinhoItemAdicionaDto carrinhoItemAdicionaDto);
    }
}
