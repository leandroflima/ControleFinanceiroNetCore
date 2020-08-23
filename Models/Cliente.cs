using ControleFinanceiroNetCore.Models.Enum;
using System.ComponentModel.DataAnnotations;

namespace ControleFinanceiroNetCore.Models
{
    public class Cliente : BaseModel
    {
        public string Nome { get; set; }

        public long Documento { get; set; }

        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public Estados Estado { get; set; }

        [Display(Name = "Telefone Principal")]
        public string TelefonePrincipal { get; set; }

        [Display(Name = "Telefone Secundário")]
        public string TelefoneSecundario { get; set; }
    }
}
