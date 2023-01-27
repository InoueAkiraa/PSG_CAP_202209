function excluir(){
    var codigoCategoria = $("#txtCodigoCategoria").val();   
    var caminhoDelete = caminho + '/' + codigo;

    $.ajax({        
        url: caminhoDelete,
        type: "delete",
        dataType: "json",
        data: null,
        contentType: "application/json",
        success: function(data, status, xhr){
            console.log(data);
            codigoCategoria = data.codigoCategoria;
            alert("Dados excluídos com sucesso. [CodigoCategoria = " + codigoCategoria + "]");
            window.location.href = "list.html";
        },
        error: function(xhr, status, errorThrown){
            alert("Erro ao excluir os dados. " + status);
            return;
        }
    });

}