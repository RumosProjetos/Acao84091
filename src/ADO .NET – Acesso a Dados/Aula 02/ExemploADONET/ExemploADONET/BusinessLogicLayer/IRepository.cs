using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploADONET.BusinessLogicLayer
{
    public interface IRepository<T> where T : class
    {
        List<T> BuscarTodos();
        T ObterPorId(int id);
        void CriarNovo(T entidade);
        int Apagar(int id);
        int Atualizar(int id, T entidade);
    }
}
