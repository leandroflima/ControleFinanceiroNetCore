using System;
using System.ComponentModel.DataAnnotations;

namespace ControleFinanceiroNetCore.Models
{
    public class PedidoItens
    {
        public Guid IdPedido { get; set; }

        public Guid IdProduto { get; set; }

        public decimal Quantidade { get; set; }

        [Display(Name = "Preço")]
        public decimal Preco { get; set; }
    }
}
