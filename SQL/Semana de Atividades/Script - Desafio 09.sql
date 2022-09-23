--Desafio 009 - Faça um programa que leia a largura e a altura de uma parede em metros, e calcule
--a sua área e a quantidade de tinta necessária para pintá-la, sabendo que cada litro de tinta pinta
--uma área de 2 metros quadrados.
CREATE PROCEDURE SP_Calcular_Area_Quadrada
@Largura NUMERIC(10,2), @Altura NUMERIC(10,2)
AS
BEGIN
	DECLARE @Calculo NUMERIC(10,2)
	SET @Calculo = (@Largura * @Altura)
	DECLARE @Tinta NUMERIC(10,2)
	SET @Tinta = 2
	SET @Tinta = (@Calculo/@Tinta)

	PRINT('A área calculada foi de ' +CONVERT(VARCHAR,@Calculo) +' metros quadrados')
	PRINT('Serão necessários ' +CONVERT(VARCHAR,@Tinta) +' litros de tinta para pintá-la')
END
GO

--EXECUÇÃO DA PROCEDURE
EXEC SP_Calcular_Area_Quadrada 6,10
GO
