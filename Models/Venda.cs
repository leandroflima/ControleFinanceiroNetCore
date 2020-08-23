using ControleFinanceiroNetCore.Models.Enum;
using System;
using System.ComponentModel.DataAnnotations;

namespace ControleFinanceiroNetCore.Models
{
    public class Venda : BaseModel
    {
        public DateTime Data { get; set; }

        public Guid IdCliente { get; set; }

        [Display(Name = "Situação")]
        public Situacoes Situacao { get; set; }
    }
}
