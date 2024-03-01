class Matematica {
    public static Somar(i: number, j: number) : number {
        return i + j;
    }
}

console.log(Matematica.Somar(1, 2));

class PropriedadesPrivadas {
    private nome: string;

    get Nome(): string {
        return this.nome;
    }

    set Nome(nome: string) {
        this.nome = nome;
    }
}

let minhaClasseNova = new PropriedadesPrivadas();
minhaClasseNova.Nome = "Rúben";

