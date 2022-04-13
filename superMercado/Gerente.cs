using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace superMercado
{
    class Gerente : Funcionarios
    {
        public Gerente(string nome) : base(nome)
        {
        }

        public override void removerProduto(int indice, ListaProduto listaProduto)
        {
            listaProduto.removerProduto(indice);
        }
    }
}
