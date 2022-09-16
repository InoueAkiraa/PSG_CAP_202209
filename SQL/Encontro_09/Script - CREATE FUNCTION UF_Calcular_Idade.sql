CREATE FUNCTION UF_Calcular_Idade(@dataNascimento DATE)
RETURNS INT AS
BEGIN
	DECLARE @idade INT
	DECLARE @dataReferencia Date = GETDATE()
	SELECT @idade =
	(
		CASE 
			WHEN MONTH(@dataReferencia) > MONTH(@dataNascimento) -- *1
			OR
			-- *2
			(
				MONTH(@dataReferencia) = MONTH(@dataNascimento) 
				AND DAY(@dataReferencia) >= DAY(@dataNascimento) 
			)
			THEN DATEDIFF(YEAR, @dataNascimento, @dataReferencia) 
			ELSE DATEDIFF(YEAR, @dataNascimento, @dataReferencia) - 1 
		END
	)
RETURN @IDADE
END

GO
