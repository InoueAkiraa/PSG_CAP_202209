UPDATE RAW_Aquicultura_Brasil_Municipios
	SET Producao = NULL
	WHERE Producao = 'NULL'
GO

UPDATE RAW_Aquicultura_Brasil_Municipios
	SET Valor_Producao = NULL
	WHERE Valor_Producao = 'NULL'
GO

UPDATE RAW_Aquicultura_Brasil_Municipios
	SET Proporcao_Valor_Producao = NULL
	WHERE Proporcao_Valor_Producao = 'NULL'
GO

CREATE TABLE Aquicultura (
	IdAquicultura INT NOT NULL IDENTITY(1,1),
	Ano INT NOT NULL,
	IdMunicipio INT NOT NULL,
	IdTipoAquicultura INT NOT NULL,
	Producao INT NULL,
	ValorProducao INT NULL,
	ProporcaoValorProducao INT NULL,
	Moeda VARCHAR(5) NOT NULL,
	CONSTRAINT PK_Aquicultura PRIMARY KEY (IdAquicultura),
	CONSTRAINT FK_Aquicultura_TipoAquicultura FOREIGN KEY (IdTipoAquicultura) REFERENCES TipoAquicultura(IdTipoAquicultura)
)

SET IDENTITY_INSERT Aquicultura ON
GO

INSERT INTO Aquicultura (IdAquicultura, Ano, IdMunicipio, IdTipoAquicultura, Producao, ValorProducao, ProporcaoValorProducao, Moeda)
	SELECT 
		Id_Aquicultura, 
		Ano, 
		Id_Municipio, 
		Id_Tipo_Aquicultura, 
		Producao, 
		Valor_Producao, 
		Proporcao_Valor_Producao, 
		Moeda 

	FROM RAW_Aquicultura_Brasil_Municipios

SET IDENTITY_INSERT Aquicultura OFF
GO

