CREATE TABLE dbo.Convenio(
Codigo int IDENTITY(1,1) NOT NULL,
Descricao varchar(max) NOT NULL,
Plano varchar(max) NOT NULL,
Tarifa decimal(7, 2) NOT NULL,
CONSTRAINT PK_Convenio PRIMARY KEY (Codigo)
)
GO