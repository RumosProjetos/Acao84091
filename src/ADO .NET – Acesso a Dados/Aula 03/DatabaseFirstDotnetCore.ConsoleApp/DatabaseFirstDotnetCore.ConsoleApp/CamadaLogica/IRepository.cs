using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirstDotnetCore.ConsoleApp.CamadaLogica
{
    public interface IRepository<T, K> where T : class
    {
        //CRUD
        T? ObterPorId(K id);
        List<T>? ObterTodos();
        //TODO: Obter por categoria
        void CriarNovo(T entidade);
        bool Atualizar(K id, T entidade);
        bool ApagarPorId(K id);
    }
}
