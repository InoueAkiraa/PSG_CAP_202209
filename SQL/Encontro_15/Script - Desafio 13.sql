--Desafio 013 – Escreva um programa que pergunte a quantidade de km percorridos por um carro
--alugado, e a quantidade de dias pelos quais ele foi alugado. Calcule o preço a pagar, sabendo
--que o carro custa R$ 60,00 por dia e R$ 0,15 por km rodado.

--SCRIPT
--DECLARE @KmRodado NUMERIC(10, 2)
--SET @KmRodado = 30.3
--DECLARE @DiasAlugado INT
--SET @DiasAlugado = 30
--DECLARE @CalculoDias NUMERIC(10, 2)
--SET @CalculoDias = (@DiasAlugado * 60)
--DECLARE @CalculoKm NUMERIC(10, 2)
--SET @CalculoKm = (@KmRodado * 0.15)

--PRINT('Preço referente ao aluguem do veículo: R$ ' + CONVERT(VARCHAR, @CalculoDias) 
--	  + CHAR(13) + CHAR(10) +
--	  'Preço referente aos quilômetros rodados: R$ ' +CONVERT(VARCHAR, @CalculoKm)
--	  + CHAR(13) + CHAR(10) +
--	  'Preço final: R$ ' + CONVERT(VARCHAR, (@CalculoDias + @CalculoKm)))
--GO

--CRIAÇÃO DA PROCEDURE
CREATE PROCEDURE SP_Desafio_013 
@DiasAlugado INT, @KmRodado NUMERIC(10, 2)
AS
BEGIN
	DECLARE @CalculoDias NUMERIC(10, 2)
	SET @CalculoDias = (@DiasAlugado * 60)
	DECLARE @CalculoKm NUMERIC(10, 2)
	SET @CalculoKm = (@KmRodado * 0.15)

	PRINT('Preço referente ao aluguem do veículo: R$ ' + CONVERT(VARCHAR, @CalculoDias) 
	  + CHAR(13) + CHAR(10) +
	  'Preço referente aos quilômetros rodados: R$ ' +CONVERT(VARCHAR, @CalculoKm)
	  + CHAR(13) + CHAR(10) +
	  'Preço final: R$ ' + CONVERT(VARCHAR, (@CalculoDias + @CalculoKm)))
END
GO

--EXECUÇÃO DA PROCEDURE
EXEC dbo.SP_Desafio_013 30, 30
GO
