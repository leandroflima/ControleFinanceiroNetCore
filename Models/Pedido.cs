using ControleFinanceiroNetCore.Models.Enum;
using System;
using System.ComponentModel.DataAnnotations;

namespace ControleFinanceiroNetCore.Models
{
    public class Pedido : BaseModel
    {
        [Display(Name = "Número")]
        public string NumeroPedido { get; set; }

        [Display(Name = "Nota Fiscal")]
        public string NotaFiscal { get; set; }

        public DateTime Data { get; set; }

        public Guid IdFornecedor { get; set; }

        [Display(Name = "Situação")]
        public Situacoes Situacao { get; set; }
    }
}
