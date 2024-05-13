using BlazorShopModels.DTOs;
using System.Linq.Expressions;
using System.Net;
namespace BlazorShopWeb.Services
{
    public class ProdutoServices : IProdutosServices
    {
        public HttpClient _httpClient;
        public ILogger<ProdutoServices> _logger;

        public ProdutoServices(HttpClient httpClient, ILogger<ProdutoServices>logger)
        {
            _httpClient = httpClient;
            _logger = logger;   
           
        }

        public async Task<ProdutoDTO> GetItem(int id)
        {
            try
            {
                var response = await _httpClient.GetAsync($"api/produtos/{id}");
                if(response.IsSuccessStatusCode)
                {
                    if(response.StatusCode == HttpStatusCode.NoContent)
                    {
                        return default(ProdutoDTO);
                    }
                    return await response.Content.ReadFromJsonAsync<ProdutoDTO>();
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    _logger.LogError($"Erro ao obter produto pelo id= {id} - {message}");
                    throw new Exception($"Status code: {response.StatusCode} - {message}");
                }
               
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<ProdutoDTO>> GetItens()
        {
            try
            {
                var produtosDto = await _httpClient.GetFromJsonAsync<IEnumerable<ProdutoDTO>>("api/produtos");
                return produtosDto;
            }
            catch
            (Exception ex)
            {
                _logger.LogError("Erro ao acessar a api : produtos");
                throw;
            }          
        }
    }
}
