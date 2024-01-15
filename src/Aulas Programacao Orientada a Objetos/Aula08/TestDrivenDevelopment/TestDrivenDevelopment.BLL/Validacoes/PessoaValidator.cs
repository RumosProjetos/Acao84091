using TestDrivenDevelopment.DAL.Entidades;

namespace TestDrivenDevelopment.BLL.Validacoes
{
    public class PessoaValidator : IValidacoes<Pessoa>
    {
        public bool ValidarNome(Pessoa entidade)
        {
            //Regra 01
            //Pessoa tem que ter mais de 3 caracteres
            if (entidade.Nome.Length <= 3)
            {
                return false;
            }

            //Regra 02
            //Não pode possuir números
            for (int i = 0; i < entidade.Nome.Length; i++)
            {
                char caracter = entidade.Nome[i];

                //Método mais inteligente
                //if(Char.IsDigit(caracter))
                //{ return false;
                //}

                for (char j = '0'; j <= '9'; j++)
                {
                    if (caracter == j)
                    {
                        return false;
                    } 
                }
            }

            //Linq
            //entidade.Nome.Any(x => Char.IsDigit(x));

            return true;
        }

        public bool ValidarSexo(Pessoa entidade)
        {
            if (entidade.Sexo.ToUpper() != "F" && entidade.Sexo.ToUpper() != "M")
            {
                return false;
            }

            return true;
        }
    }
}
