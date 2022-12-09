CREATE TABLE cidade(
	id_cidade BIGINT NOT NULL IDENTITY(1,1),
	nome VARCHAR(100) NOT NULL,
	codigo_IBGE7 BIGINT NULL,
	uf VARCHAR(2) NOT NULL,
	id_estado BIGINT NOT NULL,
	CONSTRAINT PK_Cidade PRIMARY KEY (id_cidade),
	CONSTRAINT FK_Cidade_Estado FOREIGN KEY (id_estado) REFERENCES estado (id_estado)
)
GO
