--SCRIPT 
--DECLARE @IdMunicipio INT
--SET @IdMunicipio = 1100031

--DECLARE @Ano INT
--SET @Ano = 2013

--SELECT * FROM VW_Dados_Aquicultura
--WHERE IdMunicipio = @IdMunicipio AND Ano = @Ano AND Producao IS NOT NULL
--GO

--PROCEDURE 
CREATE PROCEDURE SP_Questao_08
@IdMunicipio INT, @Ano INT
AS
BEGIN
	SELECT * FROM VW_Dados_Aquicultura
	WHERE IdMunicipio = @IdMunicipio AND Ano = @Ano AND Producao IS NOT NULL
END
GO

--EXECUÇÃO
EXEC SP_Questao_08 1100031, 2013
GO