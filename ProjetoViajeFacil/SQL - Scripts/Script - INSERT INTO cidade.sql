INSERT INTO cidade(nome, codigo_IBGE7, uf, id_estado)
	SELECT m.NomeMunicipio, m.CodigoIBGE7, m.SiglaUF, e.id_estado
	FROM CAP_PSG_202209.dbo.Municipio as m 
	INNER JOIN estado as e ON m.SiglaUF = e.uf	
GO

