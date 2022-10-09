CREATE TABLE TipoAquicultura(
	IdTipoAquicultura INT NOT NULL IDENTITY(1,1),
	DescricaoTipoAquicultura VARCHAR(100) NOT NULL
	CONSTRAINT PK_TipoAquicultura PRIMARY KEY (IdTipoAquicultura)
)
GO

SET IDENTITY_INSERT TipoAquicultura ON
GO

INSERT INTO TipoAquicultura (IdTipoAquicultura, DescricaoTipoAquicultura)
	SELECT DISTINCT Id_Tipo_Aquicultura, Descricao_Tipo_Aquicultura FROM RAW_Aquicultura_Brasil_Municipios
	ORDER BY Id_Tipo_Aquicultura

SET IDENTITY_INSERT TipoAquicultura OFF
GO