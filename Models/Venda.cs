using ControleFinanceiroNetCore.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ControleFinanceiroNetCore.Models
{
    public class Venda : BaseModel
    {
        [Required(ErrorMessage = MensagemObrigatoria)]
        public DateTime Data { get; set; }

        public Cliente Cliente { get; set; }

        [Required(ErrorMessage = MensagemObrigatoria)]
        public Guid IdCliente { get; set; }

        [Display(Name = "Situação")]
        public Situacoes Situacao { get; set; }

        public ICollection<VendaItems> Itens { get; set; }
    }
}
