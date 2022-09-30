--21 - Crie uma procedure que liste os funcionários pelo nome, utilizando as 3 primeiras letras do nome. 
--Por exemplo, procure todos funcionários cujo nome comece com as letras MAR.

--SCRIPT
--DECLARE @LetrasIniciais CHAR(3)
--SET @LetrasIniciais = 'Mar'
	 
--DECLARE @Registros INT
--SELECT @Registros = COUNT(*) FROM Funcionario WHERE Nome LIKE @LetrasIniciais+'%'

--IF (@Registros = 0)
--BEGIN
--	PRINT('Não existe nenhum funcionário(a) que inicie o nome com ' +@LetrasIniciais)
--END
--ELSE
--BEGIN
--	SELECT * FROM Funcionario
--	WHERE Nome LIKE @LetrasIniciais+'%'  
--	ORDER BY Nome, Sobrenome
--END
--GO

--CRIAÇÃO DA PROCEDURE
CREATE PROCEDURE SP_Desafio_021
@LetrasIniciais CHAR(3)
AS
BEGIN
	DECLARE @Registros INT
	SELECT @Registros = COUNT(*) FROM Funcionario WHERE Nome LIKE @LetrasIniciais+'%'

	IF (@Registros = 0)
	BEGIN
		PRINT('Não existe nenhum funcionário(a) que inicie o nome com ' +@LetrasIniciais)
	END
	ELSE
	BEGIN
		SELECT * FROM Funcionario
		WHERE Nome LIKE @LetrasIniciais+'%'  
		ORDER BY Nome, Sobrenome
	END 
END
GO

--EXECUÇÃO DA PROCEDURE
EXEC SP_Desafio_021 'Mar'
GO
