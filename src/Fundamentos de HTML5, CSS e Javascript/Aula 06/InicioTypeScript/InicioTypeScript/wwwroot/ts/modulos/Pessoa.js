var Profissao;
(function (Profissao) {
    Profissao[Profissao["Professor"] = 0] = "Professor";
    Profissao[Profissao["Medico"] = 1] = "Medico";
    Profissao[Profissao["Engenheiro"] = 2] = "Engenheiro";
})(Profissao || (Profissao = {}));
var Pessoa = /** @class */ (function () {
    function Pessoa(propriedade) {
        this.minhaPropriedadeHerdavel = propriedade;
    }
    Pessoa.prototype.ObterNomeCompleto = function () {
        this.nomeCompleto = this.Nome + " " + this.Sobrenome + " " + this.minhaPropriedadeHerdavel;
        return this.nomeCompleto;
    };
    Pessoa.prototype.ObterDataNascimento = function () {
        return new Date().getFullYear() - this.DataNascimento.getFullYear();
    };
    Pessoa.prototype.ValidarProfissao = function (param) {
        var profissao;
        if (typeof (param) === typeof (Profissao)) { //Valida se é um enum
            switch (param) {
                case Profissao.Engenheiro: //Troca para string
                    profissao = "Engenheiro";
                    break;
                case Profissao.Medico:
                    profissao = "Médico";
                    break;
                case Profissao.Professor:
                    profissao = "Professor";
                    break;
            }
        }
        else {
            profissao = param; //faz o casting para outro tipo de dados
        }
        if (profissao.length <= 0) {
            return false;
        }
        return true;
    };
    return Pessoa;
}());
var joao;
joao.Nome = "João";
joao.DataNascimento = new Date(1984, 1, 1);
joao.Sobrenome = "Carmo";
joao.Profissao = Profissao.Engenheiro;
console.log(joao.ObterNomeCompleto());
var pedro = new Pessoa("Exemplo");
pedro.Nome = "Pedro";
pedro.Sobrenome = "Álvares Cabral";
pedro.ObterNomeCompleto();
//# sourceMappingURL=Pessoa.js.map