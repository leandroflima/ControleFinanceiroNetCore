namespace ControleFinanceiroNetCore.Configuration
{
    public interface IControleFinanceiroDatabaseSettings
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
