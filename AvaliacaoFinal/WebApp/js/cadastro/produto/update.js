function alterar(){
    var codigoProduto = $("#txtCodigoProduto").val();
    var descricao = $("#txtDescricao").val();
    var codigoCategoria = $("#txtCodigoCategoria").val();   
    var dataInclusao = $("#datDataInclusao").val(); 
    var ativo = $("#chbAtivo").prop('checked');
    
    var novo = {
        codigoProduto,
        descricao,
        codigoCategoria,   
        dataInclusao,     
        ativo
    };

    $.ajax({
        url: caminho,
        type: "put",
        dataType: "json",
        contentType: "application/json",
        data: JSON.stringify(novo),
        success: function(data, status, xhr){
            console.log(data);
            codigoProduto = data.codigoProduto;
            alert("Dados alterados com sucesso. [CodigoProduto = " + codigoProduto + "]");
            window.location.href = "list.html"
        },
        error: function(xhr, status, errorThrown){
            alert("Erro ao altera os dados. " + status);
            return;
        }
    });
}

