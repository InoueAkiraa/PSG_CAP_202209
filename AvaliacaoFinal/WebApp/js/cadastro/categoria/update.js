function alterar(){
    var codigoCategoria = $("#txtCodigoCategoria").val();
    var descricao = $("#txtDescricao").val();    
    var ativo = $("#chbAtivo").prop('checked');
    var dataInclusao = $("#txtDataInclusao").val();    
    
    var novo = {
        codigoCategoria,
        descricao,        
        ativo,
        dataInclusao
    };

    console.log(novo);

    $.ajax({
        url: caminho,
        type: "put",
        dataType: "json",
        data: JSON.stringify(novo),
        contentType: "application/json",
        success: function(data, status, xhr){
            console.log(data);
            codigoCategoria = data.codigoCategoria;
            alert("Dados alterados com sucesso. [CodigoCategoria = " + codigoCategoria + "]");
            window.location.href = "list.html";
        },
        error: function(xhr, status, errorThrown){
            alert("Erro ao alterar os dados. " + status);
            return;
        }
    });

}