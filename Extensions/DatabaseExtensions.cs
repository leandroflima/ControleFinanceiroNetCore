using ControleFinanceiroNetCore.Models.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace ControleFinanceiroNetCore.Extensions
{
    public static class DatabaseExtensions
    {
        public static void AddDatabase(this IServiceCollection services, IConfiguration Configuration)
        {
            services.Configure<ControleFinanceiroDatabaseSettings>(
                Configuration.GetSection(nameof(ControleFinanceiroDatabaseSettings)));

            services.AddSingleton<IControleFinanceiroDatabaseSettings>(sp =>
                sp.GetRequiredService<IOptions<ControleFinanceiroDatabaseSettings>>().Value);
        }
    }
}
