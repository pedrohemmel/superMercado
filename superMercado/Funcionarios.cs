using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace superMercado
{
    class Funcionarios
    {

        public String nome { get; private set; }

        public Funcionarios(string nome)
        {
            this.nome = nome;
        }

        public void adicionarProduto(Produtos produto, ListaProduto listaProduto)
        {
            listaProduto.adicionarProduto(produto);
        }

        //public override void removerProduto(int indice, ListaProduto listaProduto)
        //{
        //    listaProduto.RemoveAt(indice);
        //}

        public void fecharPedido(ListaProduto listaProduto)
        {

        }

        public virtual void removerProduto(int indice, ListaProduto listaProduto)
        {
            System.Windows.Forms.MessageBox.Show("Você não tem premissão para remover esse produto");
        }




    }
}
