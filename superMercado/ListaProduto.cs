using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace superMercado
{
    class ListaProduto
    {

        public List<Produtos> listaProdutos { get; set; }
        public ListaProduto(List<Produtos> listaProdutos)
        {
            this.listaProdutos = listaProdutos;
        }

        public void adicionarProduto(Produtos produto)
        {
            this.listaProdutos.Add(produto);
        }

        public double total()
        {
            double valorTotal = 0;

            foreach(Produtos produto in listaProdutos)
            {
                valorTotal += produto.totalProduto();
            }

            return valorTotal;
        }

        public void removerProduto(int indice)
        {
            this.listaProdutos.RemoveAt(indice);
        }

        public void limparLista()
        {
            listaProdutos.Clear();
        }


    }
}
