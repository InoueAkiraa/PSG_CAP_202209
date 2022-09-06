CREATE TABLE Subcategoria(
    Codigo INT NOT NULL IDENTITY(1,1),
    CodigoCategoria INT NOT NULL,
    Descricao VARCHAR(MAX) NOT NULL,
    DataInsert DATETIME NOT NULL,
    CONSTRAINT PK_Subcategoria PRIMARY KEY (Codigo),
    CONSTRAINT FK_SubCategoria_Categoria FOREIGN KEY (CodigoCategoria) REFERENCES Categoria(Codigo)
)
GO
