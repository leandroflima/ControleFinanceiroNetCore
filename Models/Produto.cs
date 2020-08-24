using System;
using System.ComponentModel.DataAnnotations;

namespace ControleFinanceiroNetCore.Models
{
    public class Produto : BaseModel
    {
        public Produto()
        {
            Id = Guid.NewGuid();
        }

        [Required(ErrorMessage = MensagemObrigatoria)]
        [Range(0, 99999)]
        [Display(Name = "Código")]
        public int Codigo { get; set; }

        [Required(ErrorMessage = MensagemObrigatoria)]
        [StringLength(100)]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = MensagemObrigatoria)]
        [Range(0, 999)]
        [Display(Name = "Pontos")]
        public int Pontos { get; set; }
    }
}
