DECLARE @dataNascimento Date = '1974-12-17'

DECLARE @dataReferencia Date = GETDATE()
DECLARE @idade INT

SELECT @idade =
(
    CASE 
        WHEN 
        MONTH(@dataReferencia) > MONTH(@dataNascimento) -- *1
        OR
        -- *2
        (
            MONTH(@dataReferencia) = MONTH(@dataNascimento) 
            AND DAY(@dataReferencia) >= DAY(@dataNascimento) 
        )
    THEN DATEDIFF(YEAR, @dataNascimento, @dataReferencia) 
    ELSE DATEDIFF(YEAR, @dataNascimento, @dataReferencia) -1 END
)
PRINT @idade
GO
