using System.ComponentModel.DataAnnotations;

namespace BlazorShopApi.Entities
{
    public class Usuario
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string NomeUsuario { get; set; } = string.Empty; 
        public Carrinho ? Carrinho { get; set; }    
    }
}
