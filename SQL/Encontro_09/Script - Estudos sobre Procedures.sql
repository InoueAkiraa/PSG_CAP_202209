--SCRIPT DE TESTE ANTES DE CRIAR A PROCEDURE (EXEMPLO DO PROFESSOR)
DECLARE @SIGLA CHAR(2)
SET @SIGLA = 'MS'

SELECT	CodigoMunicipio, NomeMunicipio, CodigoIBGE6, CodigoIBGE7, CEP, SiglaUF, DescricaoUF
FROM VW_Municipios_IBGE AS GO
WHERE (SiglaUF = @SIGLA)
GO

--CRIAÇÃO DA PROCEDURE (EXEMPLO DO PROFESSOR)
CREATE PROCEDURE SP_Pesquisar_Municipios_Por_SiglaUF
@SIGLA CHAR(2)
AS
BEGIN
	SELECT	CodigoMunicipio, NomeMunicipio, CodigoIBGE6, CodigoIBGE7, CEP, SiglaUF, DescricaoUF
	FROM VW_Municipios_IBGE AS GO
	WHERE (SiglaUF = @SIGLA)
END
GO

--EXECUÇÃO DA PROCEDURE (EXEMPLO DO PROFESSOR)
EXEC dbo.SP_Pesquisar_Municipios_Por_SiglaUF 'RN'
GO
-------------
-------------
-------------

--CRIAÇÃO DE PROCEDURE PROPOSTA PELO PROFESSOR
-- TESTE DO SCRIPT
DECLARE @CodigoIBGE7 INT
SET @CodigoIBGE7 = 1100601
SELECT	CodigoMunicipio, NomeMunicipio, CodigoIBGE6, CodigoIBGE7, CEP, SiglaUF, DescricaoUF
FROM VW_Municipios_IBGE AS GO
WHERE (CodigoIBGE7 = @CodigoIBGE7)
GO

--CRIAÇÃO DA PROCEDURE
CREATE PROCEDURE SP_Pesquisar_Municipios_Por_CodigoIBGE7
@CodigoIBGE7 INT
AS
BEGIN
	SELECT	CodigoMunicipio, NomeMunicipio, CodigoIBGE6, CodigoIBGE7, CEP, SiglaUF, DescricaoUF
	FROM VW_Municipios_IBGE AS GO
	WHERE (CodigoIBGE7 = @CodigoIBGE7)
END
GO

--EXECUÇÃO DA PROCEDURE
EXEC dbo.SP_Pesquisar_Municipios_Por_CodigoIBGE7 1100601
GO
