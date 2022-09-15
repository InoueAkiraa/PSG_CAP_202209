DECLARE @CodigoCliente INT
DECLARE @DataReserva DATETIME
DECLARE @Situacao BIT

SET @CodigoCliente = 2
SET @DataReserva = CONVERT(DATETIME, '2022-09-20')
SET @Situacao = 1

DECLARE @Existe INT
SELECT @Existe = COUNT(*) 
FROM Reserva 
WHERE (Situacao = 1) 
AND (CodigoCliente = @CodigoCliente) 
AND (DataReserva = @DataReserva)

IF (@Existe = 0)
BEGIN
	PRINT('O cliente não possui reserva cadastrada!')
END
ELSE
BEGIN
	UPDATE Reserva 
	SET Situacao = 0
	WHERE (CodigoCliente = @CodigoCliente)
	PRINT('Reserva cancelada com sucesso!')
END
GO
