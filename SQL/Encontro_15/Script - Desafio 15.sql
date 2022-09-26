--Desafio 015 – o mesmo professor quer agora, além de exibir, ordenar a lista. Faça um programa
--que ajude ele, lendo o nome deles e escrevendo todos os nomes armazenados, de forma
--ordenada.

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
--ORDER BY Nome
--GO

--CRIAÇÃO DA PROCEDURE
CREATE PROCEDURE SP_Desafio_015
AS
BEGIN
	DECLARE @Nomes TABLE(
	Nome VARCHAR(MAX) NOT NULL
)

	INSERT INTO @Nomes VALUES 
	('Akira'),
	('Adão'),
	('Thiago'),
	('João'),
	('José'),
	('Rafael'),
	('Bruno'),
	('Rafaela'),
	('Bruna')

	SELECT * FROM @Nomes
	ORDER BY Nome	
END
GO

--EXECUÇÃO DA PROCEDURE
EXEC dbo.SP_Desafio_015 
GO
