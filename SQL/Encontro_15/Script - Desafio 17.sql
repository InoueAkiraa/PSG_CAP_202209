--Desafio 017 – o mesmo professor quer sortear a ordem de apresentação de trabalhos dos alunos.
--Faça um programa que leia o nome dos quatro alunos e a ordem sorteada.

--SCRIPT
--DECLARE @Nomes TABLE(
--	Codigo INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
--	Nome VARCHAR(MAX) NOT NULL
--)

--INSERT INTO @Nomes VALUES 
--('Akira'),
--('João'),
--('Paulo'),
--('Diogo')


--DECLARE @Loop INT
--SET @Loop = 0

--WHILE (@Loop < 4)
--BEGIN
--	SET @Loop = @Loop + 1

--	DECLARE @Registros INT
--	SELECT @Registros = COUNT(*) FROM @Nomes
	
--	DECLARE @ChaveAtual INT 
--	SET @ChaveAtual = FLOOR(RAND() * (@Registros + 1))

--	WHILE (@ChaveAtual = 0)
--	BEGIN
--		SET @ChaveAtual = FLOOR(RAND() * (@Registros + 1))
--	END

--	SELECT Nome FROM @Nomes
--	WHERE Codigo = @ChaveAtual
--END
--GO

--CRIAÇÃO DA PROCEDURE
CREATE PROCEDURE SP_Desafio_017
AS
BEGIN
	DECLARE @Nomes TABLE(
	Codigo INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	Nome VARCHAR(MAX) NOT NULL
	)

	INSERT INTO @Nomes VALUES 
	('Akira'),
	('João'),
	('Paulo'),
	('Diogo')

	DECLARE @Loop INT
	SET @Loop = 0

	WHILE (@Loop < 4)
	BEGIN
		SET @Loop = @Loop + 1

		DECLARE @Registros INT
		SELECT @Registros = COUNT(*) FROM @Nomes
	
		DECLARE @ChaveAtual INT 
		SET @ChaveAtual = FLOOR(RAND() * (@Registros + 1))

		WHILE (@ChaveAtual = 0)
		BEGIN
			SET @ChaveAtual = FLOOR(RAND() * (@Registros + 1))
		END

		SELECT Nome FROM @Nomes
		WHERE Codigo = @ChaveAtual
	END
END
GO

--EXECUÇÃO DA PROCEDURE
EXEC SP_Desafio_017
GO
