INSERT INTO usuario (nome, email, cpf, telefone, [login], senha, id_endereco, id_tipo_usuario, id_instituicao)
	SELECT nome, email, cpf, telefone, [login], senha, id_endereco, id_tipo_usuario, id_instituicao
	FROM RAW_USUARIO
GO