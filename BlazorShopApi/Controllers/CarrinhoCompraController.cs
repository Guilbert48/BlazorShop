using BlazorShopApi.Mapping;
using BlazorShopApi.Repositories;
using BlazorShopModels.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorShopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarrinhoCompraController : ControllerBase
    {
        private readonly ICarrinhoCompraRepository carrinhoCompraRepo;
        private readonly IProdutoRepository produtoRepo;

        private ILogger <CarrinhoCompraController> logger;

        public CarrinhoCompraController
            (
                ICarrinhoCompraRepository carrinhoCompraRepository, 
                IProdutoRepository produtoRepository,
                ILogger<CarrinhoCompraController> logger
            )
        {
            carrinhoCompraRepo = carrinhoCompraRepository;
            produtoRepo = produtoRepository;
            this.logger = logger;

        }
        [HttpGet]
        [Route("{usuarioId}/GetItems")]
        public async Task<ActionResult<IEnumerable<CarrinhoItemDto>>> GetItens(int usuarioId)
        {
            try
            {
                var carrinhoItens = await carrinhoCompraRepo.GetItens(usuarioId);
                if(carrinhoItens == null)
                {
                    return NoContent(); 
                }
                var produtos = await this.produtoRepo.GetItens();
                if(produtos == null)
                {
                    throw new Exception("Não existem produtos...");
                }
                var carrinhoItensDto = carrinhoItens.ConverterCarrinhoItemParaDto(produtos);
                return Ok(carrinhoItensDto);
            }
            catch(Exception ex) 
            {
                logger.LogError("Erro ao obter itens ");
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }


}
