enum Profissao {
    Professor,
    Medico,
    Engenheiro
}


class Pessoa {
    public Nome?: string;
    public Sobrenome: string;
    public DataNascimento: Date;
    public Profissao: Profissao | string;
    private nomeCompleto: string;
    protected readonly minhaPropriedadeHerdavel: string;

    public constructor(propriedade: string) {
        this.minhaPropriedadeHerdavel = propriedade;
    }

    ObterNomeCompleto(): string {
        this.nomeCompleto = this.Nome + " " + this.Sobrenome + " " + this.minhaPropriedadeHerdavel;
        return this.nomeCompleto;
    }

    ObterDataNascimento(): number {
        return new Date().getFullYear() - this.DataNascimento.getFullYear();
    }

    ValidarProfissao(param: string | Profissao): boolean {
        let profissao: string;

        if (typeof (param) === typeof (Profissao)) { //Valida se é um enum
            switch (param) {
                case Profissao.Engenheiro:  //Troca para string
                    profissao = "Engenheiro";
                    break;
                case Profissao.Medico:
                    profissao = "Médico";
                    break;
                case Profissao.Professor:
                    profissao = "Professor";
                    break;
            }
        } else {
            profissao = (param as string) //faz o casting para outro tipo de dados
        }

        if (profissao.length <= 0) {
            return false;
        }

        return true;
    }

}

let joao: Pessoa;
joao.Nome = "João";
joao.DataNascimento = new Date(1984, 1, 1);
joao.Sobrenome = "Carmo";
joao.Profissao = Profissao.Engenheiro;

console.log(joao.ObterNomeCompleto());


let pedro = new Pessoa("Exemplo");
pedro.Nome = "Pedro";
pedro.Sobrenome = "Álvares Cabral";
pedro.ObterNomeCompleto();

