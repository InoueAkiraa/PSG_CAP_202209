CREATE TABLE regiao(
	id_regiao BIGINT NOT NULL IDENTITY(1,1),
	nome VARCHAR(100) NOT NULL,
	id_pais BIGINT NOT NULL,
	CONSTRAINT PK_Regiao PRIMARY KEY (id_regiao),
	CONSTRAINT FK_Regiao_Pais FOREIGN KEY (id_pais) REFERENCES pais (id_pais)
)
GO
