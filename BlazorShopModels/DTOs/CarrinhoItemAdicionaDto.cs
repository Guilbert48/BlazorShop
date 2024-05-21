using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorShopModels.DTOs
{
    public class CarrinhoItemAdicionaDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int ProdutoId { get; set; }
        [Required]
        public int CarrinhoId { get; set; } 

        [Required] 
        public int Quantidade { get; set; }
    }
}
