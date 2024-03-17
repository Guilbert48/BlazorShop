using BlazorShopApi.Mapping;
using BlazorShopApi.Repositories;
using BlazorShopModels.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorShopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IProdutoRepository _produtoRepository;

        public  ProdutosController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProdutoDTO>>> GetItems()
        {
            try
            {
                var produtos = await _produtoRepository.GetItens();
                if(produtos == null)
                {
                    return NotFound();
                }
                else
                {
                    var produtoDtos =  produtos.ConverterProdutosParaDto();
                    return Ok(produtoDtos);
                }

            }catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao acessar a base de dados");
            }
        }

        [HttpGet("{id:int}")]

        public async Task<ActionResult<ProdutoDTO>> GetItem(int id)
        {
            try
            {
                var produto = await _produtoRepository.GetItem(id);
                if(produto == null)
                {
                    return BadRequest("Erro ao localizar o produto");
                }
                else
                {
                    var produtoDto = produto.ConverterProdutoParaDto();
                    return Ok(produtoDto);
                }
            }catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao acessar a base de dados");
            }
        }

        [HttpGet]
        [Route("GetItensPorCategoria/{CategoriaId}")]
        public async Task<ActionResult<IEnumerable<ProdutoDTO>>>
            GetItensPorCategoria(int CategoriaId)
        {
            try
            {
                var produtos = await _produtoRepository.GetItensPorCategoria(CategoriaId);
                var produtosDto = produtos.ConverterProdutosParaDto();

                return Ok(produtosDto);
            }catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao acessar a base de dados");

            }
        }
    }
}
