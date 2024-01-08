using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TratamentoExceptions
{
    public static class ClasseEstatica
    {
        public static void Exemplo()
        {
            //
            if (true)
            {
                throw new AlunoException("Mensagem customizada");
            }
        }
    }
}
