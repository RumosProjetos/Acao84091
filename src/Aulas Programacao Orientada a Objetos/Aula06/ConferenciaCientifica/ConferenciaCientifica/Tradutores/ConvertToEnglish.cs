using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenciaCientifica.Tradutores
{
    public static class ConvertToEnglish
    {
        /// <summary>
        /// Simula a "tradução", nesse exemplo apenas inverte a ordem das letras
        /// </summary>
        /// <param name="origem"></param>
        /// <returns></returns>
        public static string Translate(string origem) {
            char[] charArray = origem.ToCharArray();
            Array.Reverse(charArray);
            string result = new string(charArray);
            return result;
        }
    }
}
