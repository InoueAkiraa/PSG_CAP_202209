--Desafio 007 - Faça um programa que leia um número inteiro e mostre na sua tela a sua tabuada.
CREATE PROCEDURE SP_Realizar_Tabuada 
@Numero INT 
AS
BEGIN
	DECLARE @NumeroConstante INT
	SET @NumeroConstante = 0

	PRINT('TABUADA')
	WHILE (@NumeroConstante < 10)
	BEGIN
		SET @NumeroConstante = @NumeroConstante + 1
		PRINT(CONVERT(VARCHAR,@Numero) +' x ' +CONVERT(VARCHAR,@NumeroConstante) +' = ' +CONVERT(VARCHAR,(@Numero * @NumeroConstante)))
	END
END
GO

--EXECUÇÃO DA PROCEDURE
EXEC SP_Realizar_Tabuada 4
GO
