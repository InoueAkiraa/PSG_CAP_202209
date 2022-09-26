--Desafio 011 – Faça um programa que leia o salário de um funcionário, e mostre seu novo salário,
--com 15% de aumento.

--SCRIPT
--DECLARE @Salario NUMERIC(10, 2)
--DECLARE @Aumento NUMERIC(10, 2)
--SET @Salario = 1200
--SET @Aumento = ((@Salario * 15) / 100)
--SET @Salario = (@Salario + @Aumento)
--PRINT('Seu salário com aumento de 15% fica R$ ' + CONVERT(VARCHAR, @Salario))
--GO

--CRIAÇÃO DA PROCEDURE
CREATE PROCEDURE SP_Desafio_011
@Salario NUMERIC(10, 2)
AS
BEGIN
	DECLARE @Aumento NUMERIC(10, 2)
	SET @Aumento = ((@Salario * 15) / 100)
	DECLARE @SalarioFinal NUMERIC(10, 2)
	SET @SalarioFinal = (@Salario + @Aumento) 

	PRINT('Seu salário com aumento de 15% fica R$ ' + CONVERT(VARCHAR, @SalarioFinal))
END
GO

--EXECUÇÃO DA PROCEDURE
EXEC dbo.SP_Desafio_011 1200
GO
