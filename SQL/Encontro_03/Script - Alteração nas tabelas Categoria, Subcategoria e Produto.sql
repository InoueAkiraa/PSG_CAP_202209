ALTER TABLE Categoria
	ADD CONSTRAINT DF_DATAINSERT 
		DEFAULT GETDATE() FOR DataInsert
GO

ALTER TABLE Subcategoria
	ADD CONSTRAINT DF_DATAINSERT2 
		DEFAULT GETDATE() FOR DataInsert
GO

ALTER TABLE Produto
	ADD CONSTRAINT DF_DATAINSERT3 
		DEFAULT GETDATE() FOR DataInsert
GO
