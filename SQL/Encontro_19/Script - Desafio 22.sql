--22 - Crie uma procedure que liste os funcionários que fazem aniversário em determinado ano.

--SCRIPT
--DECLARE @Ano INT
--SET @Ano = 1953

--DECLARE @Registro INT
--SELECT @Registro = COUNT(*) FROM Funcionario WHERE YEAR(DataNascimento) = @Ano

--IF (@Registro = 0)
--BEGIN
--	PRINT('Não existem funcionários que façam aniverário no ano informado !!.')
--END
--ELSE
--BEGIN
--	SELECT * FROM Funcionario 
--	WHERE YEAR(DataNascimento) = @Ano
--END
--GO

--CRIAÇÃO DA PROCEDURE
CREATE PROCEDURE SP_Desafio_022
@Ano INT 
AS
BEGIN
	DECLARE @Registro INT
	SELECT @Registro = COUNT(*) FROM Funcionario WHERE YEAR(DataNascimento) = @Ano

	IF (@Registro = 0)
	BEGIN
		PRINT('Não existem funcionários que façam aniverário no ano informado !!')
	END
	ELSE
	BEGIN
		SELECT * FROM Funcionario 
		WHERE YEAR(DataNascimento) = @Ano
	END
END
GO

--EXECUÇÃO DA PROCEDURE
EXEC SP_Desafio_022 1953
GO
