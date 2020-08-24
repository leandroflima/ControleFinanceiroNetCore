namespace ControleFinanceiroNetCore.Configuration
{
    public class ControleFinanceiroDatabaseSettings : IControleFinanceiroDatabaseSettings
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
