--Desafio 010 - Faça um programa que leia o preço de um produto, e mostre seu novo preço, com
--5% de desconto.
CREATE PROCEDURE SP_Gerar_Desconto
@Preco NUMERIC(10,2) 
AS
BEGIN
	DECLARE @Calculo NUMERIC(10,2)
	SET @Calculo = ((@Preco * 5)/100)
	PRINT('O preço do produto informado é R$ ' +CONVERT(VARCHAR,@Preco))
	PRINT('Preço com 5% de desconto -> ' +CONVERT(VARCHAR,(@Preco - @Calculo)))
END
GO

EXEC SP_Gerar_Desconto 1235
GO
