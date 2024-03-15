using BlazorShopApi.Entities;
using BlazorShopModels.DTOs;

namespace BlazorShopApi.Mapping
{
    public static class MappingDtos
    {
        public static IEnumerable<CategoriaDTO> ConverterCategoriasParaDto(this IEnumerable<Categorias> categorias)
        {
            return (from categoria in categorias
                    select new CategoriaDTO
                    {
                        Id = categoria.Id,
                        Nome = categoria.Nome,
                        IconCSS = categoria.IconCSS,
                    }).ToList();
        }

        public static IEnumerable<ProdutoDTO> ConverterProdutosParaDto(this IEnumerable<Produto> produtos)
        {
            return( from produto in produtos
                select new ProdutoDTO
                {
                    Id = produto.Id,
                    Nome = produto.Nome,
                    Descricao = produto.Descricao,
                    ImagemUrl = produto.ImagemUrl,
                    Preco = produto.Preco,
                    Quantidade = produto.Quantidade,
                    CategoriaId = produto.CategoriaId,
                    CategoriaNome = produto.Categorias.Nome

                }).ToList();
        }
        public static ProdutoDTO ConverterProdutosParaDto(Produto produto)
        {
            return new ProdutoDTO
            {
                Id = produto.Id,
                Nome = produto.Nome,
                Descricao = produto.Descricao,
                ImagemUrl = produto.ImagemUrl,
                Preco = produto.Preco,
                Quantidade = produto.Quantidade,
                CategoriaId = produto.CategoriaId,
                CategoriaNome = produto.Categorias.Nome
            };             
        }
        public static IEnumerable<CarrinhoItemDto> ConverterCarrinhoItemParaDto(this IEnumerable<CarrinhoItem> carrinhoItens, IEnumerable<Produto> produtos)
        {
            return (from carrinhoItem in carrinhoItens
                    join produto in produtos 
                    on carrinhoItem.ProdutoId equals produto.Id
                    select new CarrinhoItemDto
                    {
                        Id = carrinhoItem.Id,
                        ProdutoId = carrinhoItem.ProdutoId,
                        ProdutoNome = produto.Nome,
                        ProdutoDescricao = produto.Descricao,
                        ProdutoImagemUrl = produto.ImagemUrl,
                        Preco = produto.Preco,
                        CarrinhoId = carrinhoItem.CarrinhoId,
                        Quantidade = carrinhoItem.Quantidade,
                        PrecoTotal = produto.Preco * carrinhoItem.Quantidade
                    }).ToList();
        }
    }
}
