CREATE TABLE dbo.Endereco(
Codigo int IDENTITY(1,1) NOT NULL,
Rua varchar(100) NOT NULL,
Numero int NOT NULL,
Complemento varchar(255) NULL,
Bairro varchar(100) NOT NULL,
CEP varchar(9) NOT NULL,
CodigoCidade int NOT NULL,
CONSTRAINT PK_Endereco PRIMARY KEY (Codigo),
CONSTRAINT FK_Endereco_Cidade FOREIGN KEY(CodigoCidade) REFERENCES dbo.Cidade (Codigo)
)
GO