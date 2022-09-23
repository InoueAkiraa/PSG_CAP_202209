--Desafio 006 - Escreva um programa que leia um valor em metros e o exiba convertido em
--centímetros e milímetros.
CREATE PROCEDURE SP_Converter_Metros_Para_Centimetros_E_Milimetros
@Metro NUMERIC(10,2)
AS
BEGIN
	PRINT('Metros: ' +CONVERT(VARCHAR,@Metro) +' || ' +'Centímetros: ' +CONVERT(VARCHAR,(@Metro * 100)) +' || '
	+'Milímetros: ' +CONVERT(VARCHAR,(@Metro * 1000)))
END
GO

--EXECUÇÃO DA PROCEDURE
EXEC SP_Converter_Metros_Para_Centimetros_E_Milimetros 3
GO
