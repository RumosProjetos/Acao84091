using GestaoFrotas.ModeloDados.Entidades;

namespace GestaoFrotas.ConsoleApp.ModuloInicial
{
    public class TelaLogin
    {
        public TelaLogin()
        {
            //Perguntar quem Loga no Sistema
            Console.WriteLine("Informe Login:");
            string loginDigitado = Console.ReadLine();

            Console.WriteLine("Informe Senha:");
            string senhaDigitada = Console.ReadLine();
                        
            foreach(Usuario usuario in usuarios)
            {
                if(usuario.Login == loginDigitado && usuario.Senha == senhaDigitada)
                {
                    //Logar na Aplicacao
                }
            }            
        }
    }
}
