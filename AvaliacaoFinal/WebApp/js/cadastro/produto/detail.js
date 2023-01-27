var codigo = 0;

$(function(){
    avaliarAcao('produtoAcao');
    if (acao == 0){
        carregarDetalhe();
        somenteLeitura();
        $("#btnNovo").hide();
        $("#btnAlterar").hide();
        $("#btnExcluir").hide();
        $("#divInclusaoTexto").hide();
    }

    if (acao == 1){
        $("#txtCodigoProduto").attr('readonly',true);
        $("#btnAlterar").hide();
        $("#btnExcluir").hide();
        $("#divInclusaoData").hide();
        $("#chbAtivo").attr('checked', true);
        $("#chbAtivo").attr('disabled', true);
    }

    if (acao == 2){
        carregarDetalhe();
        $("#txtCodigoProduto").attr('readonly',true);
        $("#divInclusaoData").hide();
        $("#btnNovo").hide();
        $("#btnExcluir").hide();         
    }

    if (acao == 3){
       carregarDetalhe();
       somenteLeitura();
       $("#btnNovo").hide();
       $("#btnAlterar").hide();
    }
});

function somenteLeitura(){
    $("#txtCodigoProduto").attr('readonly',true);
    $("#txtCodigoCategoria").attr('readonly',true);
    $("#txtDescricao").attr('readonly',true);
    $("#datDataInclusao").attr('readonly', true);
    $("#chbAtivo").attr('disabled', true);
}

function carregarDetalhe(){
    var tmp = localStorage.getItem("codigoProdutoSelecionado");
    codigo = JSON.parse(tmp)

    if ((codigo == undefined) || (codigo == 0)){
        alert("código inválido!!");
        window.location.href = "list.html";
    }
    else{
        localStorage.removeItem("codigoProdutoSelecionado");
    }
    
    var caminhoComValor = caminho + '/' + codigo;

    $.get(caminhoComValor, function(data, status){
        if (data.length == 0){
            alert("Erro ao obter os dados.")
            return;
        }
        else{
            console.log(data);
            $("#txtCodigoProduto").val(data.codigoProduto);   
            $("#txtCodigoCategoria").val(data.codigoCategoria);
            $("#txtDescricao").val(data.descricao);                    
            $("#datDataInclusao").val(data.dataInclusao.substring(0,10));
            $("#chbAtivo").attr('checked', (stringToBoolean(data.ativo)));
        }
    });
}

function stringToBoolean(value){
    return (String(value) === '1' || String(value).toLowerCase() === 'true');
}