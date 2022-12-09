CREATE TABLE participante_evento(
	id_participante BIGINT NOT NULL IDENTITY(1,1),
	pagamento INT NOT NULL,
	sugestao VARCHAR(255) NOT NULL,
	avaliacao INT NULL,
	id_evento BIGINT NOT NULL,
	id_usuario BIGINT NOT NULL,
	CONSTRAINT PK_ParticipanteEvento PRIMARY KEY (id_participante),
	CONSTRAINT FK_ParticipanteEvento_Evento FOREIGN KEY (id_evento) REFERENCES evento (id_evento),
	CONSTRAINT FK_ParticipanteEvento_Usuario FOREIGN KEY (id_usuario) REFERENCES usuario (id_usuario)
)
GO