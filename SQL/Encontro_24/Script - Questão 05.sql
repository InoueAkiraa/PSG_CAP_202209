CREATE VIEW VW_Dados_Aquicultura
AS
SELECT	Aquicultura.IdAquicultura, 
		Aquicultura.Ano, 
		Aquicultura.IdMunicipio, 
		Tipo.DescricaoTipoAquicultura, 
		Aquicultura.Producao, 
		Aquicultura.ValorProducao, 
		Aquicultura.ProporcaoValorProducao, 
		Aquicultura.Moeda

FROM Aquicultura 
INNER JOIN TipoAquicultura AS Tipo ON Aquicultura.IdTipoAquicultura = Tipo.IdTipoAquicultura
GO