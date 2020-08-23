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

        [Display(Name = "Código")]
        public int Codigo { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Display(Name = "Pontos")]
        public int Pontos { get; set; }
    }
}
