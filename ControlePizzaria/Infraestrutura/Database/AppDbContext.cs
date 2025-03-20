using Microsoft.EntityFrameworkCore;
using ControlePizzaria.Dominio.Entidades;


namespace ControlePizzaria.Infraestrutura.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Pizza> Pizzas { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder options)
            {
                var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "estoque.db");
                Console.WriteLine($"Banco de dados em: {path}");
                options.UseSqlite($"Data Source={path}");
            }

        }
    }

