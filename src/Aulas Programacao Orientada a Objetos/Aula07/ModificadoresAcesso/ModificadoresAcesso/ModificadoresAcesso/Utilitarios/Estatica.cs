namespace ModificadoresAcesso.Utilitarios
{
    internal static class Estatica
    {
        public static string MeuValor { get; set; }

        public static string ConverterParaMaiusculas()
        {
            return MeuValor.ToUpper();
        }
    }
}
