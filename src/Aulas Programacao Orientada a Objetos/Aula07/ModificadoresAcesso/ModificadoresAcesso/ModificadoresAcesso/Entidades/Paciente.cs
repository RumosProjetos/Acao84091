namespace ModificadoresAcesso.Entidades
{
    sealed internal class Paciente : Pessoa
    {
        public Paciente(string nome) : base(nome)
        {
            Nome = nome;
            MeuMetodoProtegido();
        }

    }
}
