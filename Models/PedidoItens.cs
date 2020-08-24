using System;
using System.ComponentModel.DataAnnotations;

namespace ControleFinanceiroNetCore.Models
{
    public class PedidoItens
    {
        public const string MensagemObrigatoria = "Preenchimento obrigatório!";

        public Produto Produto { get; set; }

        [Required(ErrorMessage = MensagemObrigatoria)]
        public Guid IdProduto { get; set; }

        [Required(ErrorMessage = MensagemObrigatoria)]
        [Range(0, 999999)]
        public decimal Quantidade { get; set; }

        [Required(ErrorMessage = MensagemObrigatoria)]
        [Range(0, 9999999)]
        [Display(Name = "Preço")]
        public decimal Preco { get; set; }
    }
}
