--Desafio 012 – escreva um programa que converta uma temperatura digitada em graus celsius
--para fahrenheit.

--SCRIPT
--DECLARE @Celsius NUMERIC(10, 2)
--SET @Celsius = 32.5
--DECLARE @Fahrenheit NUMERIC(10, 2)
--SET @Fahrenheit = ((@Celsius * 1.8) + 32)

--PRINT('Temperatura em Graus Celsius apresentada é ' +CONVERT(VARCHAR, @Celsius) + '°C' 
--	  + CHAR(13) + CHAR(10) +
--	  'Convertida em Graus Fahrenheit fica ' +CONVERT(VARCHAR, @Fahrenheit) + '°F')
--GO

--CRIAÇÃO DA PROCEDURE
CREATE PROCEDURE SP_Desafio_012
@Celsius NUMERIC(10, 2)
AS
BEGIN
	DECLARE @Fahrenheit NUMERIC(10, 2)
	SET @Fahrenheit = ((@Celsius * 1.8) + 32)

	PRINT('Temperatura em Graus Celsius apresentada é ' +CONVERT(VARCHAR, @Celsius) + '°C' 
	  + CHAR(13) + CHAR(10) +
	  'Convertida em Graus Fahrenheit fica ' +CONVERT(VARCHAR, @Fahrenheit) + '°F')
END
GO

--EXECUÇÃO DA PROCEDURE
EXEC dbo.SP_Desafio_012 32.5
GO
