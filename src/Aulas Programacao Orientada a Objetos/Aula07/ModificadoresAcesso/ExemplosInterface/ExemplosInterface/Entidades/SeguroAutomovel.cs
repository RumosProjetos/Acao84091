using ExemplosInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosInterface.Entidades
{
    public class SeguroAutomovel : IOperacoesFinanceiras, IPromocoesAnuais
    {
        public decimal Premio { get; set; }
        public void GerarFatura() { }
        public void PagarSinistro() { }

        public void GerarExtrato()
        {
            //Dados do carro
            //Valores pagos
            //Faturas do ano
        }

        public void AplicarDesconto(decimal valor)
        {
            throw new NotImplementedException();
        }
    }
}
