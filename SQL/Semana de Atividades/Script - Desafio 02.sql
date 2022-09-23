--Desafio 002 – Crie um programa que leia o dia, o mês e ano de nascimento de uma pessoa e 
--mostre uma mensagem com a data formatada.
CREATE PROCEDURE SP_Informar_Data_Aniversario
@Dia INT, @Mes INT, @Ano INT
AS
BEGIN
	PRINT('Data de aniversário informada: ' +CONVERT(VARCHAR,@Dia) +'-' +CONVERT(VARCHAR,@Mes) +'-' +CONVERT(VARCHAR,@Ano))
END
GO

--EXECUÇÃO DA PROCEDURE
EXEC SP_Informar_Data_Aniversario 01, 04, 2001
GO
