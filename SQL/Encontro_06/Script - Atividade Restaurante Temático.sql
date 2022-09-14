CREATE TABLE TipoMesa(
	CodigoTipoMesa INT NOT NULL IDENTITY(1,1),
	Descricao VARCHAR(MAX) NOT NULL,
	CONSTRAINT PK_TipoMesa PRIMARY KEY (CodigoTipoMesa)
)
GO

CREATE TABLE Tema(
	CodigoTema INT NOT NULL IDENTITY(1,1),
	Descricao VARCHAR(MAX) NOT NULL,
	CONSTRAINT PK_Tema PRIMARY KEY (CodigoTema)
)
GO

CREATE TABLE Mesa(
	CodigoMesa INT NOT NULL IDENTITY(1,1),
	Quantidade INT NOT NULL,
	LugaresMinimos INT NOT NULL,
	LugaresMaximos INT NOT NULL,
	CodigoTipoMesa INT NOT NULL,
	CONSTRAINT PK_Mesa PRIMARY KEY(CodigoMesa),
	CONSTRAINT FK_Mesa_TipoMesa FOREIGN KEY (CodigoTipoMesa) REFERENCES TipoMesa(CodigoTipoMesa)
)
GO

CREATE TABLE TemaPorMesa(
	CodigoTemaPorMesa INT NOT NULL IDENTITY(1,1),
	CodigoMesa INT NOT NULL,
	CodigoTema INT NOT NULL,
	CONSTRAINT PK_TemaPorMesa PRIMARY KEY (CodigoTemaPorMesa),
	CONSTRAINT FK_TemaPorMesa_Mesa FOREIGN KEY (CodigoMesa) REFERENCES Mesa(CodigoMesa),
	CONSTRAINT FK_TemaPorMesa_Tema FOREIGN KEY (CodigoTema) REFERENCES Tema(CodigoTema)
)
GO

CREATE TABLE Reserva(
	CodigoReserva INT NOT NULL IDENTITY(1,1), ---
	CodigoCliente INT NOT NULL, ---
	CodigoTema INT NOT NULL, ----
	DataInclusao DATETIME NOT NULL DEFAULT GETDATE(),
	DataReserva DATETIME NOT NULL,
	Situacao BIT NOT NULL,
	NumeroDeLugares INT NOT NULL,
	CONSTRAINT PK_Reserva PRIMARY KEY(CodigoReserva),
	CONSTRAINT FK_Reserva_Cliente FOREIGN KEY(CodigoCliente) REFERENCES Cliente(Codigo),
	CONSTRAINT FK_Reserva_Tema FOREIGN KEY(CodigoTema) REFERENCES Tema(CodigoTema)
)
GO

CREATE TABLE MesaPorReserva(
	CodigoMesaPorReserva INT NOT NULL IDENTITY(1,1),
	CodigoMesa INT NOT NULL,
	CodigoReserva INT NOT NULL,
	CONSTRAINT PK_MesaPorReserva PRIMARY KEY(CodigoMesaPorReserva),
	CONSTRAINT FK_MesaPorReserva_Mesa FOREIGN KEY(CodigoMesa) REFERENCES Mesa(CodigoMesa),
	CONSTRAINT FK_MesaPorReserva_Reserva FOREIGN KEY (CodigoReserva) REFERENCES Reserva(CodigoReserva)
)
GO

INSERT INTO Tema (Descricao) VALUES 
('Nenhum'),
('Japonês'),
('Italiano'),
('Francês'),
('Mexicano')
GO

INSERT INTO TipoMesa (Descricao) VALUES
('RedondaPequena'), 
('RedondaGrande'), 
('RetangularPequena'),  
('RetangularGrande'),  
('QuadradaPequena'),  
('QuadradaGrande'), 
('Chabudai') -- 7
GO

INSERT INTO Mesa(Quantidade,LugaresMinimos, LugaresMaximos,CodigoTipoMesa) VALUES
(6, 1, 6, 1),
(4, 6, 10, 2),
(6, 1, 6, 3),
(3, 6, 12, 4),
(6, 1, 4, 5),
(5, 6, 8, 6),
(10, 2, 4, 7)
GO

INSERT INTO TemaPorMesa(CodigoMesa, CodigoTema) VALUES 
(1,5),
(7,2),
(6,4),
(2,3),
(5,4),
(3,5),
(4,2)
GO

INSERT INTO Reserva (CodigoCliente, CodigoTema, DataReserva, Situacao, NumeroDeLugares) VALUES
(4, 2, '2022-09-16', 1, 4),
(2, 1, '2022-09-17', 1, 5),
(5, 4, '2022-09-18', 1, 2),
(3, 3, '2022-09-19', 1, 10),
(2, 5, '2022-09-20', 1, 12)
GO

INSERT INTO MesaPorReserva (CodigoMesa, CodigoReserva) VALUES 
(4,5),
(2,4),
(5,3),
(3,2),
(7,1)
GO
