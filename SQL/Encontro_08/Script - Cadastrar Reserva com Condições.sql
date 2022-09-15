DECLARE @CodigoCliente INT
DECLARE @CodigoTema INT
DECLARE @DataReserva DATETIME
DECLARE @Situacao BIT
DECLARE @NumeroDeLugares INT

SET @CodigoCliente = 5
SET @CodigoTema = 4
SET @DataReserva = CONVERT(DATETIME, '2022-09-20')
SET @Situacao = 1
SET @NumeroDeLugares = 12

DECLARE @Existe INT
SELECT @Existe = COUNT(*) 
FROM Reserva 
WHERE (Situacao = 1) 
AND (CodigoCliente = @CodigoCliente) 
AND (DataReserva = @DataReserva)

DECLARE @DataMax DATETIME
SET @DataMax = DATEADD(DAY, 15, GETDATE())

IF (@DataReserva < GETDATE())
BEGIN
	PRINT('A data de reserva não pode ser menor que a data atual.')
END
ELSE IF (@DataReserva > @DataMax)
BEGIN
	PRINT('A data de reserva ultrapassa mais de 15 dias.')
END
ELSE IF (@Existe <> 0)
BEGIN
	PRINT('Não posso realizar a reserva, pois o cliente já possui outra existente!')
END
ELSE
BEGIN
	INSERT INTO Reserva (CodigoCliente, CodigoTema, DataReserva, Situacao, NumeroDeLugares) VALUES 
	(@CodigoCliente, @CodigoTema, @DataReserva, @Situacao, @NumeroDeLugares) 
	PRINT('Reserva realizada com sucesso!')
END

GO
