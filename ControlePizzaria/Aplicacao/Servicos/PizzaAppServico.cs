using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlePizzaria.Dominio.Entidades;
using ControlePizzaria.Dominio.Servicos;
using ControlePizzaria.Infraestrutura.Repositorios;

namespace ControlePizzaria.Aplicacao.Servicos
{
    public class PizzaAppServico : IPizzaAppServico
    {
        private readonly IPizzaDominioServico _dominioServico;
        private readonly IPizzaRepositorio _pizzaRepositorio;

        public PizzaAppServico(IPizzaDominioServico dominioServico, IPizzaRepositorio pizzaRepositorio)
        {
            _dominioServico = dominioServico;
            _pizzaRepositorio = pizzaRepositorio;
        }

        void IPizzaAppServico.AlterarPizza(int id, string nomePizza, decimal preco)
        {
            _dominioServico.ValidarId(id);

            var pizzaExistente = _pizzaRepositorio.GetPizza(id);
            if (pizzaExistente == null)
            {
                throw new Exception("Pizza não encontrada para alteração");
            }
            pizzaExistente.Nome = nomePizza;
            pizzaExistente.Preco = preco;

            _dominioServico.Validar(pizzaExistente);
            _pizzaRepositorio.Alterar(pizzaExistente);
        }

        void IPizzaAppServico.CadastrarPizza(string nomePizza, decimal preco)
        {
            var pizza = new Pizza(nomePizza, preco);
            _dominioServico.Validar(pizza);
            _pizzaRepositorio.Salvar(pizza);
        }

        void IPizzaAppServico.ExcluirPizza(Pizza pizza)
        {
            var pizzaExistente = _pizzaRepositorio.GetPizza(pizza.Id);
            if (pizzaExistente == null)
            {
                throw new Exception("Pizza não encontrada para exclusão");
            }

            _pizzaRepositorio.Excluir(pizzaExistente);
        }

        List<Pizza> IPizzaAppServico.GetPizzas()
        {
            return _pizzaRepositorio.GetPizzas();
        }
    }
}
