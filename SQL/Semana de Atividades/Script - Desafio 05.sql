--Desafio 005 - Desenvolva um programa que leia as duas notas de um aluno, calcule e mostre a
--sua média.
CREATE PROCEDURE SP_Calcular_Nota_Media 
@Nota1 NUMERIC(10,2), @Nota2 NUMERIC(10,2)
AS
BEGIN
	DECLARE @Media NUMERIC(10,2)
	SET @Media = (@Nota1 + @Nota2)
	SET @Media = (@Media/2)

	PRINT('A média das duas notas é ' +CONVERT(VARCHAR,@Media))
END
GO

--EXECUÇÃO DA PROCEDURE
EXEC SP_Calcular_Nota_Media 10, 2
GO
