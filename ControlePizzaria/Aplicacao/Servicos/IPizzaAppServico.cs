using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlePizzaria.Dominio.Entidades;
using ControlePizzaria.Infraestrutura.Repositorios;

namespace ControlePizzaria.Aplicacao.Servicos
{
    public interface IPizzaAppServico
    {
        public void CadastrarPizza(string nomePizza, decimal preco);
        void AlterarPizza(int id, string nomePizza, decimal preco);
        void ExcluirPizza(Pizza pizza);
        List<Pizza> GetPizzas();
    }
}
