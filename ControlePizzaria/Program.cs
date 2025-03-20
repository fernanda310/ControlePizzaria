using ControlePizzaria.Aplicacao.Servicos;
using ControlePizzaria.Dominio.Servicos;
using ControlePizzaria.Infraestrutura.Database;
using ControlePizzaria.Infraestrutura.Repositorios;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ControlePizzaria
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlite("Data Source=estoque.db"));

            services.AddScoped<IPizzaDominioServico, PizzaDominioServico>();

            services.AddScoped<IPizzaRepositorio, PizzaRepositorio>();
            services.AddScoped<IPizzaAppServico, PizzaAppServico>();

            var serviceProvider = services.BuildServiceProvider();


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmControlePizzaria(serviceProvider));
        }
    }
}