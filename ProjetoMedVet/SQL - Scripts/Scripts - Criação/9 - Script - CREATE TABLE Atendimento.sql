CREATE TABLE dbo.Atendimento(
Codigo int IDENTITY(1,1) NOT NULL,
CodigoTipoAtendimento int NOT NULL,
SiglaTipoAtendimento char(1) NOT NULL,
CodigoAtendente int NULL,
CodigoPaciente int NULL,
CodigoMedico int NULL,
CodigoEnfermeiro int NULL,
CodigoConvenio int NOT NULL,
Descricao varchar(max) NOT NULL,
DataHora datetime NOT NULL,
Ativo bit NULL DEFAULT(1),
DataInsert datetime NULL DEFAULT (GETDATE()),
DataUpdate datetime NULL,
DataDelete datetime NULL,
CONSTRAINT PK_Atendimento PRIMARY KEY (Codigo),
CONSTRAINT FK_Atendimento_Convenio FOREIGN KEY(CodigoConvenio) REFERENCES dbo.Convenio (Codigo),
CONSTRAINT FK_Atendimento_Pessoa_Atendente FOREIGN KEY(CodigoAtendente) REFERENCES dbo.Pessoa (Codigo),
CONSTRAINT FK_Atendimento_Pessoa_Medico FOREIGN KEY(CodigoMedico) REFERENCES dbo.Pessoa (Codigo),
CONSTRAINT FK_Atendimento_Pessoa_Paciente FOREIGN KEY(CodigoPaciente) REFERENCES dbo.Pessoa (Codigo),
CONSTRAINT FK_Atendimento_Pessoa_Enfermeiro FOREIGN KEY(CodigoEnfermeiro) REFERENCES dbo.Pessoa (Codigo),
CONSTRAINT FK_Atendimento_TipoAtendimento FOREIGN KEY(CodigoTipoAtendimento) REFERENCES dbo.TipoAtendimento (Codigo)
)
GO

