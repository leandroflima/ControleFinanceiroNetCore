using ControleFinanceiroNetCore.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ControleFinanceiroNetCore.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<IFornecedorService, FornecedorService>();
            services.AddScoped<IPedidoService, PedidoService>();
            services.AddScoped<IProdutoService, ProdutoService>();
            services.AddScoped<IVendaService, VendaService>();
        }
    }
}
