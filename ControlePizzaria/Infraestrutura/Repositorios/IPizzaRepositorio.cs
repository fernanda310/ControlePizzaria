using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlePizzaria.Dominio.Entidades;

namespace ControlePizzaria.Infraestrutura.Repositorios
{
    public interface IPizzaRepositorio
    {
        void Salvar (Pizza pizza);

        void Excluir (Pizza pizza);

        void Alterar (Pizza pizza);

        Pizza? GetPizza (int id);

        List<Pizza> GetPizzas();
    }
}
