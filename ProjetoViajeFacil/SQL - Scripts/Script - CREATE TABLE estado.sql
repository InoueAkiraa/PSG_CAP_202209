CREATE TABLE estado(
	id_estado BIGINT NOT NULL IDENTITY(1,1),
	nome VARCHAR(100) NOT NULL,
	codigo_uf BIGINT NULL,
	uf VARCHAR(2) NOT NULL,
	id_regiao BIGINT NOT NULL,
	CONSTRAINT PK_Estado PRIMARY KEY (id_estado),
	CONSTRAINT FK_Estado_Regiao FOREIGN KEY (id_regiao) REFERENCES regiao (id_regiao)
)
GO
