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
        [HttpGet]
        public async Task<ActionResult<CarrinhoItemDto>> GetItem(int id)
        {
            try
            {
                var carrinhoItem = await carrinhoCompraRepo.GetItem(id);
                if(carrinhoItem == null)
                {
                    return NotFound($"Item não encontrado");
                }

                var produto = await produtoRepo.GetItem(carrinhoItem.ProdutoId);
                if (produto == null)
                {
                    return NotFound($"Item não existe na base de dados");
                }
                var cartItemDto = carrinhoItem.ConverterCarrinhoItemParaDto(produto);
                return Ok(cartItemDto);
            }
            catch (Exception ex)
            {
                logger.LogError($"Erro ao obter item = {id} do carrinho");
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
    
        public async Task<ActionResult<CarrinhoItemDto>> PostItem([FromBody] CarrinhoItemAdicionaDto carrinhoItemAdicionaDto)
        {
            try
            {
                var novocarrinhoItem = await carrinhoCompraRepo.AdicionaItem(carrinhoItemAdicionaDto);
                if(novocarrinhoItem == null)
                {
                    return NoContent();
                }

                var produto = await produtoRepo.GetItem(novocarrinhoItem.ProdutoId);

                if (produto == null)
                {
                    throw new Exception($"Produto não localizado(Id:({carrinhoItemAdicionaDto.ProdutoId})");
                }

                var novoCarrinhoItemDto = novocarrinhoItem.ConverterCarrinhoItemParaDto(produto);
                return CreatedAtAction(nameof(GetItem), new {id = novoCarrinhoItemDto.Id}, novoCarrinhoItemDto);

            }catch(Exception ex)
            {
                logger.LogError("Erro ao criar um novo item no carrinho");
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }


}
