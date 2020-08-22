using ControleFinanceiroNetCore.Models.Enum;
using System;

namespace ControleFinanceiroNetCore.Models
{
    public class Pedido : BaseModel
    {
        public string NumeroPedido { get; set; }

        public string NotaFiscal { get; set; }

        public DateTime Data { get; set; }

        public Guid IdFornecedor { get; set; }

        public Situacoes Situacao { get; set; }
    }
}
