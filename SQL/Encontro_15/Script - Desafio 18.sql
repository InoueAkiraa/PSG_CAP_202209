--Desafio 018 – agora, o professor deseja sortear da lista embaralha quem será o primeiro apresentar
--o trabalho. Faça um programa que leia o nome dos alunos, embaralhe a ordem de apresentação
--e sorteie um destes alunos para apresentar primeiro.

--SCRIPT
--DECLARE @Nomes TABLE(
--	Codigo INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
--	Nome VARCHAR(MAX) NOT NULL
--)

--DECLARE @Sorteados TABLE(
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

--	INSERT INTO @Sorteados(Nome) SELECT Nome FROM @Nomes
--	WHERE Codigo = @ChaveAtual

--END

--SELECT @Registros = COUNT(*) FROM @Sorteados

--SET @ChaveAtual = FLOOR(RAND() * (@Registros + 1))

--WHILE (@ChaveAtual = 0)
--BEGIN
--	SET @ChaveAtual = FLOOR(RAND() * (@Registros + 1))
--END

--SELECT * FROM @Sorteados
--WHERE Codigo = @ChaveAtual
--GO

--CRIAÇÃO DA PROCEDURE
CREATE PROCEDURE SP_Desafio_018
AS
BEGIN
	DECLARE @Nomes TABLE(
	Codigo INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	Nome VARCHAR(MAX) NOT NULL
	)

	DECLARE @Sorteados TABLE(
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

		INSERT INTO @Sorteados(Nome) SELECT Nome FROM @Nomes
		WHERE Codigo = @ChaveAtual
	END

	SELECT @Registros = COUNT(*) FROM @Sorteados

	SET @ChaveAtual = FLOOR(RAND() * (@Registros + 1))

	WHILE (@ChaveAtual = 0)
	BEGIN
		SET @ChaveAtual = FLOOR(RAND() * (@Registros + 1))
	END

	SELECT * FROM @Sorteados
	WHERE Codigo = @ChaveAtual
END
GO

--EXECUÇÃO DA PROCEDURE
EXEC SP_Desafio_018
GO
