CREATE TABLE Parcela(
	ParcelaId BIGINT NOT NULL IDENTITY(1,1),
	FuncionarioId BIGINT NOT NULL,
	ParcelaNumero INT NOT NULL,
	Valor DECIMAL NOT NULL,
	CONSTRAINT PK_Parcela PRIMARY KEY (ParcelaId),
	CONSTRAINT FK_Parcela_Funcionario FOREIGN KEY (FuncionarioId) REFERENCES Funcionario(FuncionarioId)
)
