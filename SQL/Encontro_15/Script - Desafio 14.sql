--Desafio 014 – um professor quer armazenas o nome dos seus alunos para realizar algumas tarefas.
--Faça um programa que ajude ele, lendo o nome deles e escrevendo todos os nomes
--armazenados.

--SCRIPT
--DECLARE @Nomes TABLE(
--	Nome VARCHAR(MAX) NOT NULL
--)

--INSERT INTO @Nomes VALUES 
--('Akira'),
--('Adão'),
--('João'),
--('José'),
--('Rafael'),
--('Rafaela'),
--('Bruno'),
--('Bruna'),
--('Thiago')

--SELECT * FROM @Nomes
--GO

--CRIAÇÃO DA PROCEDURE
CREATE PROCEDURE SP_Desafio_014
AS
BEGIN
	DECLARE @Nomes TABLE(
	Nome VARCHAR(MAX) NOT NULL
)

	INSERT INTO @Nomes VALUES 
	('Akira'),
	('Adão'),
	('João'),
	('José'),
	('Rafael'),
	('Rafaela'),
	('Bruno'),
	('Bruna'),
	('Thiago')

	SELECT * FROM @Nomes

END
GO

--EXECUÇÃO DA PROCEDURE
EXEC dbo.SP_Desafio_014
GO
