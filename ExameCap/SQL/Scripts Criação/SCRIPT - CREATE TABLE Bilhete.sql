CREATE TABLE Bilhete (
	CodigoBilhete INT IDENTITY(1,1) NOT NULL,
	NumeroBilhete INT NOT NULL,
	Assento VARCHAR(50) NOT NULL,
	CONSTRAINT PK_Bilhete PRIMARY KEY (CodigoBilhete)
)
GO