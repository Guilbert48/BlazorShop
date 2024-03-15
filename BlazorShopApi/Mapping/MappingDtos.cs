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
    }
}
