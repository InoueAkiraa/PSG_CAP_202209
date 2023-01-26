var codigo = 0;

$(function(){
    avaliarAcao('categoriaAcao');
    if (acao == 0){
        carregarDetalhe();
        somenteLeitura();    
        $("#btnNovo").hide();  
        $("#btnAlterar").hide();
        $("#btnExcluir").hide();  
        $("#chbAtivo").attr('disabled', true);
    }
    
    if (acao == 1){
        $("#txtCodigoCategoria").attr('readonly', true);      
        $("#btnAlterar").hide();
        $("#btnExcluir").hide();
        $("#divInclusao").hide();
        $("#chbAtivo").attr('checked', true);
        $("#chbAtivo").attr('disabled', true);
    }
    
    if (acao == 2){
        carregarDetalhe();
        $("#txtCodigoCategoria").attr('readonly', true);
        $("#txtDataInclusao").attr('readonly', true); 
        $("#lblAtivo").hide();
        $("#txtAtivo").hide();
        $("#btnNovo").hide(); 
        $("#btnExcluir").hide();  
    }

    if (acao == 3){
        carregarDetalhe();
        somenteLeitura();
        $("#btnNovo").hide();  
        $("#btnAlterar").hide();
        $("#chbAtivo").attr('disabled', true);
    }
});

function somenteLeitura(){
    $("#txtCodigoCategoria").attr('readonly', true);
    $("#txtDescricao").attr('readonly', true);
    $("#txtAtivo").attr('readonly', true);
    $("#txtDataInclusao").attr('readonly', true);
}

function carregarDetalhe(){
    var tmp = localStorage.getItem("codigoCategoriaSelecionado");
    codigo = JSON.parse(tmp)

    if ((codigo == undefined) || (codigo == 0)){
        alert("código inválido!!");
        window.location.href = "list.html";
    }
    else{
        localStorage.removeItem("codigoCategoriaSelecionado");
    }
    
    var caminhoComValor = caminho + '/' + codigo;
    
    $.get(caminhoComValor, function(data, status){
        if (data.length == 0){
            alert("Erro ao obter os dados.")
            return;
        }
        else{
            console.log(data);
            $("#txtCodigoCategoria").val(data.codigoCategoria);
            $("#txtDescricao").val(data.descricao)        
            $("#txtAtivo").val(data.ativo);
            $("#txtDataInclusao").val(data.dataInclusao.substring(0,10));                        
            $("#chbAtivo").attr('checked', (stringToBoolean(data.ativo)));
        }
    });
}

function stringToBoolean(value){
    return (String(value) === '1' || String(value).toLowerCase() === 'true');
}