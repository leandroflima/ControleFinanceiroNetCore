using System;

namespace ControleFinanceiroNetCore.Models
{
    public class PedidoItens
    {
        public Guid IdPedido { get; set; }

        public Guid IdProduto { get; set; }

        public decimal Quantidade { get; set; }

        public decimal Preco { get; set; }
    }
}
