$("#btnOk").on("click", function () {
    //alert('Oi mundo');
    //let minhaVar = document.getElementById("#txtMensagem").value;

    let minhaVariavel = $("#txtMensagem").val();
    let minhaDataEscolhida = $("#datepicker").val();

    $("#lblMensagem").html(`<h1> ${minhaVariavel}:</h1> <br /> <h2> ${minhaDataEscolhida} </h2>`);
});
/*
$("") => seletor
on("", callback) => atribuicao de funcao
*/

$(function () {
    $("#datepicker").datepicker();
});

$(function () {
    $("#dialog").dialog();
})

$("#btnAplicarEstilo").on("click", function () {
    if ($("#lblMensagem").hasClass("formatoMensagem")) {

        $("#lblMensagem").removeClass("formatoMensagem");
        $("#lblMensagem").addClass("formatoMensagemDois");

    } else {

        $("#lblMensagem").removeClass("formatoMensagemDois");
        $("#lblMensagem").addClass("formatoMensagem");

    }
});


//$("input").on("click", function () {
//    alert(`Fui clicado : ${this}`);
//});

$(".minhaClasse").on("click", function (e) {
    let $this = $(this);
    $this.removeClass("minhaClasse");
    $this.addClass("minhaClasseInvisivel");
});

//search?q=exemplo
$("#btnAjax").on("click", function () {
    $.ajax({
        url: "/content.json",
        method: 'GET',
        success: function (dadosContent) {
            var nome = dadosContent.nome;
            var idade = dadosContent.idade;

            $("#ConteudoGoogle").html(`<h1> O nome é: ${nome} <br/>
             A idade é: ${idade} </h1>`);
        },
        error: function () {
            alert('Ops');
        }
    });
});


$("#btnBuscarApi2").on("click", function () {
    $.ajax({
        url: "https://localhost:7242/WeatherForecast",
        crossDomain: true,        
        dataType: 'jsonp',
        method: "GET",
        success: function (resultado) {
            alert(resultado);
            let primeiraMedicao = resultado[0];

            $("#txtResultadoJSON").val(`Primeira Medicao: ${primeiraMedicao.TemperatureC}`);
        },
        error: function (errormessage) {
            alert(errormessage);
        }
    });
});


$("#btnBuscarApi").on("click", function () {
    $.get("/content.json", function (data) {
        alert(`A idade da ${data.nome} é ${data.idade}`);
    });
});



$("#btnCriarApi").on("click", function () {
    let meusDados = { "nome" : "Joao", idade:23, ativo : true };
    $.post("/content.json", meusDados, function (data) {
        alert(`A idade da ${data.nome} é ${data.idade}`);
    });
});


$("#btnCriarApi2").on("click", function () {
    $.ajax({
        url: "https://localhost:7242/WeatherForecast",
        crossDomain: true,
        dataType: 'jsonp',
        method: "POST",
        data: {
            "parametro1": "Meu Parametro",
            "parametro2": "Meu Parametro2",
        },
        success: function (resultado) {
            alert(resultado);
            let primeiraMedicao = resultado[0];

            $("#txtResultadoJSON").val(`Primeira Medicao: ${primeiraMedicao.TemperatureC}`);
        },
        error: function (errormessage) {
            alert(errormessage);
        }
    });
});



$("#txtResultadoJSON").load("/content.json");
