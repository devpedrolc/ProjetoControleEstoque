using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoControleEstoque.Entidade
{
     class Produto
    {
        //atributos
        public string Nome;
        public double Preco;
        public int Quantidade;
        // métodos

       
        public double ValorEmEstoque()
        {
            return Preco * Quantidade;

        }
        public void AdicionarProdutos(int quantity)
        {
            this.Quantidade += quantity;
        }

        public void RemoverProduto(int quantity)
        {
            this.Quantidade -= quantity;
        }


    }
}
