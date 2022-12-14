INSERT INTO Funcionario (Nome, Email, Telefone, Usuario, Senha, Matricula, ContaCorrente, DataNascimento)
	SELECT Nome, Email, Telefone, Usuario, Senha, Matricula, ContaCorrente, DataNascimento
	FROM RAW_Funcionario
GO