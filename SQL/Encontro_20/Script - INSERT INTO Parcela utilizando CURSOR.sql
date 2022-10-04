DECLARE @Valor DECIMAL --VALOR DE CADA PARCELA
SET @Valor = 250

DECLARE @ParcelaMax INT --VALOR MÁXIMO DAS ParcelaMax
SELECT @ParcelaMax = 10

DECLARE @ParcelasSorteadas INT --TANTO DE ParcelaMax SORTEADAS

DECLARE @ParcelaInicial INT --VALOR INICIAL DA PRIMEIRA PARCELA '1'
SET @ParcelaInicial = 1

DECLARE @ValorParcela DECIMAL

DECLARE @FuncId BIGINT --VARIAVEL PELA QUAL VAI SERVIR DE PARAMETRO PARA ParcelasSorteadas PRIMÁRIA
DECLARE CursorParcelamento CURSOR
	FOR SELECT FuncionarioId FROM Funcionario WHERE Sexo = 'F' AND Sobrenome LIKE 'MID%' --COLUNA QUE SOFRERÁ A INCREMENTAÇÃO DO CURSOR

OPEN CursorParcelamento
FETCH NEXT FROM CursorParcelamento INTO @FuncId --INCREMENTAÇÃO DO CURSOR EM CIMA DO FUNCIONÁRIO ID

WHILE(@@FETCH_STATUS = 0)
BEGIN

	SET @ParcelasSorteadas = FLOOR(RAND() * (@ParcelaMax + 1)) --SORTEIA QUANTAS ParcelaMax VAI PAGAR DENTRO DO VALOR DE 1 ATÉ 10

	WHILE(@ParcelasSorteadas = 0) -- SORTEIA ATÉ SAIR UMA PARCELA DIFERENTE DE 0
	BEGIN
		SET @ParcelasSorteadas = FLOOR(RAND() * (@ParcelaMax + 1)) 
	END

	WHILE(@ParcelaInicial < @ParcelasSorteadas + 1) --ENQUANTO A QNT INICIAL DE PARCELA FOR MENOR QUE A QUANTIA SORTEADA, REALIZARÁ O INSERT
	BEGIN
		SET @ValorParcela = (@Valor * @ParcelaInicial)

		INSERT INTO Parcela(FuncionarioId, ParcelaNumero, Valor)
			SELECT FuncionarioId, 
			@ParcelaInicial,
			@ValorParcela
			FROM Funcionario
			WHERE (FuncionarioId = @FuncId)

		SET @ParcelaInicial = @ParcelaInicial + 1 --INCREMENTAÇÃO DA QNT DE PARCELA ATÉ CHEGAR NA QUANTIDADE SORTEADA
	END
  
	SET @ParcelasSorteadas = 0 --SAIU DO CICLO, É NECESSÁRIO RESETAR OS VALORES PARA ENTRAR NOVAMENTE NO WHILE
	SET @ParcelaInicial = 1
	FETCH NEXT FROM CursorParcelamento INTO @FuncId --PASSA PARA O PRÓXIMO REGISTRO
	
END

CLOSE CursorParcelamento
DEALLOCATE CursorParcelamento
SELECT * FROM Parcela
GO
