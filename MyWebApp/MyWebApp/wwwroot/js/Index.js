//JQUERY

$(document).ready(function () {
    var $button = $("#meu-button");
    $button.on("click", () => alert("Alerta"));

    var $precos = $(".preco-produto li");
    $precos.on("click", function () {
        alert($(this).text());
    });

    var $login = $("#login");
    var $popupForm = $(".popup-form");

    $login.on('click', function () {
        $popupForm.toggle(500);
    });
});

//JAVA SCRIPT

//var meuForm = document.getElementById("meu-form");
//meuForm.hidden = true;

//var meuButton = document.getElementById("meu-button");
//meuButton.addEventListener('click', exibirMesnagem);

//function exibirMesnagem() {
//    alert('Teste Evento');
//}