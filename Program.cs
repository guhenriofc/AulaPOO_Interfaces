using System;
using AulaPOO_Interfaces.Classes.cs;

namespace AulaPOO_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrinho produtosDoCarrinho = new Carrinho();

            //Nomeando os produtos
            Produto produto1 = new Produto();
            produto1.Codigo = 0035;
            produto1.Nome = "Iphone 7";
            produto1.Preco = 1900.00f;

            Produto produto2 = new Produto();
            produto2.Codigo = 0037;
            produto2.Nome = "Iphone X";
            produto2.Preco = 3500.00f;

            Produto produto3 = new Produto();
            produto3.Codigo = 0040;
            produto3.Nome = "Iphone 12";
            produto3.Preco = 5000.00f;

            Produto produto4 = new Produto();
            produto4.Codigo = 0042;
            produto4.Nome = "Iphone 12 Pro Max";
            produto4.Preco = 6500.00f;

            //Cadastrando os produtos
            Console.ForegroundColor = ConsoleColor.Green;
            produtosDoCarrinho.Cadastrar(produto1);
            produtosDoCarrinho.Cadastrar(produto2);
            produtosDoCarrinho.Cadastrar(produto3);
            produtosDoCarrinho.Cadastrar(produto4);
            produtosDoCarrinho.Listar();

            //Deletando os produtos
            Console.ForegroundColor = ConsoleColor.Red;
            produtosDoCarrinho.Deletar(produto2);
            produtosDoCarrinho.Listar();

            //Alterando os produtos
            Console.ForegroundColor = ConsoleColor.Yellow;
            produtosDoCarrinho.Alterar(produto3.Codigo, produto4);
            produtosDoCarrinho.Listar();
        }
    }
}
