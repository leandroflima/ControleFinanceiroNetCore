using ControleFinanceiroNetCore.Models.Enum;

namespace ControleFinanceiroNetCore.Models
{
    public class Cliente : BaseModel
    {
        public string Nome { get; set; }

        public long Documento { get; set; }

        public string Endereco { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public Estados Estado { get; set; }

        public string TelefonePrincipal { get; set; }

        public string TelefoneSecundario { get; set; }
    }
}
