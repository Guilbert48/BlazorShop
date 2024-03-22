using BlazorShopModels.DTOs;
namespace BlazorShopWeb.Services
{
    public class ProdutoServices : IProdutosServices
    {
        public HttpClient _httpClient;
        public ILogger _logger;

        public ProdutoServices(HttpClient httpClient, ILogger logger)
        {
            _httpClient = httpClient;
            _logger = logger;
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
                _logger.LogError("Erro");
                throw;
            }          
        }
    }
}
