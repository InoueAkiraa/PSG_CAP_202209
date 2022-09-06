CREATE TABLE Produto(
    Codigo INT NOT NULL IDENTITY(1,1),
    CodigoSubcategoria INT NOT NULL,
    CodigoCategoria INT NOT NULL,
    Descricao VARCHAR(MAX) NOT NULL,
    DataInsert DATETIME NOT NULL,
    CONSTRAINT PK_Produto PRIMARY KEY (Codigo),
    CONSTRAINT FK_Produto_Subcategoria FOREIGN KEY (CodigoSubcategoria) REFERENCES Subcategoria(Codigo)
)
GO
