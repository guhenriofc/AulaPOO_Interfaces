namespace AulaPOO_Interfaces.Classes.cs
{
    public interface ICarrinho
    {
         void Cadastrar(Produto _produto);
         void Alterar(int _codigo,  Produto novoProduto);
         void Deletar(Produto _produto);
         void Listar();
    }
}