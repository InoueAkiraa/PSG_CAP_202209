var acao = 0;
function avaliarAcao(strAcao){
    var tmp = localStorage.getItem(strAcao);
    if (tmp != undefined){
        acao = JSON.parse(tmp);
        localStorage.removeItem(strAcao);
    }
    else{
        alert("Ação não foi informada, utilizando valor padrão [detalhar]");
    }
}