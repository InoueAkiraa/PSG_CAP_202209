CREATE TABLE tipo_usuario(
	id_tipo_usuario BIGINT NOT NULL IDENTITY(1,1),
	descricao VARCHAR(100) NOT NULL,
	CONSTRAINT PK_TipoUsuario PRIMARY KEY (id_tipo_usuario)
)
GO
