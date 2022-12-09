CREATE TABLE ponto_parada(
	id_ponto_parada BIGINT NOT NULL IDENTITY(1,1),
	descricao VARCHAR(255) NOT NULL,
	latitude VARCHAR(50) NOT NULL,
	longitude VARCHAR(50) NOT NULL,
	id_rota BIGINT NOT NULL,
	CONSTRAINT PK_PontoParada PRIMARY KEY (id_ponto_parada),
	CONSTRAINT FK_PontoParada_Rota FOREIGN KEY (id_rota) REFERENCES rota (id_rota)
)
GO