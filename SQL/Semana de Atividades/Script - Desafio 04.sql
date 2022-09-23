--Desafio 004 - Crie um programa que leia um número e mostre o seu dobro, seu triplo e sua raiz
--quadrada.
CREATE PROCEDURE SP_Calcular_Dobro_Triplo_Raiz
@Valor NUMERIC(10,2)
AS
BEGIN
	DECLARE @Raiz NUMERIC(10,2)
	SET @Raiz = (@Valor * @Valor)

	PRINT('O dobro de ' +CONVERT(VARCHAR,@Valor) +' é ' +CONVERT(VARCHAR,(@Valor * 2)))
	PRINT('O triplo de ' +CONVERT(VARCHAR,@Valor) +' é ' +CONVERT(VARCHAR,(@Valor * 3)))
	PRINT('A raíz quadrada de ' +CONVERT(VARCHAR,@Valor) +' é ' +CONVERT(VARCHAR,(@Raiz)))	
END
GO

--EXECUÇÃO DA PROCEDURE
EXEC SP_Calcular_Dobro_Triplo_Raiz 5
GO
