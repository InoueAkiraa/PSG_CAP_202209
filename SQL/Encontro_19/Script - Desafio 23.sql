--23 - Crie uma procedure que liste os funcionários de determinado sexo.

--SCRIPT
--DECLARE @Sexo CHAR(1) 
--SET @Sexo = 'F'

--DECLARE @Registro INT
--SELECT @Registro = COUNT(*) FROM Funcionario WHERE Sexo = @Sexo

--IF (@Registro = 0)
--BEGIN
--	PRINT('Favor informar um Gênero existente !')
--END
--ELSE
--BEGIN
--	SELECT * FROM Funcionario
--	WHERE Sexo = @Sexo
--END
--GO

--CRIAÇÃO DA PROCEDURE
CREATE PROCEDURE SP_Desafio_023
@Sexo CHAR(1)
AS
BEGIN
	DECLARE @Registro INT
	SELECT @Registro = COUNT(*) FROM Funcionario WHERE Sexo = @Sexo

	IF (@Registro = 0)
	BEGIN
		PRINT('Favor informar um Gênero existente !')
	END
	ELSE
	BEGIN
		SELECT * FROM Funcionario
		WHERE Sexo = @Sexo
	END

END
GO

--EXECUÇÃO DA PROCEDURE
EXEC SP_Desafio_023 'F'
GO
