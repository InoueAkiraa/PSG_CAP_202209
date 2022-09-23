--Desafio 008 - Crie um programa que leia o quanto uma pessoa tem na carteira e mostre quantos
--dólares ela pode comprar.
--Considere US$ 1,00 = R$ 5,00
CREATE PROCEDURE SP_Converter_Real_Para_Dolar
@Reais NUMERIC(10,2)
AS
BEGIN
	DECLARE @Dolares NUMERIC(10,2)
	SET @Dolares = 5
	DECLARE @Conversao NUMERIC(10,2)
	SET @Conversao = (@Reais/@Dolares)
	
	PRINT('Cotação atual -> US$ 1,00 = R$ 5,00')
	PRINT('Você possui ' +'R$ '+CONVERT(VARCHAR,@Reais))
	PRINT('Você pode comprar ' +'US$ '+CONVERT(VARCHAR,@Conversao))
END
GO

--EXECUÇÃO DA PROCEDURE
EXEC SP_Converter_Real_Para_Dolar 14.50
GO
