using System;

namespace ControleFinanceiroNetCore.Models
{
    public class VendaItems
    {
        public Guid IdVenda { get; set; }

        public Guid IdProduto { get; set; }

        public decimal Quantidade { get; set; }

        public decimal Preco { get; set; }
    }
}
