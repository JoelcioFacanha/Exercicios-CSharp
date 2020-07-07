using ControleEstoque.Entities;
using System;
using System.Globalization;

namespace ControleEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            Console.WriteLine("Entre com os dados do Produto:");
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade em estoque: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + produto);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a serem adicionados ao estoque: ");
            produto.AdicionarProdutos(int.Parse(Console.ReadLine()));

            Console.WriteLine();
            Console.WriteLine("Dados Atualizado: " + produto);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a serem removidos do estoque: ");
            produto.RemoverProdutos(int.Parse(Console.ReadLine()));

            Console.WriteLine();
            Console.WriteLine("Dados Atualizado: " + produto);
        }
    }
}
