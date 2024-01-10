using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadoresAcesso.Utilitarios
{
    internal static class Estatica
    {
        public static string MeuValor { get; set; }

        public static string ConverterParaMaiusculas() {  return MeuValor.ToUpper(); }

    }
}
