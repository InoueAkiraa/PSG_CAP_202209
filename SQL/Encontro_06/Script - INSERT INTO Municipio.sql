INSERT INTO Municipio (CodigoMunicipio, NomeMunicipio, CodigoIBGE6, CodigoIBGE7, CEP, CodigoUF, SiglaUF, Regiao, Populacao, Porte)
	SELECT	A.MunicipioID, 
			A.Nome, 
			B.IBGE,
			B.IBGE7, 
			C.CEP, 
			A.UFID, 
			C.UF, 
			B.Região, 
			B.População_2010, 
			B.Porte
		FROM RAW_Municipios_Complementar_IBGE_UTF8 AS A 
		INNER JOIN	RAW_Lista_de_Municipios_com_IBGE_Brasil_UTF8 AS B ON A.CodigoIBGE = B.IBGE7 
		INNER JOIN  RAW_Cidades_IBGE6_UTF8 AS C ON B.IBGE = C.IBGE
