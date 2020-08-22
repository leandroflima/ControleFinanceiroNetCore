namespace ControleFinanceiroNetCore.Models.Configuration
{
    public class ControleFinanceiroDatabaseSettings : IControleFinanceiroDatabaseSettings
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
