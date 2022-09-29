--CRIAÇÃO DA TABELA
CREATE TABLE Funcionario(
	FuncionarioId BIGINT NOT NULL IDENTITY(1,1),
	Matricula BIGINT NOT NULL,
	Nome VARCHAR(50) NOT NULL,
	Sobrenome VARCHAR(50) NOT NULL,
	Sexo CHAR(1) NOT NULL,
	DataNascimento DATETIME NOT NULL,
	Email VARCHAR(50) NOT NULL,
	Ctps VARCHAR(20) NOT NULL,
	CtpsNum BIGINT NOT NULL,
	CtpsSerie INT NOT NULL,
	DataAdmissao DATETIME NULL DEFAULT GETDATE(),
	CONSTRAINT PK_Funcionario PRIMARY KEY (FuncionarioId)
)
GO

--DESATIVAÇÃO DO IDENTITY PARA A INSERÇÃO
SET IDENTITY_INSERT Funcionario ON
GO

--INSERÇÃO DE VALORES COM RESULTADOS OBTIDOS DO SELECT ENTRE EMPRESA E PESSOA
INSERT INTO Funcionario (FuncionarioId, Matricula, Nome, Sobrenome, Sexo, DataNascimento, Email, Ctps, CtpsNum, CtpsSerie, DataAdmissao)
	SELECT  Pessoa.funcid, 
			Empresa.chave, 
			Pessoa.nome, 
			Pessoa.sobrenome, 
			Pessoa.sexo, 
			Pessoa.datanascimento, 
			Pessoa.email, 
			Empresa.ctps, 
			Empresa.ctpsnum, 
			Empresa.ctpsserie, 
			Empresa.dataadmissao

	FROM RAW_Funcionarios_Dados_Pessoais AS Pessoa 
	INNER JOIN RAW_Funcionarios_Dados_Empresa AS Empresa ON Pessoa.chave = Empresa.chave

--REATIVANDO O IDENTITY
SET IDENTITY_INSERT Funcionario OFF
GO
