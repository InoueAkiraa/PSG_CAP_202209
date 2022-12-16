CREATE TABLE dbo.Pessoa(
Codigo int IDENTITY(1,1) NOT NULL,
CodigoTipoPessoa int NOT NULL,
SiglaTipoPessoa char(1) NOT NULL,
Nome varchar(max) NOT NULL,
CodigoEndereco int NOT NULL,
CPF varchar(14) NOT NULL,
Telefone varchar(14) NOT NULL,
Sexo char(1) NOT NULL,
Escolaridade varchar(max) NULL,
DataNascimento datetime NULL,
Email varchar(max) NOT NULL,
Cargo varchar(max) NULL,
DataAdmissao datetime NULL,
DataDemissao datetime NULL,
Ativo bit NULL DEFAULT ((1)),
DataInsert datetime NULL DEFAULT (getdate()),
DataUpdate datetime NULL,
DataDelete datetime NULL,
CONSTRAINT PK_Pessoa PRIMARY KEY (Codigo),
CONSTRAINT FK_Pessoa_TipoPessoa FOREIGN KEY(CodigoTipoPessoa) REFERENCES dbo.TipoPessoa (Codigo),
CONSTRAINT FK_Pessoa_Endereco FOREIGN KEY (CodigoEndereco) REFERENCES dbo.Endereco(Codigo)
)
GO