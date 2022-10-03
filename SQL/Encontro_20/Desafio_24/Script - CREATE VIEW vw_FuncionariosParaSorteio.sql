CREATE VIEW vw_FuncionariosParaSorteio
AS
	SELECT        
		ROW_NUMBER() OVER (
					ORDER BY FuncionarioId
			) SorteioId,
		FuncionarioId, 
		Matricula, 
		Nome, 
		Sobrenome, 
		Sexo, 
		DataNascimento, 
		Email, 
		Ctps, 
		CtpsNum, 
		CtpsSerie, 
		DataAdmissao
	FROM Funcionario
GO
