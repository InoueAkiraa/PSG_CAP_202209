CREATE TABLE instituicao(
	id_instituicao BIGINT NOT NULL IDENTITY(1,1),
	nome VARCHAR(100) NOT NULL,
	telefone VARCHAR(20) NOT NULL,
	id_endereco BIGINT NOT NULL,
	CONSTRAINT PK_Instituicao PRIMARY KEY (id_instituicao),
	CONSTRAINT FK_Instituicao_Endereco FOREIGN KEY (id_endereco) REFERENCES endereco (id_endereco)
)
GO
