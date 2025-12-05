using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectControlcEstoque.Entidade
{
    class Produto
    {
        // attributes
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

        // Sobrescrevendo o método ToString()
        public override string ToString()
        {
            return $" Produto: {Nome} " +
                   $" Preço: R$ {Preco:F2} " +
                   $" Quantidade: {Quantidade}" +
                   $" Valor total em estoque: R$ {ValorEmEstoque():F2} ";
        }
    }
}
