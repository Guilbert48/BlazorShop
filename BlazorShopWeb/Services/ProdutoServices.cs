using BlazorShopModels.DTOs;
namespace BlazorShopWeb.Services
{
    public class ProdutoServices : IProdutosServices
    {
        public HttpClient _httpClient;
        

        public ProdutoServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
           
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

                throw;
            }          
        }
    }
}
