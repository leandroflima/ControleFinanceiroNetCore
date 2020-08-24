using ControleFinanceiroNetCore.Models.Enum;
using ControleFinanceiroNetCore.Validation;
using System.ComponentModel.DataAnnotations;

namespace ControleFinanceiroNetCore.Models
{
    public class Cliente : BaseModel
    {
        [Required(ErrorMessage = MensagemObrigatoria)]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required(ErrorMessage = MensagemObrigatoria)]
        [CustomValidationCPF(ErrorMessage = "CPF inválido")]
        public long Documento { get; set; }

        [Required(ErrorMessage = MensagemObrigatoria)]
        [Display(Name = "Endereço")]
        [StringLength(100)]
        public string Endereco { get; set; }

        [Required(ErrorMessage = MensagemObrigatoria)]
        [StringLength(50)]
        public string Bairro { get; set; }

        [Required(ErrorMessage = MensagemObrigatoria)]
        [StringLength(50)]
        public string Cidade { get; set; }

        [Required(ErrorMessage = MensagemObrigatoria)]
        public Estados Estado { get; set; }

        [Required(ErrorMessage = MensagemObrigatoria)]
        [Phone]
        [Display(Name = "Telefone Principal")]
        public string TelefonePrincipal { get; set; }

        [Phone]
        [Display(Name = "Telefone Secundário")]
        public string TelefoneSecundario { get; set; }
    }
}
