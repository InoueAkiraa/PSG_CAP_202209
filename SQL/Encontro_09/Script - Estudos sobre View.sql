--CRIAÇÃO DE UMA VIEW (INSERINDO DADOS OBTIDOS ATRAVÉS DO SELECT) 
CREATE VIEW VW_Municipios_IBGE
AS
SELECT        
	Municipio.CodigoMunicipio, 
	Municipio.NomeMunicipio, 
	Municipio.CodigoIBGE6, 
	Municipio.CodigoIBGE7, 
	Municipio.CEP, 
	Municipio.SiglaUF, 
	Estado.DescricaoUF
FROM Estado 
INNER JOIN Municipio ON Estado.CodigoUF = Municipio.CodigoUF
GO

--SELECT DO VIEW CRIADO
SELECT * FROM dbo.VW_Municipios_IBGE
GO
