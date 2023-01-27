function cadastrar(){
    var codigoProduto = 0;
    var descricao = $("#txtDescricao").val();
    var codigoCategoria = $("#txtCodigoCategoria").val();   
    var ativo = null;
    var dataInclusao = null;    
    
    var novo = {
        codigoProduto,
        descricao,
        codigoCategoria,
        ativo,
        dataInclusao
    };

    $.ajax({
        url: caminho,
        type: "post",
        dataType: "json",
        contentType: "application/json",
        data: JSON.stringify(novo),
        success: function(data, status, xhr){
            console.log(data);
            codigoProduto = data.codigoProduto;
            alert("Dados gravados com sucesso. [CodigoProduto = " + codigoProduto + "]");
            window.location.href = "list.html";
        },
        error: function(xhr, status, errorThrown){
            alert("Erro ao gravar os dados. " + status);
            return;
        }
    });
}


