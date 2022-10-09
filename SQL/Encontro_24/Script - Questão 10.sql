--SCRIPT
--DECLARE @IdTipo INT
--SET @IdTipo = 20

--DECLARE @IdMunicipio INT
--SET @IdMunicipio = 1100031

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
--WHERE tipo.IdTipoAquicultura = @IdTipo AND IdMunicipio = @IdMunicipio AND Ano = @Ano AND 
--Aquicultura.Producao IS NOT NULL AND Aquicultura.ValorProducao IS NOT NULL
GO

--PROCEDURE 
CREATE PROCEDURE SP_Questao_010
@IdTipo INT, @IdMunicipio INT, @Ano INT
AS
BEGIN
	SELECT Aquicultura.IdAquicultura, 
	   Aquicultura.Ano, 
	   Aquicultura.IdMunicipio, 
	   tipo.IdTipoAquicultura,
	   Tipo.DescricaoTipoAquicultura, 
	   Aquicultura.Producao, 
	   Aquicultura.ValorProducao, 
	   Aquicultura.ProporcaoValorProducao,
	   Aquicultura.Moeda

	FROM Aquicultura 
	INNER JOIN TipoAquicultura AS Tipo ON Aquicultura.IdTipoAquicultura = Tipo.IdTipoAquicultura
	WHERE tipo.IdTipoAquicultura = @IdTipo AND IdMunicipio = @IdMunicipio AND Ano = @Ano AND 
	Aquicultura.Producao IS NOT NULL AND Aquicultura.ValorProducao IS NOT NULL
END
GO

--EXECUÇÃO
EXEC SP_Questao_010 20, 1100031, 2013
GO