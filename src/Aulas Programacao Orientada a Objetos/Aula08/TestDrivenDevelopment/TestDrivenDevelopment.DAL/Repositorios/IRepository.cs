using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrivenDevelopment.DAL.Repositorios
{
    public interface IRepository<T>
    {
        void Adicionar(T entidade);
        T Buscar(int id);
        List<T> BuscarTodos();
        void Atualizar(int id, T entidade);
        void Apagar(int id);
        void Gravar();
    }
}
