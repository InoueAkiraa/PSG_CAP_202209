INSERT INTO instituicao (nome, telefone, id_endereco) 
	SELECT nome, telefone, id_endereco
	FROM RAW_INSTITUICAO
GO

