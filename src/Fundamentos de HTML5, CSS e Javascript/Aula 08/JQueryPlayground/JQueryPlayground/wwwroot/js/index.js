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


$("input").on("click", function () {
    alert(`Fui clicado : ${this}`);
});

$(".minhaClasse").on("click", function (e) {
    let $this = $(this);
    $this.removeClass("minhaClasse");
    $this.addClass("minhaClasseInvisivel");
});


        //Voltaremos 20:45