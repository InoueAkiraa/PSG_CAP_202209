SET IDENTITY_INSERT Departamento ON
GO

INSERT INTO Departamento(DepartamentoId, Descricao)
	SELECT deptoid, nome FROM RAW_Departamentos

SET IDENTITY_INSERT Departamento OFF
GO
