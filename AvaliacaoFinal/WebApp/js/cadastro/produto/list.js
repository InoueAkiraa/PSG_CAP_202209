var caminhoEnvelope = '';
$(function(){
  carregarCategoria()
  $("#ddlCategoria").change(function(){        
    var codigoCategoria = $(this).children("option:selected").val();
    var limite = $("#ddlTakeSkip").children("option:selected").val();
    var salto = 0;
    if (limite != 0){
      caminhoEnvelope = caminho + "/envelope/PorCategoria/" + codigoCategoria + "?limite=" + limite + "&salto=" + salto;
      carregar(caminhoEnvelope);
    }
    else{
      limite = 10;
      caminhoEnvelope = caminho + "/envelope/PorCategoria/" + codigoCategoria + "?limite=" + limite + "&salto=" + salto;
      carregar(caminhoEnvelope);
    }
});
  
  $("#ddlTakeSkip").change(function(){    
    var limite = $(this).children("option:selected").val();
    var codigoCategoria = $("#ddlCategoria").children("option:selected").val();
    var salto = 0;
    if (codigoCategoria != 0){      
      caminhoEnvelope = caminho + "/envelope/PorCategoria/" +codigoCategoria + "?limite=" + limite + "&salto=" + salto;
      carregar(caminhoEnvelope);
    }
    else{
      alert("Informe uma Categoria para realizar a pesquisa.")
    }
  });
});

function carregar(caminhoEnvelope){
  $.ajax({            
    url: caminhoEnvelope,
    type: "get",
    dataType: "json",
    contentType: "application/json",
    data: null,
    async: false,
    success: function(data, status, xhr){
    var codigoStatus = data.status.codigo;
    var mensagemStatus = data.status.mensagem;
            
    if (codigoStatus == 404){
      $("#liPagina").hide();
      $("#liPosterior").hide();          
      alert(mensagemStatus);
      return;
    }

    if (codigoStatus == 400){
      $("#liAnterior").hide();
      $("#liPagina").hide();
      $("#liPosterior").hide();          
      alert(mensagemStatus);
      return;
    }

    $("#tblDados tbody").empty();

    for (let index = 0; index < data.dados.length; index++) {
      const categoria = data.dados[index];

      console.log(categoria);      

      var codigoProduto = categoria.codigoProduto;
      var descricao = categoria.descricao;

      var hasPrev = data.paginacao.hasPrev;
      var hasNext = data.paginacao.hasNext;
      var pageNumber = data.paginacao.pageNumber;   

      var linha = '';
      linha += "<tr>";
      linha +=  "<td class='table-active text-center'>";
      linha +=    "<button id='btnExibir' class='border-light border-0' onclick='exibirAtual("+ codigoProduto +");'>";
      linha +=      "<img src='/img/icone.png''width=35 height=35'>";
      linha +=    "</button>";
      linha +=  "</td>";
      linha += "<td class='table-active text-center'>" + codigoProduto + "</td>";
      linha += "<td class='table-active text-center'>" + descricao + "</td>";
      linha += "<td class='table-active text-center'>";
      linha +=    "<button id='btnAlterar' class='btn-warning' onclick='alterarAtual("+ codigoProduto +");'>Alterar</button>";
      linha +=    "</td>";
      linha += "<td class='table-active text-center'>";
      linha +=    "<button id='btnExcluir' class='btn-danger' onclick='excluirAtual("+ codigoProduto +");'>Excluir</button>";
      linha +=    "</td>";
      linha += "</tr>"; 
      $("#tblDados tbody").append(linha);
    }      
      carregarLinkPaginacao(pageNumber, hasPrev, hasNext);
    },
    error: function(xhr, status, errorThrown){                       
      alert("Erro ao obter os dados. " + status);
      return;                        
    }
  });
}

function exibirAtual(codigo){
  localStorage.setItem("produtoAcao",JSON.stringify(0));
  localStorage.setItem("codigoProdutoSelecionado",JSON.stringify(codigo));
  window.location.href = "detail.html";
}

function cadastrarNovo(){
  localStorage.setItem("produtoAcao",JSON.stringify(1));
  window.location.href = "detail.html";
}


function alterarAtual(codigo){
  localStorage.setItem("produtoAcao",JSON.stringify(2));
  localStorage.setItem("codigoProdutoSelecionado",JSON.stringify(codigo));
  window.location.href = "detail.html";
}

function excluirAtual(codigo){
  localStorage.setItem("produtoAcao",JSON.stringify(3));
  localStorage.setItem("codigoProdutoSelecionado",JSON.stringify(codigo));
  window.location.href = "detail.html";
}

var produtos = [];
function carregarCategoria(){
  var caminhoCategoria  = servidor + "/" + "Categoria";
  $.get(caminhoCategoria, function(data){
    for (let index = 0; index < data.length; index++) {
      const categoria = data[index];

      $("#ddlCategoria").append(            
        $('<option></option>').val(categoria.codigoCategoria).html(categoria.descricao)
    );
    }     
  });
}

function carregarLinkPaginacao(numeroPagina, anterior, posterior){  
  $("#navPaginacao ul").empty();
  var linha = '';
  linha += "<li class='page-item'>";
  linha +=  "<a class='page-link' id='liAnterior' onclick='carregar(\""+ anterior +"\")' tabindex='-1'>Anterior</a>";
  linha += "</li>";
  linha += "<li class='page-item'>";
  linha +=  "<a class='page-link' id='liPagina'> "+ numeroPagina +"</a>";
  linha += "</li>";
  linha += "<li class='page-item'>";
  linha +=  "<a class='page-link' id='liPosterior' onclick='carregar(\""+ posterior +"\")'>Próximo</a>";
  linha += "</li>";
  $("#navPaginacao ul").html(linha);

  if(numeroPagina == 1){
    $("#liAnterior").hide();
  }
}