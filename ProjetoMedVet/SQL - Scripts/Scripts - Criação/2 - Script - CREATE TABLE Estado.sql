CREATE TABLE dbo.Estado(
Codigo int IDENTITY(1,1) NOT NULL,
Nome varchar(MAX) NOT NULL,
UF varchar(2) NOT NULL,
CONSTRAINT PK_Estado PRIMARY KEY (Codigo)
)
GO