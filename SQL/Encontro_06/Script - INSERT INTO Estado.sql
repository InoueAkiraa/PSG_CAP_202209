INSERT INTO Estado(CodigoUF, SiglaUF)
	SELECT CodigoUF, DescricaoUF
	FROM RAW_Municipio_Previa_01
	GROUP BY CodigoUF, DescricaoUF
	ORDER BY CodigoUF
GO
