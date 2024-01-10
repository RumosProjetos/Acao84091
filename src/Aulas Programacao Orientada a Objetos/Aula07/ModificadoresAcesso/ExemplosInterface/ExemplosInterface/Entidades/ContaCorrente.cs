using ExemplosInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosInterface.Entidades
{
    internal class ContaCorrente : IOperacoesFinanceiras, IOperacoesEspecificasDeConta, IPromocoesAnuais
    {
        public string Numero { get; set; }
        private decimal Saldo { get; set; }

        public void DepositarDinheiro(decimal valor)
        {
            Saldo += valor;
        }

        public void LevantarDinheiro(decimal valor)
        {
            Saldo -= valor;
        }

        public decimal ConsultarSaldo()
        {
            return Saldo;
        }

        public void GerarExtrato()
        {
            //Dados do cliente
            //Valores depositados
            //Levantamentos
        }

        public void OperacaoEspecifica()
        {
            throw new NotImplementedException();
        }

        public void AplicarDesconto(decimal valor)
        {
            throw new NotImplementedException();
        }

    }
}
