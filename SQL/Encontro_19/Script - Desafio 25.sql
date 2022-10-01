--25 - Crie uma procedure que busque e liste os funcionários que tenham as 3 letras determinadas no sobrenome. 
--Por exemplo, procure todos funcionários que tenham as letras SAN no sobrenome.

--SCRIPT
DECLARE @Letras CHAR(3) 
SET @Letras = 'San'

SELECT * FROM Funcionario
WHERE Sobrenome LIKE '%'+@Letras+'%'
ORDER BY Nome, Sobrenome
GO

--CRIAÇÃO DA PROCEDURE
CREATE PROCEDURE SP_Desafio_025
@Letras CHAR(3)
AS
BEGIN
	SELECT * FROM Funcionario
	WHERE Sobrenome LIKE '%'+@Letras+'%'
	ORDER BY Nome, Sobrenome
END
GO

--EXECUÇÃO DA PROCEDURE
EXEC SP_Desafio_025 'San'
GO
