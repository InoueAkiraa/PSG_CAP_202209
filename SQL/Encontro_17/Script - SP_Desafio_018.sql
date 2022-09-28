DECLARE @ListaNomes TABLE(
	Id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Nome VARCHAR(MAX) NOT NULL
)

INSERT INTO @ListaNomes VALUES 
('Akira'),
('Adão'),
('João'),
('José'),
('Rafael'),
('Rafaela'),
('Bruno'),
('Bruna'),
('Thiago'),
('Manoel'),
('Manoela'),
('Joana'),
('Paulo'),
('Paula'),
('Paolo'),
('Paola'),
('Marlon'),
('Marlene'),
('Larissa'),
('Iami'),
('Yumi')

DECLARE @ListaSorteados TABLE(
	Id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	IdLista INT NOT NULL,
	Nome VARCHAR(MAX) NOT NULL
)

DECLARE @Contador INT
SET @Contador = 0

DECLARE @QtdSorteios INT
SET @QtdSorteios = 0

DECLARE @Registros INT 
DECLARE @Chave INT 

WHILE (@Contador < 4)
BEGIN
	SELECT @Registros = COUNT(*) FROM @ListaNomes
	SET @Chave = FLOOR(RAND() * (@Registros + 1))
	SET @QtdSorteios = @QtdSorteios + 1
	WHILE (@Chave = 0)
	BEGIN
		SET @Chave = FLOOR(RAND() * (@Registros + 1))
		SET @QtdSorteios = @QtdSorteios + 1
	END

	IF ((SELECT COUNT(*) FROM @ListaSorteados) = 0)
	BEGIN
		INSERT INTO @ListaSorteados(IdLista, Nome)
			SELECT Id, Nome FROM @ListaNomes WHERE Id = @Chave
		SET @Contador = @Contador + 1
	END
	ELSE
	BEGIN
		IF ((SELECT COUNT(*) FROM @ListaSorteados WHERE Id = @Chave) = 0)
		BEGIN
			INSERT INTO @ListaSorteados(IdLista, Nome)
				SELECT Id, Nome FROM @ListaNomes WHERE Id = @Chave
			SET @Contador = @Contador + 1
		END
	END
END

SELECT @Registros = COUNT(*) FROM @ListaSorteados
SET @Chave = FLOOR(RAND() * (@Registros + 1))
WHILE (@Chave = 0)
BEGIN
	SET @Chave = FLOOR(RAND() * (@Registros + 1))
END

WHILE (NOT EXISTS(SELECT * FROM @ListaSorteados WHERE Id = @Chave))
BEGIN
	SET @Chave = FLOOR(RAND() * (@Registros + 1))
END

SELECT @Chave AS [Chave]
SELECT * FROM @ListaSorteados
SELECT * FROM @ListaSorteados WHERE Id = @Chave

GO
