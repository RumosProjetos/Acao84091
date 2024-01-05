using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TratamentoExceptions
{
    internal class AlunoException : Exception
    {
        string meuLog = "c:\\temp\\logExceptions.txt";
        public AlunoException(string message) : base(message) 
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Erro:");
            stringBuilder.AppendLine("======================");
            stringBuilder.AppendLine("Data e hora: " + DateTime.Now);
            stringBuilder.AppendLine("Exceção: " + Message);
            stringBuilder.AppendLine("Detalhe: " + StackTrace);

            File.AppendAllText(meuLog, stringBuilder.ToString());
        }
    }
}
