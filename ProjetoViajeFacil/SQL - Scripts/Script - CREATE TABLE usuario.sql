CREATE TABLE usuario(
	id_usuario BIGINT NOT NULL IDENTITY(1,1),
	nome VARCHAR(100) NOT NULL,
	email VARCHAR(50) NOT NULL,
	cpf VARCHAR(50) NOT NULL,
	telefone VARCHAR(20) NOT NULL,
	[login] VARCHAR(50) NOT NULL,
	senha VARCHAR(255) NOT NULL,
	id_endereco BIGINT NOT NULL,
	id_tipo_usuario BIGINT NOT NULL,
	id_instituicao BIGINT NOT NULL,
	CONSTRAINT PK_Usuario PRIMARY KEY (id_usuario),
	CONSTRAINT FK_Usuario_Endereco FOREIGN KEY (id_endereco) REFERENCES endereco (id_endereco),
	CONSTRAINT FK_Usuario_TipoUsuario FOREIGN KEY (id_tipo_usuario) REFERENCES tipo_usuario (id_tipo_usuario),
	CONSTRAINT FK_Usuario_Instituicao FOREIGN KEY (id_instituicao) REFERENCES instituicao (id_instituicao)
)
GO
