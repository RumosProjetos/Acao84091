using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TratamentoExceptions
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public decimal Salario { get; set; }
        public decimal TaxaDoSeguro { get; set; }

        public decimal SalarioLiquido()
        {
            return Salario * 0.85M;
        }

        public decimal CalcularSeguroObrigatorio()
        {
            //if(TaxaDoSeguro == 0)
            //    return 0;

            try
            {
                return Salario / TaxaDoSeguro;
            }
            catch (Exception)
            {
                return 0;
                //throw;
            }
        }
    }
}
