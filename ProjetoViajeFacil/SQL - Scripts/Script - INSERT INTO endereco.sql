INSERT INTO endereco (rua, numero, complemento, bairro, cep, id_cidade) 
	SELECT rua, numero, complemento, bairro, cep, id_cidade
	FROM dbo.RAW_ENDERECO
GO