using ControleFinanceiroNetCore.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ControleFinanceiroNetCore.Models
{
    public class Pedido : BaseModel
    {
        [Required(ErrorMessage = MensagemObrigatoria)]
        [StringLength(20)]
        [Display(Name = "Número")]
        public string NumeroPedido { get; set; }

        [Required(ErrorMessage = MensagemObrigatoria)]
        [StringLength(20)]
        [Display(Name = "Nota Fiscal")]
        public string NotaFiscal { get; set; }

        [Required(ErrorMessage = MensagemObrigatoria)]
        public DateTime Data { get; set; }

        public Fornecedor Fornecedor { get; set; }

        [Required(ErrorMessage = MensagemObrigatoria)]
        public Guid IdFornecedor { get; set; }

        [Display(Name = "Situação")]
        public Situacoes Situacao { get; set; }

        public ICollection<PedidoItens> Itens { get; set; }
    }
}
