INSERT INTO Atendimento (CodigoTipoAtendimento, SiglaTipoAtendimento, CodigoAtendente, CodigoPaciente, CodigoMedico, CodigoEnfermeiro,
	CodigoConvenio, Descricao, DataHora) VALUES
(1, 'H', 5, NULL, NULL, NULL, 5, 'Realizar Hemograma', '2023-10-25'),
(2, 'R', 6, NULL, NULL, NULL, 2, 'Realizar Raio-x', '2023-10-22'),
(3, 'U', NULL, 7, NULL, NULL, 3, 'Realizar Ultrassom', '2023-09-25'),
(4, 'G', NULL, 8, NULL, NULL, 1, 'Realizar exame de Glicose', '2023-09-22'),
(5, 'A', NULL, 9, NULL, NULL, 4, 'Realizar Amamnese', '2023-08-15'),
(6, 'M', NULL, 10, NULL, NULL, 9, 'Realizar exame de Mucosas', '2023-08-25'),
(7, 'L', NULL, NULL, 1, NULL, 8, 'Realizar vistoria de Linfonodos', '2023-07-15'),
(8, 'C', NULL, NULL, 2, NULL, 10, 'Realizar inspeção Coproparasitológico', '2023-07-25'),
(9, 'F', NULL, NULL, NULL, 4, 6, 'Realizar Exame de Fezes', '2023-04-15'),
(10, 'D', NULL, NULL, NULL, 3, 7, 'Realizar exame de Diabetes', '2023-03-12')
GO