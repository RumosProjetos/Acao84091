interface Repository<U, T> {
    ObterPorId(id: U);
    ObterPorNome(nome: T);

    CriarNovo(nome: T, id: U);
    Apagar(id: U);
    Atualizar(nome: T, id: U);
}


class PessoaRepositorio implements Repository<number, string> {
    ObterPorId(id: number) {
        throw new Error("Method not implemented.");
    }
    ObterPorNome(nome: string) {
        throw new Error("Method not implemented.");
    }
    CriarNovo(nome: string, id: number) {
        throw new Error("Method not implemented.");
    }
    Apagar(id: number) {
        throw new Error("Method not implemented.");
    }
    Atualizar(nome: string, id: number) {
        throw new Error("Method not implemented.");
    }
}