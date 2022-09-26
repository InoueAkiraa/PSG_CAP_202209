--Desafio 016 – o mesmo professor quer sortear um dos seus alunos para apagar o quadro. Faça um
--programa que ajude ele, lendo o nome deles e escrevendo o nome do escolhido.

--SCRIPT
--DECLARE @Nomes TABLE(
--	Codigo INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
--	Nome VARCHAR(MAX) NOT NULL
--)

--INSERT INTO @Nomes VALUES 
--('Akira'),
--('João'),
--('Adão'),
--('José'),
--('Rafael'),
--('Bruno'),
--('Rafaela'),
--('Bruna'),
--('Thiago'),
--('Sabrina')

--DECLARE @Registros INT 
--SELECT @Registros = COUNT(*) FROM @Nomes

--DECLARE @Chave INT 
--SET @Chave = FLOOR(RAND() * (@Registros + 1))

--WHILE @Chave = 0 
--BEGIN
--	SET @Chave = FLOOR(RAND() * (@Registros + 1))
--END

--SELECT Nome FROM @Nomes
--WHERE Codigo = @Chave
--GO

--CRIAÇÃO DA PROCEDURE
CREATE PROCEDURE SP_Desafio_016
AS
BEGIN
	DECLARE @Nomes TABLE(
	Codigo INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	Nome VARCHAR(MAX) NOT NULL
)

	INSERT INTO @Nomes VALUES 
	('Akira'),
	('João'),
	('Adão'),
	('José'),
	('Rafael'),
	('Bruno'),
	('Rafaela'),
	('Bruna'),
	('Thiago'),
	('Sabrina')

	DECLARE @Registros INT 
	SELECT @Registros = COUNT(*) FROM @Nomes

	DECLARE @Chave INT 
	SET @Chave = FLOOR(RAND() * (@Registros + 1))

	WHILE @Chave = 0 
	BEGIN
		SET @Chave = FLOOR(RAND() * (@Registros + 1))
	END

	SELECT Nome FROM @Nomes
	WHERE Codigo = @Chave
	END
GO

--EXECUÇÃO DA PROCEDURE
EXEC dbo.SP_Desafio_016
GO
