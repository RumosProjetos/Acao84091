namespace IntroducaoAsClasses
{
    /// <summary>
    /// Essa classe serve para alimentar a memória
    /// com objetos do tipo pessoa...
    /// </summary>
    internal class Pessoa
    {
        public Pessoa()
        {

        }

        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public Pessoa(string nome, DateTime dataNascimento)
        {
            Nome = nome;
            DataNascimento = dataNascimento; 
        }

        public string? Nome { get; set; }

        private string? nomeCompleto;

        public string? NomeCompleto
        {
            get {
                return nomeCompleto.ToUpper(); 
            }
            set { nomeCompleto = value; }
        }


        private DateTime dataNascimento;
        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }
        public string? NumeroContribuinte { get; set; }        
        public DateTime DataCriacao => DateTime.Now;
        public bool EstaAtivo { get; }

        public Endereco? Endereco { get; set; }


        /// <summary>
        /// Valida a pessoa com base no algoritmo complicado xyz
        /// </summary>
        /// <returns></returns>
        public bool ValidarPessoa()
        {
            bool resultado = false;

            if(NumeroContribuinte != null)
            {
                resultado = true;
            }

            var MinhaVar = 0;
            var minhaVar = 0;
            var minhavar = 0;

            return resultado;
        }

        public string ListarPropriedades()
        {
            string resultado = "Nome:" + Nome;
            resultado = resultado + " Contribuinte:" + NumeroContribuinte;
            resultado = resultado + " Data de Nascimento:" + dataNascimento;

            return resultado;
        }

        //public void Imprimir(string dados)
        //{
        //    Console.WriteLine("Impresso a partir do objeto");
        //}

        public void Imprimir(string dados, int idade = 0)
        {
            Console.WriteLine("Dados: " + dados + " Idade: " + idade);
        }




        public static void ImprimirClasse()
        {
            Console.WriteLine("Impresso a partir da classe");
        }
    }
}