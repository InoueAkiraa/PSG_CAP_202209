--Desafio 001 - Crie um programa que leia o nome de uma pessoa e mostre uma mensagem de 
--boas-vindas de acordo com o valor digitado.
CREATE PROCEDURE SP_Informar_Boas_Vindas
@Nome VARCHAR(255)
AS
BEGIN
	PRINT('Lhe dou as boas-vindas ' +@Nome)
END
GO

--EXECUÇÃO DA PROCEDURE
EXEC SP_Informar_Boas_Vindas 'Akira'
GO
