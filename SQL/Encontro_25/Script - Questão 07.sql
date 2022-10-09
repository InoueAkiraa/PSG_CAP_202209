--SCRIPT
--DECLARE @IdTipo INT
--SET @IdTipo = 16

--DECLARE @IdMunicipio INT
--SET @IdMunicipio = 1100015

--DECLARE @Ano INT
--SET @Ano = 2013

--SELECT Aquicultura.IdAquicultura, 
--	   Aquicultura.Ano, 
--	   Aquicultura.IdMunicipio, 
--	   tipo.IdTipoAquicultura,
--	   Tipo.DescricaoTipoAquicultura, 
--	   Aquicultura.Producao, 
--	   Aquicultura.ValorProducao, 
--	   Aquicultura.ProporcaoValorProducao,
--	   Aquicultura.Moeda

--FROM Aquicultura 
--INNER JOIN TipoAquicultura AS Tipo ON Aquicultura.IdTipoAquicultura = Tipo.IdTipoAquicultura
--WHERE tipo.IdTipoAquicultura = @IdTipo AND IdMunicipio = @IdMunicipio AND Ano = @Ano
--GO

--PROCEDURE 
CREATE PROCEDURE SP_Questao_07
@IdTipo INT, @IdMunicipio INT, @Ano INT
AS
BEGIN
	SELECT Aquicultura.IdAquicultura, 
	   Aquicultura.Ano, 
	   Aquicultura.IdMunicipio, 
	   Tipo.DescricaoTipoAquicultura, 
	   Aquicultura.Producao, 
	   Aquicultura.ValorProducao, 
	   Aquicultura.ProporcaoValorProducao,
	   Aquicultura.Moeda

	FROM Aquicultura 
	INNER JOIN TipoAquicultura AS Tipo ON Aquicultura.IdTipoAquicultura = Tipo.IdTipoAquicultura
	WHERE tipo.IdTipoAquicultura = @IdTipo AND IdMunicipio = @IdMunicipio AND Ano = @Ano
END
GO

--EXECUÇÃO
EXEC SP_Questao_07 16, 1100015, 2013
GO


