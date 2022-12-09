INSERT INTO regiao (nome, id_pais) 
	SELECT Regiao, 30
	FROM [CAP_PSG_202209].[dbo].[Municipio]
	GROUP BY Regiao
GO

