using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace superMercado
{
    class Produtos
    {

        public String nome { get; private set; }
        public double preco { get; private set; }

        public Produtos(string nome, double preco)
        {
            this.nome = nome;
            this.preco = preco;
        }

        public virtual double totalProduto()
        {
            return this.preco;
        }

    }
}
