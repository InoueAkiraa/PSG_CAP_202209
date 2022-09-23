--Desafio 003 – Crie um programa que leia dois números e tente mostrar a soma entre eles.
CREATE PROCEDURE SP_Somar_Dois_Valores
@Valor1 NUMERIC(10,2), @Valor2 NUMERIC(10,2)
AS
BEGIN
	PRINT('A soma dos dois valores informados é: ' +CONVERT(VARCHAR,(@Valor1 + @Valor2)))	
END
GO

--EXECUÇÃO DA PROCEDURE
EXEC SP_Somar_Dois_Valores 3.5, 4
GO
