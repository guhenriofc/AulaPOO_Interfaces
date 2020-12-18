using System;
using System.Collections.Generic;

namespace AulaPOO_Interfaces.Classes.cs
{
    public class Carrinho : ICarrinho
    {
        List<Produto> carrinho = new List<Produto>();
        public void Alterar(int _codigo, Produto novoProduto)
        {
            carrinho.Find(x => x.Codigo == _codigo).Nome = novoProduto.Nome;
            carrinho.Find(x => x.Codigo == _codigo).Preco = novoProduto.Preco;
            carrinho.Find(x => x.Codigo == _codigo).Codigo = novoProduto.Codigo;
        }

        public void Cadastrar(Produto _produto)
        {
            carrinho.Add(_produto);
        }

        public void Deletar(Produto _produto)
        {
            carrinho.Remove(_produto);
        }

        public void Listar()
        {
            foreach (Produto item in carrinho)
            {
                Console.WriteLine($"Codigo do produto: {item.Codigo}");
                Console.WriteLine($"Codigo do produto: {item.Nome}");
                Console.WriteLine($"Codigo do produto: {item.Preco}");
            }
        }
    }
}