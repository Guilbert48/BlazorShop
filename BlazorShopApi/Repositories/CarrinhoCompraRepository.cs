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

        public async Task<CarrinhoItem> AdicionaItem(CarrinhoItemAdicionaDto carrinhoItemAdicionaDto)
        {
            //Verifica se o produto já existe 
            if (await carrinhoItemJaExiste(carrinhoItemAdicionaDto.CarrinhoId, carrinhoItemAdicionaDto.ProdutoId) == false)
            {
                //Cria um novo item no carrinho
                var item = await (from produto in _context.Produtos
                                  where produto.Id == carrinhoItemAdicionaDto.ProdutoId
                                  select new CarrinhoItem
                                  {
                                      CarrinhoId = carrinhoItemAdicionaDto.CarrinhoId,
                                      ProdutoId = carrinhoItemAdicionaDto.ProdutoId,
                                      Quantidade = carrinhoItemAdicionaDto.Quantidade,

                                  }).SingleOrDefaultAsync();

                //Se o item existir então incluir o item no carrinho 

                if(item is not null)
                {
                    var resultado = await _context.carrinhoItems.AddAsync(item);
                    await _context.SaveChangesAsync();
                    return resultado.Entity;
                }
            }
            return null;

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
        private async Task<bool> carrinhoItemJaExiste(int carrinhoid, int produtoId)
        {
            return await _context.carrinhoItems.AnyAsync( c => c.CarrinhoId == carrinhoid && c.ProdutoId == produtoId);
        }

        public async Task<IEnumerable<CarrinhoItem>> GetItens(int usuarioId)
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
