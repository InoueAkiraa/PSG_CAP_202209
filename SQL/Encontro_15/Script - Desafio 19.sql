--Desafio 019 - Desenvolva um método que solicite a entrada de um número e calcule se o número
--é par ou ímpar.

--SCRIPT 
--DECLARE @Numero INT
--SET @Numero = 123

--IF(@Numero = 0)
--BEGIN
--	PRINT('O número informado é 0')
--END
--ELSE IF (@Numero % 2 = 0)
--BEGIN
--	PRINT('O número informado é par')
--END
--ELSE
--BEGIN
--	PRINT('O número informado é ímpar')
--END
--GO

--CRIAÇÃO DA PROCEDURE
CREATE PROCEDURE SP_Desafio_019
@Numero INT
AS
BEGIN
	IF(@Numero = 0)
	BEGIN
		PRINT('O número informado é 0')
	END
	ELSE IF (@Numero % 2 = 0)
	BEGIN
		PRINT('O número informado é par')
	END
	ELSE
	BEGIN
		PRINT('O número informado é ímpar')
	END
END
GO

--EXECUÇÃO DA PROCEDURE 
EXEC SP_Desafio_019 0
GO
