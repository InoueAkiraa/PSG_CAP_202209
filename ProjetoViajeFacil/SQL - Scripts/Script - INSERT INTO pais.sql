SET IDENTITY_INSERT [dbo].[Pais] ON

INSERT INTO pais (id_pais, nome) 
	SELECT PaisID, Descricao 
	FROM [CAP_PSG_202209].[dbo].[Pais]
GO

SET IDENTITY_INSERT [dbo].[Pais] OFF