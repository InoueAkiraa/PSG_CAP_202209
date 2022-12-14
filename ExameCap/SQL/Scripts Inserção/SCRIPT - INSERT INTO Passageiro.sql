INSERT INTO Passageiro(Nome, Email, Telefone, Usuario, Senha, Documento, NumeroCartao, DataNascimento)
	SELECT Nome, Email, Telefone, Usuario, Senha, Documento, NumeroCartao, DataNascimento
	FROM RAW_Passageiro
GO