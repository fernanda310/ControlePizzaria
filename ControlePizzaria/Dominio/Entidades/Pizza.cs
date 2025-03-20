using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlePizzaria.Dominio.Entidades
{
    public class Pizza
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public Pizza(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public Pizza(int id, string nome, decimal preco)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
        }


    }
}
