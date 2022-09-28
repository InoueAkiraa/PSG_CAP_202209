--Desafio 020 - Desenvolva um método que permita a entrada do nome do usuário e exiba
--- Imprima a frase “Olá meu nome é: {nome recebido}”.
--- O nome com todas as letras maiúsculas e minúsculas.
--- Quantas letras ao todo (sem considerar espaços).
--- Quantas letras tem o primeiro nome.

--SCRIPT
--DECLARE @Nome VARCHAR(MAX)
--SET @Nome = 'Renato Akira Inoue Junior'

--PRINT('Olá meu nome é: ' +@Nome)
--PRINT('Olá meu nome é: ' + UPPER(@Nome) 
--	  + CHAR(13) + CHAR(10) +
--	  + 'Olá meu nome é: ' + LOWER(@Nome))
--PRINT('Tamanho do nome: ' + CONVERT(VARCHAR,(LEN(REPLACE(@Nome,' ','')))) + ' (sem considerar espaços)')
--PRINT('O primeiro nome possui ' + CONVERT(VARCHAR, (LEN(SUBSTRING(@Nome, 1, CHARINDEX(' ', @Nome))))) + ' letras.')
--GO

--CRIAÇÃO DA PROCEDURE
CREATE PROCEDURE SP_Desafio_020
@Nome VARCHAR(MAX)
AS
BEGIN
	PRINT('Olá meu nome é: ' +@Nome)

	PRINT('Olá meu nome é: ' + UPPER(@Nome) 
		  + CHAR(13) + CHAR(10) +
		  + 'Olá meu nome é: ' + LOWER(@Nome))

	PRINT('Tamanho do nome: ' + CONVERT(VARCHAR,(LEN(REPLACE(@Nome,' ','')))) + ' (sem considerar espaços)')

	PRINT('O primeiro nome possui ' + CONVERT(VARCHAR, (LEN(SUBSTRING(@Nome, 1, CHARINDEX(' ', @Nome))))) + ' letras.')
END
GO

--EXECUÇÃO DA PROCEDURE
EXEC SP_Desafio_020 'Nilva de Oliveira Neves Inoue'
GO
