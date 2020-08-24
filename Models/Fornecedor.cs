using System.ComponentModel.DataAnnotations;

namespace ControleFinanceiroNetCore.Models
{
    public class Fornecedor : BaseModel
    {
        [Required(ErrorMessage = MensagemObrigatoria)]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required(ErrorMessage = MensagemObrigatoria)]
        [Phone]
        [Display(Name = "Telefone Principal")]
        public string TelefonePrincipal { get; set; }
    }
}
