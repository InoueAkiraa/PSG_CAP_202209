CREATE TABLE dbo.Cidade(
Codigo int IDENTITY(1,1) NOT NULL,
Nome varchar(MAX) NOT NULL,
CodigoIBGE7 int NOT NULL,
CodigoEstado int NOT NULL,
CONSTRAINT PK_Cidade PRIMARY KEY (Codigo),
CONSTRAINT FK_Cidade_Estado FOREIGN KEY(CodigoEstado) REFERENCES dbo.Estado(Codigo)
)
GO