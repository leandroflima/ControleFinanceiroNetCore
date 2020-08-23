using System.ComponentModel.DataAnnotations;

namespace ControleFinanceiroNetCore.Models
{
    public class Fornecedor : BaseModel
    {
        public string Nome { get; set; }

        [Display(Name = "Telefone Principal")]
        public string TelefonePrincipal { get; set; }
    }
}
