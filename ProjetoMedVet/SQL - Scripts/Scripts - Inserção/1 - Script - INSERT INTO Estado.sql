INSERT INTO Estado (Nome, UF) 
	SELECT DescricaoUF, SiglaUF
	FROM [CAP_PSG_202209].[dbo].[Estado]
GO