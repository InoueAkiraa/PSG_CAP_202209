UPDATE Cliente
SET Ativo = 0, DataAlteracao = GETDATE()
WHERE Codigo = 6
GO

INSERT INTO Cliente(Nome, Documento,Telefone,Email,Endereco) 
VALUES 
('Barrabas','123','987654321','barrabas@teste.com','Rua X, n. 10')
GO

UPDATE Cliente
SET Ativo = 0, DataAlteracao = GETDATE(), DataExclusao = GETDATE()
WHERE Codigo = 9
GO

UPDATE Cliente
SET Ativo = 1, DataAlteracao = GETDATE(), DataExclusao = NULL
WHERE Codigo = 9
GO
