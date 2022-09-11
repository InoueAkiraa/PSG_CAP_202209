ALTER TABLE IngredientePorReceita
	DROP CONSTRAINT FK_IngredientePorReceita_Ingrediente, FK_IngredientePorReceita_Receita;
GO

DROP TABLE Ingrediente	
GO

DROP TABLE Receita
GO

DROP TABLE Prato
GO

DROP TABLE Pedido
GO

CREATE TABLE Ingrediente(
	Codigo INT NOT NULL IDENTITY(1,1),
	Descricao VARCHAR(MAX) NOT NULL,
	CONSTRAINT PK_Ingrediente PRIMARY KEY (Codigo)
)
GO

CREATE TABLE Pedido(
	Codigo INT NOT NULL IDENTITY(1,1),
	Descricao VARCHAR(MAX) NOT NULL,
	CodigoCliente INT NOT NULL,
	CONSTRAINT PK_Pedido PRIMARY KEY (Codigo),
	CONSTRAINT FK_Pedido_Cliente FOREIGN KEY (CodigoCliente) REFERENCES Cliente(Codigo)
)
GO

CREATE TABLE Prato(
	Codigo INT NOT NULL IDENTITY(1,1),
	Descricao VARCHAR(MAX) NOT NULL,
	CodigoPedido INT NOT NULL,
	CONSTRAINT PK_Prato PRIMARY KEY (Codigo),
	CONSTRAINT FK_Prato_Pedido FOREIGN KEY (CodigoPedido) REFERENCES Pedido(Codigo)
)
GO

CREATE TABLE Receita(
	Codigo INT NOT NULL IDENTITY(1,1),
	Descricao VARCHAR(MAX) NOT NULL,
	CodigoPrato INT NOT NULL,
	CONSTRAINT PK_Receita PRIMARY KEY (Codigo),
	CONSTRAINT FK_Receita_Prato FOREIGN KEY (CodigoPrato) REFERENCES Prato(Codigo)
)
GO

ALTER TABLE IngredientePorReceita
	ADD CONSTRAINT FK_IngredientePorReceita_Ingrediente FOREIGN KEY (CodigoIngrediente) REFERENCES Ingrediente(Codigo)
GO

ALTER TABLE IngredientePorReceita
	ADD CONSTRAINT FK_IngredientePorReceita_Receita FOREIGN KEY (CodigoReceita) REFERENCES Receita(Codigo)
GO

INSERT INTO Pedido(Descricao, CodigoCliente) VALUES
('Pedido 1', 3),
('Pedido 2', 6),
('Pedido 3', 4),
('Pedido 4', 7),
('Pedido 5', 2)
GO

INSERT INTO Prato (Descricao, CodigoPedido) VALUES
('Feijoada', 1),
('Escondidinho de Carne Seca', 3),
('Escondidinho', 2),
('Pastel de Carne Seca', 5),
('Pastel de Queijo', 4)
GO

INSERT INTO Receita (Descricao, CodigoPrato) VALUES
('Feijoada',1),
('Escondidinho de Carne Seca',2),
('Escondidinho',3),
('Pastel de Carne Seca',4),
('Pastel de Queijo',5)
GO

INSERT INTO Ingrediente (Descricao) VALUES
('Costela Suína Defumada'),
('Carne Seca'),
('Pé de Porco'),
('Rabo de Porco'),
('Lombo Suíno Defumado'),
('Feijão Preto'),
('Paio'),
('Cebola'),
('Alho'),
('Cheiro Verde'),
('Bacon'),
('Mandioca'),
('Manteiga'),
('Creme de Cebola com Bacon'),
('Leite'),
('Óleo'),
('Sal'),
('Coentro'),
('Queijo Parmesão'),
('Farinha de Trigo'),
('Vinagre Branco'),
('Azeite'),
('Queijo Mussarela')
GO
