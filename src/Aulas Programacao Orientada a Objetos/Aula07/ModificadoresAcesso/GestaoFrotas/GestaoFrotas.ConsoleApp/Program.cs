using GestaoFrotas.ConsoleApp.Constantes;
using GestaoFrotas.ConsoleApp.ModuloInicial;

TelaBoasVindas telaBoasVindas = new TelaBoasVindas();

string teclaPressionada = Console.ReadLine().ToUpper();
if (teclaPressionada == Sistema.TeclaTelaLogin)
{
    TelaLogin telaLogin = new TelaLogin();
}
