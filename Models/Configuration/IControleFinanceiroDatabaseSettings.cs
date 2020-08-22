namespace ControleFinanceiroNetCore.Models.Configuration
{
    public interface IControleFinanceiroDatabaseSettings
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
