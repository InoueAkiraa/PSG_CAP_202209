CREATE TABLE evento(
	id_evento BIGINT NOT NULL IDENTITY(1,1),
	titulo VARCHAR(255) NOT NULL,
	descricao VARCHAR(255) NOT NULL,
	data_ida DATE NOT NULL,
	data_volta DATE NOT NULL,
	id_instituicao BIGINT NOT NULL,
	id_endereco BIGINT NOT NULL,
	id_rota_ida BIGINT NOT NULL,
	id_rota_volta BIGINT NOT NULL,
	id_usuario_responsavel BIGINT NOT NULL,
	CONSTRAINT PK_Evento PRIMARY KEY (id_evento),
	CONSTRAINT FK_Evento_Instituicao FOREIGN KEY (id_instituicao) REFERENCES instituicao (id_instituicao),
	CONSTRAINT FK_Evento_Endereco FOREIGN KEY (id_endereco) REFERENCES endereco (id_endereco),
	CONSTRAINT FK_Evento_RotaIda FOREIGN KEY (id_rota_ida) REFERENCES rota (id_rota),
	CONSTRAINT FK_Evento_RotaVolta FOREIGN KEY (id_rota_volta) REFERENCES rota(id_rota),
	CONSTRAINT FK_Evento_Usuario FOREIGN KEY (id_usuario_responsavel) REFERENCES usuario (id_usuario)
)
GO