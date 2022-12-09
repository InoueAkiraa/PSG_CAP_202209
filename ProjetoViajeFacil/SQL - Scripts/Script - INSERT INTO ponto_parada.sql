INSERT INTO ponto_parada(descricao, latitude, longitude, id_rota) 
	SELECT descricao, latitude, longitude, id_rota
	FROM RAW_PONTO_PARADA
GO