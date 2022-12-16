INSERT INTO Cidade (Nome, CodigoIBGE7, CodigoEstado)
	SELECT NomeMunicipio, CodigoIBGE7, CodigoUF
	FROM [CAP_PSG_202209].[dbo].[Municipio]
GO