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

DECLARE @QtdDesejada INT
SET @QtdDesejada = 40

DECLARE @Contador BIGINT
SET @Contador = 0

WHILE(@Contador < @QtdDesejada)
BEGIN
	DECLARE @Registros BIGINT
	SELECT @Registros = COUNT(*) FROM vw_FuncionariosParaSorteio

	DECLARE @Chave BIGINT
	SET @Chave = FLOOR(RAND() * (@Registros + 1))

	WHILE(@Chave = 0)
	BEGIN
		SET @Chave = FLOOR(RAND() * (@Registros + 1))
	END

	IF((SELECT COUNT(*) FROM @ListaSorteada) = 0)
	BEGIN
		INSERT INTO @ListaSorteada 
			SELECT * FROM vw_FuncionariosParaSorteio WHERE SorteioId = @Chave
		SET @Contador = @Contador + 1
	END
	ELSE
	BEGIN
		IF ((SELECT COUNT(*) FROM @ListaSorteada WHERE ListaSorteadaId = @Chave) = 0)
		BEGIN
			INSERT INTO @ListaSorteada
				SELECT * FROM vw_FuncionariosParaSorteio WHERE SorteioId = @Chave
			SET @Contador = @Contador + 1
		END
	END
END

SELECT * FROM @ListaSorteada
GO
