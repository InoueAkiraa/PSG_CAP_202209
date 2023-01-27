function excluir(){
    var codigoProduto = $("#txtCodigoProduto").val();

    var caminhoComValor = caminho + '/' + codigo;

    $.ajax({
        url: caminhoComValor,
        type: "delete",
        dataType: "json",
        contentType: "application/json",
        data: null,
        success: function(data, status, xhr){
            console.log(data);
            codigoProduto = data.codigoProduto;
            alert("Dados excluídos com sucesso. [CodigoProduto = " + codigoProduto + "]");
            window.location.href = "list.html"
        },
        error: function(xhr, status, errorThrown){
            alert("Erro ao excluir os dados. " + status);
            return;
        }
    });
}