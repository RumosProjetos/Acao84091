function HelloWorld(mensagem) {
    var minhaMensagem = "O texto digitado foi: " + mensagem;

    var meuObjeto = document.getElementById("lblMensagem");
    meuObjeto.innerText = minhaMensagem;

    if (mensagem.length % 2 == 0) {
        meuObjeto.style.backgroundColor = "Lime";
    } else {
        meuObjeto.style.backgroundColor = "Cyan";
    }

    var meuValor = 3;
    switch (meuValor) {
        case 1:
            meuObjeto.style.borderColor = "Yellow";
            meuObjeto.style.borderWidth = "20px";
            meuObjeto.style.borderStyle = "solid";
            break;
        case 2:
            meuObjeto.style.borderColor = "Green";
            meuObjeto.style.borderWidth = "20px";
            meuObjeto.style.borderStyle = "solid";
            break;
        case 3:
            meuObjeto.style.borderColor = "Gray";
            meuObjeto.style.borderWidth = "20px";
            meuObjeto.style.borderStyle = "solid";
            break;
        default:
    }

    //for (var i = 0; i < 10; i++) {
    //    document.write(i);
    //}
}


function Exemplo02(numero, numero2, operacao) {

    if (operacao == "soma") {
        return Number(numero) + Number(numero2);
    }

    if (operacao == "subtracao") {
        return numero - numero2;
    }

    if (operacao == "multi") {
        return numero * numero2;
    }

    if (operacao == "expo") {
        return numero ** numero2;
    }

    if (operacao == "div") {
        if (numero2 != 0) {
            return numero / numero2;
        }
        return 0;
    }
}

function Calcular() {
    var operacao = document.getElementById('cbOperacao').value;
    var numero1 = document.getElementById('txtNumero1').value;
    var numero2 = document.getElementById('txtNumero2').value;

    var resultado = Exemplo02(numero1, numero2, operacao);

    console.log(resultado);
    console.debug(resultado);
    console.error(resultado);
    console.info(resultado);

    document.getElementById('txtResultado').innerText = resultado;
}


function MinhaFuncao() {
    let minhaVar = 1; //any

    const minhaConstante = 10;

    for (let i = 0; i < minhaConstante; i++) {
        let minhaVar = 3;
    }


    alert(minhaVar);
}

MinhaFuncao();


function ExemploException() {
    try {
        let numero01 = 2;
        let numero02 = 0;

        FuncaoNaoExiste();
    } catch (e) {
        console.error(e);
    }
}


function CompararValores(valor1, valor2) {

    /*
    "0" == 0 : true
    "0" === 0 : false

    "0" != 0 : false
    "0" !== 0 : true
    */

    if (valor1 === valor2) {
        //faça algo
    } else {
        //faça outra coisa
    }


    valor1 === valor2 ? "" : "";


    return valor1 === valor2;
}


function MeusTiposDeDados() {
    let meuNumero = 1;
    let meuDecimal = 1.5;

    let minhaString = "Meu texto";

    let minhaData = Date(12, 12, 2000);

    let meuBool = true;

    let pedro = {
        firstName: "Pedro",
        lastName: "Almeida",
        exemplo: "PropriedadeNova",
        exemplo02: "Propriedade Novíssima"
    };//JSON - Javascript Object Notation


    alert(pedro.lastName);
    alert(pedro.Exemplo02);


    let catarina = {
        firstName: "Catarina",
        lastName: "Neves"
    };//JSON - Javascript Object Notation

    alert(catarina.firstName);


    let meuArray = ["Exemplo", "Mais um exemplo", "Outro exemplo"];

    for (var i in meuArray) {
        console.log(i);
    }


    let meuArrayObjetos = [
        {
            "nome": "exemplo",
            sobrenome: "exemplo sobrenome",
            MeuObjeto:
                [{
                    minhaProp1: "Exemplo",
                    minhaData: Date(20, 1, 2000)
                },
                {
                    minhaProp1: "Exemplo",
                    minhaData: Date(20, 1, 2000)
                }]
        },
        {
            nome: "exemplo 02",
            sobrenome: "exemplo sobrenome 02"
        },
    ]

    console.log(meuArrayObjetos[0].nome);

    console.log(meuArrayObjetos[0].MeuObjeto[0].minhaData);



}


function MeuObjetoComMetodos() {

    let pessoa = {
        nome: "Joao",
        sobrenome: "Carmo",
        nomeCompleto: function () {
            return this.nome + this.sobrenome;
        }
    }

    alert(pessoa.nomeCompleto());
}


function PassarParaMaiusculo(objeto) {
    var conteudo = objeto.value;
    var conteudoConvertido = conteudo.toUpperCase();
    objeto.value = conteudoConvertido;
}

function PassarParaMinusculo(objeto) {
    var conteudo = objeto.value;
    var conteudoConvertido = conteudo.toLowerCase();
    objeto.value = conteudoConvertido;
}

function ValidarFormulario() {
    //Nome tem que ter no mínimo 3 letras
    //Nome não pode ser vazio

    let resultado = true;
    let nome = document.getElementById('txtNomeForm').value;

    if (nome.length < 3 || nome == "") {
        document.getElementById('txtNomeForm').focus();
        resultado = false;
    }

    //email tem que ter @
    let email = document.getElementById('txtEmailForm').value;

    if (email.indexOf("@") <= 0) {
        document.getElementById('txtEmailForm').focus();
        resultado = false;
    }

    if (resultado == false) {
        document.getElementById('divErros').style.display = "solid";
    } else {
        document.getElementById('divErros').style.display = "hidden";
    }
}



document.getElementById('MeuBotaoSemEvento').onclick = "ValidarFormulario()";