--SELECT
--	FuncionarioId, 
--	Matricula, 
--	Nome, 
--	Sobrenome, 
--	Sexo, 
--	DataNascimento, 
--	Email, 
--	Ctps, 
--	CtpsNum, 
--	CtpsSerie, 
--	DataAdmissao
--FROM Funcionario
--WHERE Sexo = 'M'
--AND Nome LIKE 'CAR%'

DECLARE @NovoEmail TABLE(
	NovoEmailId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Nome VARCHAR(MAX) NOT NULL,
	Sobrenome VARCHAR(MAX) NOT NULL,
	NovoEmail VARCHAR(MAX) NOT NULL
)
DECLARE @FuncId BIGINT
DECLARE CursorFunc CURSOR
	FOR SELECT FuncionarioId FROM Funcionario WHERE Sexo = 'M' AND Nome LIKE 'CAR%'
OPEN CursorFunc
FETCH NEXT FROM CursorFunc INTO @FuncId
WHILE (@@FETCH_STATUS = 0)
BEGIN
	INSERT INTO @NovoEmail(Nome, Sobrenome, NovoEmail)
		SELECT 
			Nome,
			Sobrenome,
			Sobrenome + '_' + Nome + '@anguderosca.com.br' 
		FROM Funcionario
		WHERE (FuncionarioId = @FuncId)
	FETCH NEXT FROM CursorFunc INTO @FuncId
END
CLOSE CursorFunc
DEALLOCATE CursorFunc
SELECT * FROM @NovoEmail

GO
