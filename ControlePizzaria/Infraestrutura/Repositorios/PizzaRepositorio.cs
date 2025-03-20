using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlePizzaria.Dominio.Entidades;
using ControlePizzaria.Infraestrutura.Database;

namespace ControlePizzaria.Infraestrutura.Repositorios
{
    public class PizzaRepositorio : IPizzaRepositorio
    {
        private readonly AppDbContext _context;

        public PizzaRepositorio(AppDbContext context)
        {
            _context = context;
        }

        public Pizza? GetPizza(int id)
        {
            return _context.Pizzas.Find(id);
        }

        public List<Pizza> GetPizzas()
        {
            return _context.Pizzas.ToList();
        }

        public void Salvar(Pizza pizza)
        {
            _context.Pizzas.Add(pizza);
            _context.SaveChanges();
        }

        void IPizzaRepositorio.Alterar(Pizza pizza)
        {
            var pizzaExistente = _context.Pizzas.Find(pizza.Id);
            if (pizzaExistente == null)
            {
                throw new Exception("Pizza não existente");
            }

            pizzaExistente.Nome = pizza.Nome;
            pizzaExistente.Preco = pizza.Preco;
        }

        void IPizzaRepositorio.Excluir(Pizza pizza)
        {
            _context.Remove(pizza);
            _context.SaveChanges();
        }
    }
}
