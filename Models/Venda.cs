using ControleFinanceiroNetCore.Models.Enum;
using System;

namespace ControleFinanceiroNetCore.Models
{
    public class Venda : BaseModel
    {
        public DateTime Data { get; set; }

        public Guid IdCliente { get; set; }

        public Situacoes Situacao { get; set; }
    }
}
