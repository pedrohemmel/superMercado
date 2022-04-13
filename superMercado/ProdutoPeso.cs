using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace superMercado
{
    class ProdutoPeso : Produtos
    {

        public double peso { get; private set; }
        public ProdutoPeso(string nome, double preco, double peso) : base(nome, preco)
        {
            this.peso = peso;
        }
    }
}
