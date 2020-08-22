namespace ControleFinanceiroNetCore.Models
{
    public class Produto : BaseModel
    {
        public int Codigo { get; set; }

        public string Descricao { get; set; }

        public int Pontos { get; set; }
    }
}
