using System;

namespace ControleFinanceiroNetCore.Models
{
    public class BaseModel
    {
        public const string MensagemObrigatoria = "Preenchimento obrigatório!";

        public Guid Id { get; set; }
    }
}
