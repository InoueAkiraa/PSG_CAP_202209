function cadastrar(){
    var codigoCategoria = 0;
    var descricao = $("#txtDescricao").val();    
    var ativo = null;
    var dataInclusao = null;    

    var novo = {
        codigoCategoria,
        descricao,    
        ativo,
        dataInclusao
    };

    console.log(novo);

    $.ajax({
        url: caminho,
        type: "post",
        dataType: "json",
        data: JSON.stringify(novo),
        contentType: "application/json",
        success: function(data, status, xhr){
            console.log(data);
            codigoProjeto = data.codigoProjeto;
            alert("Dados gravados com sucesso. [CodigoCategoria = " + codigoCategoria + "]");
            window.location.href = "list.html";
        },
        error: function(xhr, status, errorThrown){
            alert("Erro ao gravar os dados. " + status);
            return;
        }
    });
}