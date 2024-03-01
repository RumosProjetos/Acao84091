var Matematica = /** @class */ (function () {
    function Matematica() {
    }
    Matematica.Somar = function (i, j) {
        return i + j;
    };
    return Matematica;
}());
console.log(Matematica.Somar(1, 2));
var PropriedadesPrivadas = /** @class */ (function () {
    function PropriedadesPrivadas() {
    }
    Object.defineProperty(PropriedadesPrivadas.prototype, "Nome", {
        get: function () {
            return this.nome;
        },
        set: function (nome) {
            this.nome = nome;
        },
        enumerable: false,
        configurable: true
    });
    return PropriedadesPrivadas;
}());
var minhaClasseNova = new PropriedadesPrivadas();
minhaClasseNova.Nome = "Rúben";
//# sourceMappingURL=Main.js.map