using ProjectControlcEstoque.Entidade;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ProjetoControleEstoque.Application
{
     class Program
    {
      static void Main(string[] args)
        {
            Produto produto = new Produto();

            Console.WriteLine("Entre com os dados do produto:");

            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            produto.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Dados do produto:{produto}");
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int quant = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(quant);
            Console.WriteLine();
            Console.WriteLine($"Dados atualizados : {produto}");

            Console.Write("Digite o número de produtos a ser removidos do estoque: ");
            quant = int.Parse(Console.ReadLine());
            produto.RemoverProduto(quant);
            Console.WriteLine();
            Console.WriteLine($"Dados atualizados : {produto}");


        }
    }
}
