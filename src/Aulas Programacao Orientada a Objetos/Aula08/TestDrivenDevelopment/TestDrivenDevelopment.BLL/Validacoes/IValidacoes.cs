using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrivenDevelopment.BLL.Validacoes
{
    internal interface IValidacoes<T>
    {
        bool ValidarSexo(T entidade);
        bool ValidarNome(T entidade);
    }
}
