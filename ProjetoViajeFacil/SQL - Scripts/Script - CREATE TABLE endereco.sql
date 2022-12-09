CREATE TABLE endereco(
	id_endereco BIGINT NOT NULL IDENTITY(1,1),
	rua VARCHAR(100) NOT NULL,
	numero INT NOT NULL,
	complemento VARCHAR(255) NULL,
	bairro VARCHAR(100) NOT NULL,
	cep VARCHAR(9) NOT NULL,
	id_cidade BIGINT NOT NULL,
	CONSTRAINT PK_Endereco PRIMARY KEY (id_endereco),
	CONSTRAINT FK_Endereco_Cidade FOREIGN KEY (id_cidade) REFERENCES cidade (id_cidade)
)
GO
