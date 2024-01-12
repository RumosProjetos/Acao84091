using GestaoFrotas.LogicaNegocio.Interfaces;
using GestaoFrotas.ModeloDados.Entidades;

namespace GestaoFrotas.LogicaNegocio.Logica
{
    public class AutomovelManager : IOperacao<Automovel>
    {
        private List<Automovel> automoveis;

        public AutomovelManager() {
            automoveis = new List<Automovel>();
            automoveis.Add(new Automovel("10-10-10", "Ford Azul"));
            automoveis.Add(new Automovel("20-20-20", "VW Branco"));
            automoveis.Add(new Automovel("30-30-30", "Volvo Preto"));

        }
        public List<Automovel> Adicionar(Automovel item)
        {
            automoveis.Add(item);
            return automoveis;
        }

        public Automovel Atualizar(string identificador, Automovel dadosNovos)
        {
            Automovel automovel = Localizar(identificador);
            automovel.Ativo = dadosNovos.Ativo;
            automovel.Modelo = dadosNovos.Modelo;
            //automovel.Matricula = dadosNovos.Matricula; // Não vai acontecer porque é o identificador

            return automovel;
        }

        public Automovel Desativar(string identificador)
        {
            Automovel automovel = Localizar(identificador);
            automovel.Ativo = false;

            return automovel;
        }

        public Automovel Localizar(string identificador)
        {
            foreach (var item in automoveis)
            {
                if (item.Matricula == identificador)
                {
                    return item;
                }
            }

            return null;
        }
    }
}
