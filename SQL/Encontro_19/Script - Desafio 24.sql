--24 - Crie uma procedure que sorteie e liste um determinado número de funcionários. 
--Por exemplo, sortear aleatoriamente e listar 40 funcionários, SEM REPETIR.

--SCRIPT
--DECLARE @ListaNova TABLE(
--	ListaNovaId BIGINT NOT NULL IDENTITY(1,1) PRIMARY KEY,
--	FuncionarioId BIGINT NOT NULL,
--	Matricula BIGINT NOT NULL,
--	Nome VARCHAR(50) NOT NULL,
--	Sobrenome VARCHAR(50) NOT NULL,
--	Sexo CHAR(1) NOT NULL,
--	DataNascimento DATETIME NOT NULL,
--	Email VARCHAR(50) NOT NULL,
--	Ctps VARCHAR(20) NOT NULL,
--	CtpsNum BIGINT NOT NULL,
--	CtpsSerie INT NOT NULL,
--	DataAdmissao DATETIME NULL
--)

--INSERT INTO @ListaNova 
--	SELECT * FROM Funcionario 

--DECLARE @ListaSorteada TABLE(
--	ListaSorteadaId BIGINT NOT NULL PRIMARY KEY,
--	FuncionarioId BIGINT NOT NULL,
--	Matricula BIGINT NOT NULL,
--	Nome VARCHAR(50) NOT NULL,
--	Sobrenome VARCHAR(50) NOT NULL,
--	Sexo CHAR(1) NOT NULL,
--	DataNascimento DATETIME NOT NULL,
--	Email VARCHAR(50) NOT NULL,
--	Ctps VARCHAR(20) NOT NULL,
--	CtpsNum BIGINT NOT NULL,
--	CtpsSerie INT NOT NULL,
--	DataAdmissao DATETIME NULL
--)

--DECLARE @QtdDesejada INT
--SET @QtdDesejada = 40

--DECLARE @Contador BIGINT
--SET @Contador = 0

--WHILE(@Contador < @QtdDesejada)
--BEGIN
--	DECLARE @Registros BIGINT
--	SELECT @Registros = COUNT(*) FROM @ListaNova

--	DECLARE @Chave BIGINT
--	SET @Chave = FLOOR(RAND() * (@Registros + 1))

--	WHILE(@Chave = 0)
--	BEGIN
--		SET @Chave = FLOOR(RAND() * (@Registros + 1))
--	END

--	IF((SELECT COUNT(*) FROM @ListaSorteada) = 0)
--	BEGIN
--		INSERT INTO @ListaSorteada 
--			SELECT * FROM @ListaNova WHERE ListaNovaId = @Chave
--		SET @Contador = @Contador + 1
--	END
--	ELSE
--	BEGIN
--		IF ((SELECT COUNT(*) FROM @ListaSorteada WHERE ListaSorteadaId = @Chave) = 0)
--		BEGIN
--			INSERT INTO @ListaSorteada
--				SELECT * FROM @ListaNova WHERE ListaNovaId = @Chave
--			SET @Contador = @Contador + 1
--		END
--	END
--END

--SELECT * FROM @ListaSorteada
--GO

--CRIAÇÃO DA PROCEDURE
CREATE PROCEDURE SP_Desafio_024
@QtdDesejada BIGINT
AS
BEGIN
	DECLARE @ListaNova TABLE(
	ListaNovaId BIGINT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	FuncionarioId BIGINT NOT NULL,
	Matricula BIGINT NOT NULL,
	Nome VARCHAR(50) NOT NULL,
	Sobrenome VARCHAR(50) NOT NULL,
	Sexo CHAR(1) NOT NULL,
	DataNascimento DATETIME NOT NULL,
	Email VARCHAR(50) NOT NULL,
	Ctps VARCHAR(20) NOT NULL,
	CtpsNum BIGINT NOT NULL,
	CtpsSerie INT NOT NULL,
	DataAdmissao DATETIME NULL
	)

	INSERT INTO @ListaNova 
		SELECT * FROM Funcionario 

	DECLARE @ListaSorteada TABLE(
		ListaSorteadaId BIGINT NOT NULL PRIMARY KEY,
		FuncionarioId BIGINT NOT NULL,
		Matricula BIGINT NOT NULL,
		Nome VARCHAR(50) NOT NULL,
		Sobrenome VARCHAR(50) NOT NULL,
		Sexo CHAR(1) NOT NULL,
		DataNascimento DATETIME NOT NULL,
		Email VARCHAR(50) NOT NULL,
		Ctps VARCHAR(20) NOT NULL,
		CtpsNum BIGINT NOT NULL,
		CtpsSerie INT NOT NULL,
		DataAdmissao DATETIME NULL
	)

	DECLARE @Contador BIGINT
	SET @Contador = 0

	WHILE(@Contador < @QtdDesejada)
	BEGIN
		DECLARE @Registros BIGINT
		SELECT @Registros = COUNT(*) FROM @ListaNova

		DECLARE @Chave BIGINT
		SET @Chave = FLOOR(RAND() * (@Registros + 1))

		WHILE(@Chave = 0)
		BEGIN
			SET @Chave = FLOOR(RAND() * (@Registros + 1))
		END

		IF((SELECT COUNT(*) FROM @ListaSorteada) = 0)
		BEGIN
			INSERT INTO @ListaSorteada 
				SELECT * FROM @ListaNova WHERE ListaNovaId = @Chave
			SET @Contador = @Contador + 1
		END
		ELSE
		BEGIN
			IF ((SELECT COUNT(*) FROM @ListaSorteada WHERE ListaSorteadaId = @Chave) = 0)
			BEGIN
				INSERT INTO @ListaSorteada
					SELECT * FROM @ListaNova WHERE ListaNovaId = @Chave
				SET @Contador = @Contador + 1
			END
		END
	END

	SELECT * FROM @ListaSorteada
END
GO

--EXECUÇÃO DA PROCEDURE
EXEC SP_Desafio_024 40
GO
