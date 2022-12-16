CREATE TABLE dbo.TipoPessoa(
Codigo int IDENTITY(1,1) NOT NULL,
Sigla char(1) NOT NULL,
Descricao varchar(max) NOT NULL,
Ativo bit NULL DEFAULT ((1)),
DataInsert datetime NULL DEFAULT (getdate()),
DataUpdate datetime NULL,
DataDelete datetime NULL,
CONSTRAINT PK_TipoPessoa PRIMARY KEY (Codigo)
)
GO