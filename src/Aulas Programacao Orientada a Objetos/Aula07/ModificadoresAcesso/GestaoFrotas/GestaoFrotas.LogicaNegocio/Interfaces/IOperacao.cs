namespace GestaoFrotas.LogicaNegocio.Interfaces
{
    public interface IOperacao<T>
    {
        List<T> Adicionar(T item);
        T Atualizar(string identificador, T dadosNovos); 
        T Desativar(string identificador);
        T Localizar(string identificador);
        List<T> MostrarTodos();
    }
}
