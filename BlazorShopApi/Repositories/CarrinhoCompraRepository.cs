using BlazorShopApi.Context;
using BlazorShopApi.Entities;
using BlazorShopModels.DTOs;
using Microsoft.EntityFrameworkCore;

namespace BlazorShopApi.Repositories
{
    public class CarrinhoCompraRepository : ICarrinhoCompraRepository
    {
        private readonly AppDbContext _context;
        public CarrinhoCompraRepository(AppDbContext context)
        {
            _context = context;
        }

        public Task<CarrinhoItem> AdicionaItem(CarrinhoItemAdicionaDto carrinhoItemAdicionaDto)
        {
            throw new NotImplementedException();
        }

        public Task<CarrinhoItem> AtualizaQuantidade(int id, CarrinhoItemAttQuantidadeDto carrinhoItemAtualizaQuantidadeDto)
        {
            throw new NotImplementedException();
        }

        public Task<CarrinhoItem> DeletaItem(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<CarrinhoItem> GetItem(int id)
        {
            return await (
                         from carrinho in _context.Carrinhos
                         join CarrinhoItem in _context.carrinhoItems
                         on carrinho.Id equals CarrinhoItem.CarrinhoId
                         where carrinho.Id == id
                         select new CarrinhoItem
                         {
                             Id = CarrinhoItem.Id,
                             ProdutoId = CarrinhoItem.Id,
                             Quantidade = CarrinhoItem.Quantidade,
                             CarrinhoId = CarrinhoItem.Id
                         }).SingleOrDefaultAsync();
        }

        public Task<IEnumerable<CarrinhoItem>> GetItem(string usuarioId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CarrinhoItem>> GetItems(int usuarioId)
        {
            return await (
                          from Carrinho in _context.Carrinhos
                          join CarrinhoItem in _context.carrinhoItems
                          on Carrinho.Id equals CarrinhoItem.CarrinhoId
                          where Carrinho.UsuarioId == usuarioId
                          select new CarrinhoItem
                          {
                              Id = CarrinhoItem.Id,
                              ProdutoId = CarrinhoItem.ProdutoId,
                              Quantidade = CarrinhoItem.Quantidade,
                              CarrinhoId = CarrinhoItem.Id,
                          }).ToListAsync();
        }


    }
}
