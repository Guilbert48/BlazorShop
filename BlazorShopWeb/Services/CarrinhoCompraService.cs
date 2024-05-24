using BlazorShopModels.DTOs;

namespace BlazorShopWeb.Services
{
    public class CarrinhoCompraService : ICarrinhoCompraService
    {
        public Task<CarrinhoItemDto> AdicionaItem(CarrinhoItemAdicionaDto carrinhoItemAdicionaDto)
        {
            throw new NotImplementedException();
        }

        public Task<List<CarrinhoItemDto>> GetItens(string usuarioId)
        {
            throw new NotImplementedException();
        }
    }
}
