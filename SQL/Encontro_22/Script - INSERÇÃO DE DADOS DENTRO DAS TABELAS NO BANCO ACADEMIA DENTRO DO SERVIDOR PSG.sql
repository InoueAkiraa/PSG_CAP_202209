USE [ACADEMIA]
GO
SET IDENTITY_INSERT [EST].[Categoria] ON 
GO
INSERT [EST].[Categoria] ([Codigo], [Descricao], [DataInsert]) VALUES 
(1, N'Alimento Infantil', CAST(N'2022-09-09T14:03:21.140' AS DateTime)),
(2, N'Suplementos', CAST(N'2022-09-09T14:03:21.140' AS DateTime)),
(3, N'Bebidas', CAST(N'2022-09-09T14:03:21.140' AS DateTime)),
(4, N'Biscoitos, Bolos e Bolachas', CAST(N'2022-09-09T14:03:21.140' AS DateTime)),
(5, N'Carnes', CAST(N'2022-09-09T14:03:21.140' AS DateTime)),
(6, N'Congelados', CAST(N'2022-09-09T14:03:21.140' AS DateTime)),
(7, N'Conservas', CAST(N'2022-09-09T14:03:21.140' AS DateTime)),
(8, N'Doces, Balas, Chocolates e Cia', CAST(N'2022-09-09T14:03:21.140' AS DateTime)),
(9, N'Farinhas, Cereais e Complementos', CAST(N'2022-09-09T14:03:21.140' AS DateTime)),
(10, N'Fast-Food, Aperitivos e Petiscos', CAST(N'2022-09-09T14:03:21.140' AS DateTime)),
(11, N'Frios e Embutidos', CAST(N'2022-09-09T14:03:21.140' AS DateTime)),
(12, N'Frutas', CAST(N'2022-09-09T14:03:21.140' AS DateTime)),
(13, N'Legumes, Verduras e Grãos', CAST(N'2022-09-09T14:03:21.140' AS DateTime)),
(14, N'Massas', CAST(N'2022-09-09T14:03:21.140' AS DateTime)),
(15, N'Molhos, Caldos e Condimentos', CAST(N'2022-09-09T14:03:21.140' AS DateTime)),
(16, N'Ovos, Leite, Queijo e Cia', CAST(N'2022-09-09T14:03:21.140' AS DateTime)),
(17, N'Pães', CAST(N'2022-09-09T14:03:21.140' AS DateTime)),
(18, N'Sopas & Cremes', CAST(N'2022-09-09T14:03:21.140' AS DateTime)),
(19, N'Diversos', CAST(N'2022-09-09T14:03:21.140' AS DateTime))
GO

SET IDENTITY_INSERT [EST].[Categoria] OFF
GO

SET IDENTITY_INSERT [EST].[Subcategoria] ON 
GO
INSERT [EST].[Subcategoria] ([Codigo], [CodigoCategoria], [Descricao], [DataInsert]) VALUES 
(1, 1, N'Papinha', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(2, 1, N'Sopinha', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(3, 2, N'Proteína', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(4, 2, N'Carboidratos', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(5, 2, N'Vitaminas', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(6, 2, N'Hipercalóricos', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(7, 2, N'Óxido Nítrico', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(8, 2, N'Aminoácidos', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(9, 2, N'Propriedade Funcional', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(10, 3, N'Achocolatados', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(11, 3, N'Bebidas a Base de Soja', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(12, 3, N'Bebidas Alcoólicas', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(13, 3, N'Café e Cia', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(14, 3, N'Chás', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(15, 3, N'Isotônicos e Energéticos', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(16, 3, N'Refrescos em Pó', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(17, 3, N'Refrigerantes', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(18, 3, N'Sucos Concentrados', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(19, 3, N'Sucos de Frutas Prontos', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(20, 3, N'Sucos Naturais', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(21, 3, N'Sucos Orgânicos', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(22, 4, N'Biscoitos e Bolachas', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(23, 4, N'Bolos Caseiros', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(24, 4, N'Bolos Prontos', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(25, 4, N'Misturas para Bolos', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(26, 5, N'Aves (Frango, Peru, etc)', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(27, 5, N'Boi', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(28, 5, N'Frutos do Mar', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(29, 5, N'Hamburguers', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(30, 5, N'Outras Carnes', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(31, 5, N'Peixes', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(32, 5, N'Porco', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(33, 5, N'Vitela', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(34, 6, N'Empanados', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(35, 6, N'Hamburguers', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(36, 6, N'Legumes & Cia Congelados', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(37, 6, N'Pizzas Congeladas', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(38, 6, N'Polpas de Frutas Congeladas', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(39, 6, N'Pratos Prontos Congelados', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(40, 6, N'Salgados Congelados', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(41, 7, N'Conservas em Geral', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(42, 8, N'Adoçantes', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(43, 8, N'Balas', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(44, 8, N'Chicletes', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(45, 8, N'Chocolates', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(46, 8, N'Doces de Frutas', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(47, 8, N'Doces Diversos', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(48, 8, N'Gelatinas', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(49, 8, N'Geléias', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(50, 8, N'Ingredientes Doces', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(51, 8, N'Mel e Xaropes', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(52, 8, N'Sobremesas em Pó', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(53, 8, N'Sobremesas Lácteas', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(54, 8, N'Sorvetes', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(55, 8, N'Tortas', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(56, 9, N'Cereal Matinal', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(57, 9, N'Farinhas e Cereais Diversos', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(58, 9, N'Mingau e Cia', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(59, 10, N'Amendoim e Etc', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(60, 10, N'Batata Frita', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(61, 10, N'Bobs', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(62, 10, N'Casa da Empada', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(63, 10, N'Habibs', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(64, 10, N'Mc Donalds', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(65, 10, N'Pastas & Patês', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(66, 10, N'Petiscos Diversos', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(67, 10, N'Pipoca', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(68, 10, N'Pizzas Congeladas', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(69, 10, N'Rei do Mate', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(70, 10, N'Salgadinhos & Snacks', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(71, 11, N'Frios e Embutidos em Geral', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(72, 12, N'Doces de Frutas', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(73, 12, N'Frutas Diversas', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(74, 12, N'Frutas Secas e em Calda', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(75, 12, N'Polpas de Frutas Congeladas', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(76, 12, N'Sucos Concentrados', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(77, 12, N'Sucos de Frutas Prontos', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(78, 12, N'Sucos Naturais', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(79, 12, N'Sucos Orgânicos', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(80, 13, N'Legumes & Cia Congelados', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(81, 13, N'Legumes e Cia Naturais', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(82, 14, N'Massas em Geral', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(83, 15, N'Caldos', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(84, 15, N'Catchup & Mostarda', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(85, 15, N'Maionese', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(86, 15, N'Molhos', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(87, 15, N'Outros Condimentos', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(88, 16, N'Iogurtes', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(89, 16, N'Leite', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(90, 16, N'Milkshakes', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(91, 16, N'Ovos', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(92, 16, N'Queijos', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),

(93, 16, N'Sobremesas Lácteas', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),
(94, 17, N'Pães em Geral', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),
(95, 18, N'Sopas em Geral', CAST(N'2022-09-09T14:03:47.103' AS DateTime)),
(96, 19, N'Diversos sem Categoria', CAST(N'2022-09-09T14:03:47.103' AS DateTime))
GO

SET IDENTITY_INSERT [EST].[Subcategoria] OFF
GO

SET IDENTITY_INSERT [Geral].[Cliente] ON 
GO
INSERT [Geral].[Cliente] ([Codigo], [Nome], [RazaoSocial], [NomeFantasia], [Documento], [Telefone], [Email], [TipoPessoa], [Endereco], [Ativo], [DataInclusao], [DataAlteracao], [DataExclusao]) VALUES 
(1, N'Akira', NULL, NULL, N'705.443.621-01', N'123', N'akira@teste.com', N'F', N'Rua X, n. 10', 1, CAST(N'2022-09-08T16:26:05.013' AS DateTime), NULL, NULL),

(2, N'Lucas', NULL, NULL, N'456', N'99087654321', N'lucas@teste.com', N'F', N'Rua X, n. 11', 1, CAST(N'2022-09-08T16:37:03.577' AS DateTime), NULL, NULL),

(3, N'João', NULL, NULL, N'789', N'98732165475', N'joao@teste.com', N'F', N'Rua X, n. 12', 1, CAST(N'2022-09-08T16:37:03.577' AS DateTime), NULL, NULL),

(4, N'Pedro', NULL, NULL, N'987', N'98732198757', N'pedro@teste.com', N'F', N'Rua X, n. 13', 1, CAST(N'2022-09-08T16:37:03.577' AS DateTime), NULL, NULL),

(5, N'Tiago', NULL, NULL, N'741', N'98798798754', N'tiago@teste.com', N'F', N'Rua X, n. 14', 1, CAST(N'2022-09-08T16:37:03.577' AS DateTime), NULL, NULL),

(6, N'Judas', NULL, NULL, N'258', N'96338527412', N'judas@teste.com', N'F', N'Rua X, n. 15', 0, CAST(N'2022-09-08T16:37:03.577' AS DateTime), CAST(N'2022-09-08T16:42:02.097' AS DateTime), NULL),

(7, N'Marcos', NULL, NULL, N'159', N'912378546', N'marcos@teste.com', N'F', N'Rua X, n. 16', 1, CAST(N'2022-09-08T16:37:03.577' AS DateTime), NULL, NULL),

(8, N'André', NULL, NULL, N'761', N'91232165485', N'andre@teste.com', N'F', N'Rua X, n. 17', 1, CAST(N'2022-09-08T16:37:03.577' AS DateTime), NULL, NULL),

(9, N'Barrabas', NULL, NULL, N'123', N'987654321', N'barrabas@teste.com', N'F', N'Rua X, n. 10', 1, CAST(N'2022-09-08T16:46:38.573' AS DateTime), CAST(N'2022-09-08T16:59:06.187' AS DateTime), NULL)
GO

SET IDENTITY_INSERT [Geral].[Cliente] OFF
GO

SET IDENTITY_INSERT [RH].[Departamento] ON 
GO
INSERT [RH].[Departamento] ([DepartamentoId], [Descricao], [DataInsert]) VALUES 
(1, N'Customer Service', CAST(N'2022-09-29T14:38:37.553' AS DateTime)),
(2, N'Development', CAST(N'2022-09-29T14:38:37.553' AS DateTime)),
(3, N'Finance', CAST(N'2022-09-29T14:38:37.553' AS DateTime)),
(4, N'Human Resources', CAST(N'2022-09-29T14:38:37.553' AS DateTime)),
(5, N'Marketing', CAST(N'2022-09-29T14:38:37.553' AS DateTime)),
(6, N'Production', CAST(N'2022-09-29T14:38:37.553' AS DateTime)),
(7, N'Quality Management', CAST(N'2022-09-29T14:38:37.553' AS DateTime)),
(8, N'Research', CAST(N'2022-09-29T14:38:37.553' AS DateTime)),
(9, N'Sales', CAST(N'2022-09-29T14:38:37.553' AS DateTime))
GO

SET IDENTITY_INSERT [RH].[Departamento] OFF
GO

INSERT [Geral].[Estado] ([CodigoUF], [SiglaUF], [DescricaoUF]) VALUES 
(1, N'RO', N'RONDÔNIA'),
(2, N'AC', N'ACRE'),
(3, N'AM', N'AMAZONAS'),
(4, N'RR', N'RORAIMA'),
(5, N'PA', N'PARÁ'),
(6, N'AP', N'AMAPÁ'),
(7, N'TO', N'TOCANTINS'),
(8, N'MA', N'MARANHÃO'),
(9, N'PI', N'PIAUÍ'),
(10, N'CE', N'CEARÁ'),
(11, N'RN', N'RIO GRANDE DO NORTE'),
(12, N'PB', N'PARAÍBA'),
(13, N'PE', N'PERNAMBUCO'),
(14, N'AL', N'ALAGOAS'),
(15, N'SE', N'SERGIPE'),
(16, N'BA', N'BAHIA'),
(17, N'MG', N'MINAS GERAIS'),
(18, N'ES', N'ESPÍRITO SANTO'),
(19, N'RJ', N'RIO DE JANEIRO'),
(20, N'SP', N'SÃO PAULO'),
(21, N'PR', N'PARANÁ'),
(22, N'SC', N'SANTA CATARINA'),
(23, N'RS', N'RIO GRANDE DO SUL'),
(24, N'MS', N'MATO GROSSO DO SUL'),
(25, N'MT', N'MATO GROSSO'),
(26, N'GO', N'GOIÁS'),
(27, N'DF', N'DISTRITO FEDERAL')
GO

SET IDENTITY_INSERT [Geral].[InstituicaoBancaria] ON 
GO
INSERT [Geral].[InstituicaoBancaria] ([InstituicaoBancariaID], [CodigoBanco], [Descricao], [SiteWWW], [DataInsert]) VALUES 
(1, 246, N'BancoABCBrasilS.A.', N'http://www.abcbrasil.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(2, 356, N'BancoABNAMRORealS.A.', N'http://www.abnamro.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(3, 25, N'BancoAlfaS.A.', N'http://www.bancoalfa.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(4, 641, N'BancoAlvoradaS.A.', N'Nãopossuisite', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(5, NULL, N'BancoAmericanExpressS.A.', N'http://www.aexp.com/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(6, 29, N'BancoBanerjS.A.', N'http://www.banerj.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(7, 38, N'BancoBanestadoS.A.', N'http://www.banestado.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(8, 740, N'BancoBarclaysS.A.', N'http://www.barclays.com/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(9, 107, N'BancoBBMS.A.', N'http://www.bbmbank.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(10, 31, N'BancoBegS.A.', N'http://www.itau.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(11, 36, N'BancoBemS.A.', N'Nãopossuisite', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(12, 394, N'BancoBMCS.A.', N'http://www.bmc.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(13, 318, N'BancoBMGS.A.', N'http://www.bancobmg.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(14, 752, N'BancoBNPParibasBrasilS.A.', N'http://www.bnpparibas.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(15, 248, N'BancoBoavistaInteratlânticoS.A.', N'nãopossuisite', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(16, 237, N'BancoBradescoS.A.', N'http://www.bradesco.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(17, 225, N'BancoBrascanS.A.', N'http://www.bancobrascan.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(18, 263, N'BancoCaciqueS.A.', N'http://www.bancocacique.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(19, 222, N'BancoCalyonBrasilS.A.', N'http://www.calyon.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(20, 40, N'BancoCargillS.A.', N'http://www.bancocargill.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(21, 745, N'BancoCitibankS.A.', N'http://www.citibank.com/brasil', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(22, 215, N'BancoComercialedeInvestimentoSudamerisS.A.', N'Nãopossuisite', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(23, 756, N'BancoCooperativodoBrasilS.A.-BANCOOB', N'http://www.bancoob.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(24, 748, N'BancoCooperativoSicrediS.A.-BANSICREDI', N'http://www.bansicredi.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(25, 505, N'BancoCreditSuisse(Brasil)S.A.', N'http://www.csfb.com/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(26, 229, N'BancoCruzeirodoSulS.A.', N'http://www.bcsul.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(27, 3, N'BancodaAmazôniaS.A.', N'http://www.bancoamazonia.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(28, 707, N'BancoDaycovalS.A.', N'http://www.daycoval.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(29, NULL, N'BancodeLageLandenBrasilS.A.', N'http://www.delagelanden.com/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(30, 24, N'BancodePernambucoS.A.-BANDEPE', N'http://www.bandepe.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(31, 456, N'BancodeTokyo-MitsubishiBrasilS.A.', N'http://www.btm.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(32, 214, N'BancoDibensS.A.', N'http://www.bancodibens.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(33, 1, N'BancodoBrasilS.A.', N'http://www.bb.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(34, 27, N'BancodoEstadodeSantaCatarinaS.A.', N'http://www.besc.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(35, 33, N'BancodoEstadodeSãoPauloS.A.-Banespa', N'http://www.banespa.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(36, 47, N'BancodoEstadodeSergipeS.A.', N'http://www.banese.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(37, 37, N'BancodoEstadodoParáS.A.', N'http://www.banparanet.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(38, 41, N'BancodoEstadodoRioGrandedoSulS.A.', N'http://www.banrisul.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(39, 4, N'BancodoNordestedoBrasilS.A.', N'http://www.banconordeste.gov.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(40, 265, N'BancoFatorS.A.', N'http://www.bancofator.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(41, NULL, N'BancoFiatS.A.', N'http://www.bancofiat.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(42, 224, N'BancoFibraS.A.', N'http://www.bancofibra.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(43, 175, N'BancoFinasaS.A.', N'nãopossuisite', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(44, 252, N'BancoFininvestS.A.', N'http://www.fininvest.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(45, 233, N'BancoGECapitalS.A.', N'http://www.bancoge.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(46, NULL, N'BancoGeneralMotorsS.A.', N'http://www.bancogm.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(47, 734, N'BancoGerdauS.A.', N'http://www.bancogerdau.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(48, 612, N'BancoGuanabaraS.A.', N'nãopossuisite', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(49, 63, N'BancoIbiS.A.BancoMúltiplo', N'Nãopossuisite', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(50, 604, N'BancoIndustrialdoBrasilS.A.', N'http://www.bancoindustrial.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(51, 320, N'BancoIndustrialeComercialS.A.', N'http://www.bicbanco.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(52, 653, N'BancoIndusvalS.A.', N'http://www.indusval.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(53, 630, N'BancoIntercapS.A.', N'http://www.intercap.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(54, 249, N'BancoInvestcredUnibancoS.A.', N'Nãopossuisite', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(55, 48, N'BancoItaúBBAS.A.', N'http://www.itaubba.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(56, 652, N'BancoItaúHoldingFinanceiraS.A.', N'http://www.itau.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(57, 341, N'BancoItaúS.A.', N'http://www.itau.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(58, NULL, N'BancoItaucredFinanciamentosS.A.', N'http://www.itaucred.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(59, NULL, N'BancoItausagaS.A.', N'http://www.itau.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(60, 376, N'BancoJ.P.MorganS.A.', N'http://www.jpmorgan.com/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(61, 74, N'BancoJ.SafraS.A.', N'http://www.jsafra.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(62, 757, N'BancoKEBdoBrasilS.A.', N'nãopossuisite', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(63, 600, N'BancoLusoBrasileiroS.A.', N'http://www.lusobrasileiro.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(64, 392, N'BancoMercantildeSãoPauloS.A.', N'nãopossuisite', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(65, 389, N'BancoMercantildoBrasilS.A.', N'http://www.mercantil.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(66, 755, N'BancoMerrillLynchdeInvestimentosS.A.', N'http://www.ml.com/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(67, 151, N'BancoNossaCaixaS.A.', N'http://www.nossacaixa.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(68, 45, N'BancoOpportunityS.A.', N'http://www.opportunity.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(69, 208, N'BancoPactualS.A.', N'http://www.pactual.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(70, 623, N'BancoPanamericanoS.A.', N'http://www.panamericano.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(71, 611, N'BancoPaulistaS.A.', N'http://www.bancopaulista.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(72, 643, N'BancoPineS.A.', N'http://www.bancopine.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(73, 638, N'BancoProsperS.A.', N'http://www.bancoprosper.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(74, 747, N'BancoRabobankInternationalBrasilS.A.', N'http://www.rabobank.com/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(75, 633, N'BancoRendimentoS.A.', N'http://www.rendimento.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(76, 72, N'BancoRuralMaisS.A.', N'http://www.rural.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(77, 453, N'BancoRuralS.A.', N'http://www.rural.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(78, 422, N'BancoSafraS.A.', N'http://www.safra.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(79, 353, N'BancoSantanderBrasilS.A.', N'http://www.santander.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(80, 8, N'BancoSantanderMeridionalS.A.', N'http://www.meridional.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(81, 351, N'BancoSantanderS.A.', N'http://www.santander.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(82, 250, N'BancoSchahinS.A.', N'http://www.bancoschahin.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(83, 749, N'BancoSimplesS.A.', N'http://www.bancosimples.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(84, 366, N'BancoSociétéGénéraleBrasilS.A.', N'http://www.sgbrasil.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(85, 637, N'BancoSofisaS.A.', N'http://www.sofisa.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(86, 347, N'BancoSudamerisBrasilS.A.', N'http://www.sudameris.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(87, 464, N'BancoSumitomoMitsuiBrasileiroS.A.', N'http://não%20possue%20site/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(88, 634, N'BancoTriânguloS.A.', N'http://www.tribanco.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(89, 247, N'BancoUBSS.A.', N'http://www.ubsw.com/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(90, 116, N'BancoÚnicoS.A.', N'http://www.unibanco.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(91, 655, N'BancoVotorantimS.A.', N'http://www.bancovotorantim.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(92, 610, N'BancoVRS.A.', N'http://www.vr.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(93, 370, N'BancoWestLBdoBrasilS.A.', N'http://www.westlb.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(94, 21, N'BANESTESS.A.BancodoEstadodoEspíritoSanto', N'http://www.banestes.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(95, 719, N'Banif-BancoInternacionaldoFunchal(Brasil)S.A.', N'http://www.banif.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(96, 479, N'BankBostonBancoMúltiploS.A.', N'http://www.bankboston.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(97, 744, N'BankBostonN.A.', N'http://www.bankboston.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(98, NULL, N'BBBancoPopulardoBrasilS.A.', N'http://www.bancopopulardobrasil.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(99, NULL, N'BESInvestimentodoBrasilS.A.-BancodeInvestimento', N'http://www.besinvestimento.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(100, 70, N'BRB-BancodeBrasíliaS.A.', N'http://www.brb.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(101, 104, N'CaixaEconômicaFederal', N'http://www.caixa.gov.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(102, 477, N'CitibankN.A.', N'http://www.citibank.com/brasil', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(103, NULL, N'CredicardBancoS.A.', N'Nãopossuisite', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(104, 487, N'DeutscheBankS.A.-BancoAlemão', N'http://www.deutsche-bank.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(105, 751, N'DresdnerBankBrasilS.A.-BancoMúltiplo', N'http://www.drkw.net/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(106, 210, N'DresdnerBankLateinamerikaAktiengesellschaft', N'http://www.dbla.com/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(107, 62, N'HipercardBancoMúltiploS.A.', N'http://www.banco1.net/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(108, 399, N'HSBCBankBrasilS.A.-BancoMúltiplo', N'http://www.hsbc.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(109, 492, N'INGBankN.V.', N'http://www.ing.com/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(110, 488, N'JPMorganChaseBank', N'http://www.jpmorganchase.com/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(111, 65, N'LemonBankBancoMúltiploS.A.', N'http://www.lemon.com/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(112, 409, N'UNIBANCO-UniãodeBancosBrasileirosS.A.', N'http://www.unibanco.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(113, 230, N'UnicardBancoMúltiploS.A.', N'http://www.unicard.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(117, 654, N'BancoA.J.RennerS.A.', N'http://www.bancorenner.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(118, 213, N'BancoArbiS.A.', N'http://www.arbi.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(119, 739, N'BancoBGNS.A.', N'http://www.bgn.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(120, 96, N'BancoBM&FdeServiçosdeLiquidaçãoeCustódiaS.A', N'http://www.bmf.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(121, 218, N'BancoBonsucessoS.A.', N'http://www.bancobonsucesso.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(122, NULL, N'BancoBRJS.A.', N'http://www.brjbank.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(123, 44, N'BancoBVAS.A.', N'http://www.bancobva.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(124, 412, N'BancoCapitalS.A.', N'http://www.bancocapital.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(125, 266, N'BancoCédulaS.A.', N'http://www.bancocedula.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(126, 241, N'BancoClássicoS.A.', N'Nãopossuisite', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(127, NULL, N'BancoCNHCapitalS.A.', N'http://www.bancocnh.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(128, 753, N'BancoComercialUruguaiS.A.', N'http://www.bancocomercial.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(129, 75, N'BancoCR2S.A.', N'Nãopossuisite', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(130, 721, N'BancoCredibelS.A.', N'http://www.credibel.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(131, NULL, N'BancoDaimlerchryslerS.A.', N'http://www.bancodaimlerchrysler.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(132, 300, N'BancodeLaNacionArgentina', N'http://www.bna.com.ar/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(133, 495, N'BancodeLaProvinciadeBuenosAires', N'http://www.bapro.com.ar/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(134, 494, N'BancodeLaRepublicaOrientaldelUruguay', N'Nãopossuisite', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(135, 35, N'BancodoEstadodoCearáS.A.-BEC', N'http://www.bec.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(136, 39, N'BancodoEstadodoPiauíS.A.-BEP', N'http://www.bep.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(137, 743, N'BancoEmblemaS.A.', N'http://www.bancoemblema.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(138, 626, N'BancoFicsaS.A.', N'http://www.ficsa.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(139, NULL, N'BancoFordS.A.', N'http://www.bancoford.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(140, NULL, N'BancoHondaS.A.', N'http://www.bancohonda.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(141, NULL, N'BancoIBMS.A.', N'http://www.ibm.com/br/financing/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(142, 217, N'BancoJohnDeereS.A.', N'http://www.johndeere.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(143, 212, N'BancoMatoneS.A.', N'http://www.bancomatone.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(144, 243, N'BancoMáximaS.A.', N'http://www.bancomaxima.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(145, NULL, N'BancoMaxinvestS.A.', N'Nãopossuisite', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(146, 746, N'BancoModalS.A.', N'http://www.bancomodal.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(147, NULL, N'BancoMoneoS.A.', N'Nãopossuisite', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(148, 738, N'BancoMoradaS.A.', N'http://www.bancomorada.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(149, 66, N'BancoMorganStanleyDeanWitterS.A.', N'http://www.morganstanley.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(150, NULL, N'BancoOurinvestS.A.', N'http://www.ourinvest.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(151, 613, N'BancoPecúniaS.A.', N'http://www.bancopecunia.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(152, 724, N'BancoPortoSeguroS.A.', N'Nãopossuisite', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(153, 735, N'BancoPottencialS.A.', N'http://www.pottencial.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(154, NULL, N'BancoPSAFinanceBrasilS.A.', N'Nãopossuisite', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(155, 741, N'BancoRibeirãoPretoS.A.', N'http://www.brp.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(156, NULL, N'BancoRodobensS.A.', N'http://www.rodobens.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(157, NULL, N'BancoToyotadoBrasilS.A.', N'http://www.bancotoyota.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(158, NULL, N'BancoTricuryS.A.', N'http://www.tricury.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(159, NULL, N'BancoVolkswagenS.A.', N'http://www.bancovw.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(160, NULL, N'BancoVolvo(Brasil)S.A.', N'Nãopossuisite', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(161, NULL, N'BPNBrasilBancoMútiploS.A.', N'Nãopossuisite', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(162, 64, N'GoldmanSachsdoBrasilBancoMúltiploS.A.', N'http://www.goldmansachs.com/', CAST(N'2022-09-28T17:27:26.070' AS DateTime)),

(163, 254, N'ParanáBancoS.A.', N'http://www.paranabanco.com.br/', CAST(N'2022-09-28T17:27:26.070' AS DateTime))
GO

SET IDENTITY_INSERT [Geral].[InstituicaoBancaria] OFF
GO


SET IDENTITY_INSERT [Geral].[Pais] ON 
GO
INSERT [Geral].[Pais] ([PaisID], [Sigla], [CodigoIdioma], [Descricao], [DataInsert]) VALUES 
(1, N'AFG', N'PS', N'Afeganistão', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(2, N'AFS', N'EN', N'África do Sul', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(3, N'AHL', N'NL', N'Antilhas Holandesas', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(4, N'ALB', N'SQ', N'Albânia', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(5, N'ANB', N'EN', N'Antigua', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(6, N'AND', N'CA', N'Andorra', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(7, N'ANG', N'PT', N'Angola', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(8, N'ARA', N'AR', N'Arábia Saudita', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(9, N'ARG', N'ES', N'Argentina', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(10, N'ARL', N'ES', N'Argélia', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(11, N'ARM', N'RU', N'Armênia', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(12, N'ASM', N'EN', N'Samoa Americana', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(13, N'ATC', N'EN', N'Antartida', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(14, N'AUS', N'EN', N'Austrália', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(15, N'AUT', N'DE', N'Austria', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(16, N'AZE', N'RU', N'Azerbaijão', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(17, N'BAR', N'AR', N'Barein', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(18, N'BEA', N'RU', N'Belarus', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(19, N'BEL', N'FR', N'Bélgica', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(20, N'BEN', N'EN', N'Benin', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(21, N'BER', N'EN', N'Bermudas', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(22, N'BGD', N'BN', N'Bangladesh', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(23, N'BHS', N'EN', N'Bahamas', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(24, N'BIR', N'BM', N'Birmânia', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(25, N'BKF', N'FR', N'Burkina Fasso', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(26, N'BLZ', N'EN', N'Belize', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(27, N'BOL', N'ES', N'Bolívia', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(28, N'BOS', N'EN', N'Bósnia', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(29, N'BOT', N'EN', N'Botsuana', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(30, N'BRA', N'PT', N'Brasil', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(31, N'BRB', N'EN', N'Barbados', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(32, N'BRN', N'MS', N'Brunei', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(33, N'BUL', N'BG', N'Bulgária', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(34, N'BUR', N'FR', N'Burundi', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(35, N'BUT', N'DZ', N'Butão', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(36, N'CAM', N'EN', N'Camarões', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(37, N'CAN', N'EN', N'Canadá', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(38, N'CAT', N'AR', N'Catar', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(39, N'CAZ', N'RU', N'Cazaquistão', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(40, N'CBJ', N'KM', N'Camboja', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(41, N'CBV', N'PT', N'Cabo Verde', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(42, N'CCK', N'EN', N'Ilhas Cocos', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(43, N'CHA', N'FR', N'Chade', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(44, N'CHL', N'ES', N'Chile', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(45, N'CHN', N'ZH', N'China', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(46, N'CHP', N'EL', N'Chipre', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(47, N'CIN', N'EN', N'Cingapura', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(48, N'CMF', N'FR', N'Costa do Marfim', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(49, N'COK', N'EN', N'Ilhas Cook', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(50, N'COL', N'EN', N'Colômbia', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(51, N'COM', N'EN', N'Comores', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(52, N'CON', N'FR', N'Congo', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(53, N'CRC', N'ES', N'Costa Rica', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(54, N'CRN', N'KO', N'Coréia do Norte', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(55, N'CRO', N'EN', N'Croácia', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(56, N'CRS', N'KO', N'Coréia do Sul', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(57, N'CUB', N'ES', N'Cuba', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(58, N'CXR', N'EN', N'Christmas Island', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(59, N'CYM', N'EN', N'Ilhas Cayman', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(60, N'DIN', N'DA', N'Dinamarca', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(61, N'DJI', N'EN', N'Djibuti', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(62, N'DOM', N'ES', N'República Dominicana', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(63, N'DON', N'EN', N'Dominica', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(64, N'EAU', N'AR', N'Emirados Árabes', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(65, N'EGI', N'AR', N'Egito', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(66, N'ELS', N'ES', N'El Salvador', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(67, N'EQU', N'ES', N'Equador', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(68, N'ERT', N'AR', N'Eritréa', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(69, N'ESC', N'EN', N'Escócia', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(70, N'ESH', N'EN', N'Western Sahara', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(71, N'ESP', N'ES', N'Espanha', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(72, N'EST', N'RU', N'Estônia', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(73, N'ETP', N'AM', N'Etiópia', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(74, N'EUA', N'EN', N'Estados Unidos', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(75, N'FIL', N'FL', N'Filipinas', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(76, N'FIN', N'EN', N'Finlândia', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(77, N'FJI', N'EN', N'Fiji', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(78, N'FLK', N'EN', N'Ilhas Falkland', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(79, N'FOR', N'ZH', N'Formosa', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(80, N'FRA', N'FR', N'França', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(81, N'FSM', N'EN', N'Micronésia', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(82, N'GAB', N'FR', N'Gabão', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(83, N'GAL', N'EN', N'Gales', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(84, N'GAM', N'EN', N'Gâmbia', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(85, N'GAN', N'EN', N'Gana', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(86, N'GBR', N'EN', N'Grã-Bretanha', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(87, N'GDL', N'FR', N'Guadalupe', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(88, N'GEO', N'RU', N'Geórgia', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(89, N'GFR', N'FR', N'Guiana Francesa', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(90, N'GIB', N'EN', N'Gibraltar', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(91, N'GNB', N'PT', N'Guiné Bissau', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(92, N'GNE', N'ES', N'Guiné', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(93, N'GNQ', N'EN', N'Guiné Equatorial', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(94, N'GRD', N'EN', N'Granada', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(95, N'GRE', N'EL', N'Grécia', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(96, N'GRL', N'EN', N'Groênlandia', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(97, N'GUA', N'ES', N'Guatemala', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(98, N'GUI', N'EN', N'Guiana', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(99, N'GUM', N'EN', N'Guam', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(100, N'HKG', N'EN', N'Hong Kong', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(101, N'HOL', N'NL', N'Holanda', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(102, N'HON', N'ES', N'Honduras', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(103, N'HTI', N'FR', N'Haiti', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(104, N'HUN', N'HU', N'Hungria', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(105, N'IDN', N'IN', N'Indonésia', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(106, N'IEM', N'AR', N'Iêmem', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(107, N'IFA', N'DA', N'Ilhas Faroe', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(108, N'IMH', N'EN', N'Ilhas Marshall', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(109, N'IMS', N'AR', N'Iêmen do Sul', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(110, N'IND', N'HI', N'Índia', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(111, N'ING', N'EN', N'Inglaterra', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(112, N'IOT', N'EN', N'Britsh Indian Ocean', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(113, N'IRA', N'FA', N'Irã', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(114, N'IRL', N'EN', N'Irlanda', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(115, N'IRN', N'EN', N'Irlanda do Norte', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(116, N'IRQ', N'AR', N'Iraque', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(117, N'ISL', N'IS', N'Islândia', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(118, N'ISR', N'IW', N'Israel', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(119, N'ITA', N'IT', N'Itália', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(120, N'IUG', N'SH', N'Iugoslávia', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(121, N'IVA', N'EN', N'Ilhas Vírgens EUA', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(122, N'JAM', N'EN', N'Jamaica', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(123, N'JAP', N'JA', N'Japão', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(124, N'JOR', N'AR', N'Jordânia', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(125, N'KIR', N'EN', N'Kiribati', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(126, N'KNA', N'EN', N'São Cristóvão Nevis', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(127, N'KWT', N'AR', N'Kuweit', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(128, N'LAO', N'LO', N'Laos', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(129, N'LBN', N'AR', N'Líbano', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(130, N'LBR', N'EN', N'Libéria', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(131, N'LCA', N'EN', N'Santa Lúcia', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(132, N'LES', N'EN', N'Lesoto', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(133, N'LET', N'RU', N'Letônia', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(134, N'LIB', N'AR', N'Líbia', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(135, N'LIE', N'DE', N'Liechtenstein', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(136, N'LIT', N'RU', N'Lituânia', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(137, N'LUX', N'FR', N'Luxemburgo', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(138, N'MAC', N'PT', N'Macau', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(139, N'MAD', N'FR', N'Madagascar', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(140, N'MAL', N'MS', N'Malásia', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(141, N'MAR', N'AR', N'Marrocos', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(142, N'MAU', N'EN', N'Maurício', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(143, N'MBQ', N'PT', N'Moçambique', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(144, N'MCD', N'MK', N'Macedônia', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(145, N'MDV', N'EN', N'Maldivas', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(146, N'MEX', N'ES', N'México', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(147, N'MGL', N'MN', N'Mongólia', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(148, N'MID', N'EN', N'Ilhas Midway', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(149, N'MLI', N'FR', N'Mali', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(150, N'MLT', N'MT', N'Malta', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(151, N'MLV', N'EN', N'Malavi', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(152, N'MMR', N'EN', N'Mianmar', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(153, N'MOL', N'RU', N'Moldova', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(154, N'MON', N'FR', N'Mônaco', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(155, N'MRT', N'FR', N'Martinica', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(156, N'MSR', N'EN', N'Montserrat', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(157, N'MTN', N'AR', N'Mauritânia', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(158, N'NAM', N'EN', N'Namíbia', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(159, N'NCL', N'FR', N'Nova Caledônia', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(160, N'NFK', N'EN', N'Ilhas Norfolk', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(161, N'NGA', N'EN', N'Nigéria', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(162, N'NIC', N'ES', N'Nicarágua', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(163, N'NIG', N'FR', N'Niger', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(164, N'NIU', N'EN', N'Niue', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(165, N'NOR', N'NO', N'Noruega', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(166, N'NPL', N'NE', N'Nepal', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(167, N'NRU', N'EN', N'Nauru', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(168, N'NZL', N'EN', N'Nova Zelândia', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(169, N'OMA', N'AR', N'Oma', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(170, N'PAN', N'ES', N'Panamá', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(171, N'PAQ', N'UR', N'Paquistão', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(172, N'PCI', N'EN', N'Pacific Islands', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(173, N'PCN', N'EN', N'Pitcairn', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(174, N'PER', N'ES', N'Peru', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(175, N'PLF', N'FR', N'Polinésia Francesa', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(176, N'PLU', N'EN', N'Palau', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(177, N'PNG', N'EN', N'Papua Nova Guiné', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(178, N'POL', N'PL', N'Polônia', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(179, N'POR', N'PT', N'Portugal', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(180, N'PRG', N'ES', N'Paraguai', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(181, N'PTR', N'ES', N'Porto Rico', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(182, N'QUE', N'SW', N'Quênia', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(183, N'QUI', N'RU', N'Quirgistão', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(184, N'RCA', N'FR', N'Rep.Centro-Africana', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(185, N'REU', N'FR', N'Reunião', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(186, N'RFA', N'DE', N'Alemanha', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(187, N'ROM', N'RO', N'Romênia', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(188, N'RSS', N'RU', N'Rússia', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(189, N'RUA', N'FR', N'Ruanda', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(190, N'SAM', N'EN', N'Samoa Ocidental', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(191, N'SEN', N'FR', N'Senegal', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(192, N'SHN', N'EN', N'Ilhas Santa Helena', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(193, N'SIR', N'AR', N'Síria', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(194, N'SLB', N'EN', N'Ilhas Salamão', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(195, N'SMR', N'IT', N'San Marino', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(196, N'SOM', N'AR', N'Somália', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(197, N'SPM', N'EN', N'São Pedro Miquelon', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(198, N'SRI', N'SI', N'Sri Lanka', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(199, N'SRL', N'EN', N'Serra Leoa', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(200, N'STP', N'EN', N'São Tomé e Príncipe', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(201, N'SUA', N'EN', N'Suazilândia', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(202, N'SUD', N'AR', N'Sudão', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(203, N'SUE', N'SV', N'Suécia', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(204, N'SUI', N'FR', N'Suiça', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(205, N'SUR', N'NL', N'Suriname', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(206, N'SVK', N'EN', N'Eslováquia', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(207, N'SVN', N'EN', N'Eslovênia', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(208, N'SYC', N'EN', N'Seychelles', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(209, N'TAD', N'RU', N'Tadjaquistão', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(210, N'TAI', N'TH', N'Tailândia', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(211, N'TAN', N'EN', N'Tanzânia', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(212, N'TCA', N'EN', N'Ilhas Turcas Caicos', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(213, N'TCH', N'CS', N'República Tcheca', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(214, N'TGO', N'FR', N'Togo', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(215, N'TKL', N'EN', N'Tokelau', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(216, N'TMP', N'EN', N'Timor', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(217, N'TON', N'EN', N'Tonga', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(218, N'TRT', N'EN', N'Trinidad e Tobago', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(219, N'TUC', N'RU', N'Turcomenistão', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(220, N'TUN', N'AR', N'Tunísia', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(221, N'TUR', N'TR', N'Turquia', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(222, N'TUV', N'EN', N'Tuvalu', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(223, N'UCR', N'RU', N'Ucrânia', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(224, N'UGA', N'EN', N'Uganda', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(225, N'URS', N'RU', N'União Soviética', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(226, N'URU', N'ES', N'Uruguai', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(227, N'UZB', N'RU', N'Uzbekistan', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(228, N'VAT', N'IT', N'Vaticano', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(229, N'VCT', N'EN', N'São Vicente Granadi', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(230, N'VEN', N'ES', N'Venezuela', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(231, N'VGB', N'EN', N'Ilhas Vírgens GBR', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(232, N'VTN', N'VI', N'Vietnã', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(233, N'VUT', N'EN', N'Vanuatu', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(234, N'WAK', N'EN', N'Ilhas Wake', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(235, N'WLF', N'EN', N'Ilhas Wallis Futuna', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(236, N'ZAN', N'EN', N'Zâmbia', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(237, N'ZAR', N'FR', N'Zaire', CAST(N'2022-09-28T17:26:31.493' AS DateTime)),

(238, N'ZIN', N'EN', N'Zimbabue', CAST(N'2022-09-28T17:26:31.493' AS DateTime))
GO

SET IDENTITY_INSERT [Geral].[Pais] OFF
GO


SET IDENTITY_INSERT [RH].[Profissao] ON 
GO
INSERT [RH].[Profissao] ([ProfissaoID], [Descricao], [DataInsert]) VALUES 
(1, N'ADMINISTRADOR ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(2, N'ADMINISTRADOR DE EDIFICIO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(3, N'ADMINISTRADOR DE EXPLORACAO AGRICOLA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(4, N'ADMINISTRADORES ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(5, N'ADVOGADO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(6, N'ADVOGADO DIREITO DO TRABALHO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(7, N'AGENCIADOR DE PROPAGANDA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(8, N'AGENTE ADMINISTRATIVO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(9, N'AGENTE DE COMPRAS ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(10, N'AGENTE DE VENDA DE SERVICOS AS EMPRESAS ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(11, N'AGENTE DE VIAGEM ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(12, N'AGENTE PUBLICITARIO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(13, N'AGENTE TECNICO DE VENDAS ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(14, N'AGENTES ADMINISTRATIVOS ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(15, N'AGENTES DE ADMINISTRACAO DE EMPRESAS PUBLICAS E PRIVADAS ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(16, N'ALMOXARIFE ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(17, N'ANALISTA DE CARGOS E SALARIOS ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(18, N'ANALISTA DE COMERCIALIZACAO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(19, N'ANALISTA DE COMUNICACA 8234    ANALISTA DE CREDITO E COBRANCA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(20, N'ANALISTA DE IMPORTACAO E EXPORTACAO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(21, N'ANALISTA DE OCUPACAO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(22, N'ANALISTA DE ORGANIZACAO E METODOS ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(23, N'ANALISTA DE PESQUISA DE MERCADO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(24, N'ANALISTA DE RECURSOS HUMANOS ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(25, N'ANALISTA DE SEGUROS ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(26, N'ANALISTA DE SISTEMAS ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(27, N'ANALISTA DE SUPORTE DE SISTEMA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(28, N'APONTADOR DE MAO DE OBRA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(29, N'APONTADOR DE PRODUCAO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(30, N'ARQUITETO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(31, N'ARQUIVISTA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(32, N'ASSISTENTE ADMINISTRATIVO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(33, N'ASSISTENTE DE PATRIMONIO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(34, N'ASSISTENTE DE VENDAS FINANCEIRO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(35, N'ASSISTENTE SOCIAL ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(36, N'ATENDETE DE ENFERMAGEM ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(37, N'ATLETA PROFISSIONAL DE FUTEBOL ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(38, N'AUDITOR CONTABIL ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(39, N'AUDITOR GERAL ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(40, N'AUXILIAR DE ALMOXARIFADO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(41, N'AUXILIAR DE BIBLIOTECA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(42, N'AUXILIAR DE CONTABILIDADE ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(43, N'AUXILIAR DE ENFERMAGEM ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(44, N'AUXILIAR DE ESCRITORIO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(45, N'AUXILIAR DE FARMACIA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(46, N'AUXILIAR DE IMPORTACAO E EXPORTACAO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(47, N'AUXILIAR DE LABORATORIO DE ANALISES CLINICAS ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(48, N'AUXILIAR DE LABORATORIO DE ANALISES FISICOQUIMICAS ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(49, N'AUXILIAR DE PESSOAL ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(50, N'AUXILIAR DE SEGUROS ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(51, N'AUXILIAR DE SERVICOS JURIDICOS ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(52, N'AUXILIARES DE CONTABILIDADE ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(53, N'AUXILIARES DE ESCRITORIO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(54, N'BABA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(55, N'BARMAN ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(56, N'BIBLIOTECARIO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(57, N'BIOLOGISTA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(58, N'BIOQUIMICO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(59, N'CABELEIREIRO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(60, N'CARTEIRO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(61, N'CHEFE DE ADMINISTRATIVOS ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(62, N'CHEFE DE ALMOXARIFADO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(63, N'CHEFE DE CONTABILIDADE ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(64, N'CHEFE DE CONTABILIDADE E FINANCAS ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(65, N'CHEFE DE CONTAS A PAGAR ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(66, N'CHEFE DE CONTROLE DE PATRIMONIO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(67, N'CHEFE DE ESCRITORIO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(68, N'CHEFE DE ESCRITORIO CONTABILIDADE ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(69, N'CHEFE DE ESCRITORIO CREDITO E COBRANCA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(70, N'CHEFE DE ESCRITORIO ORCAMENTO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(71, N'CHEFE DE ESCRITORIO PESSOAL ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(72, N'CHEFE DE ESCRITORIO SERVICOS GERAIS ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(73, N'CHEFE DE ESCRITORIO TESOURARIA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(74, N'CHEFE DE RECEPCAO HOTEL ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(75, N'CHEFE DE SERVICO DE TRANSPORTE RODOVIARIO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(76, N'CHEFE DE SERVICOS DE TELECOMUNICACOES ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(77, N'CIRURGIAO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(78, N'CIRURGIAO DENTISTA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(79, N'CODIFICADOR DE DADOS ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(80, N'COMERCIANTE VAREJISTA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(81, N'COMISSARIO DE BORDO AERONAVES ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(82, N'COMPRADOR COMERCIO ATACADISTA E VAREJISTA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(83, N'CONDUTOR DE CAMINHAO BASCULANTE ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(84, N'CONDUTORES DE AUTOMOVEIS ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(85, N'CONSULTOR JURIDICO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(86, N'CONTADOR ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(87, N'CONTRAMESTRE DE EMBARCACAO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(88, N'CONTRAMESTRE INDUSTRIA TEXTIL ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(89, N'COORDENADOR DE ENSINO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(90, N'CORRESPONDENTE COMERCIAL ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(91, N'COZINHEIRO CHEFE ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(92, N'CRONOANALISTA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(93, N'DATILOGRAFO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(94, N'DEMONSTRADOR ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(95, N'DESENHISTA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(96, N'DESENHISTA PROJETISTA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(97, N'DESENHISTA TECNICO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(98, N'DESPACHANTE ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(99, N'DIAGRAMADOR ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(100, N'DIGITADOR ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(101, N'DIRETOR DE EMPRESA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(102, N'DIRETOR DE EMPRESA DE COMERCIO VAREJISTA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(103, N'DIRETOR DE EMPRESA DE COMUNICACOES ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(104, N'DIRETOR DE EMPRESA DE CONSTRUCAO CIVIL ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(105, N'DIRETOR DE EMPRESA DE PRESTACAO DE SERVICOS ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(106, N'DIRETOR DE EMPRESA DE SERVICOS CLINICOS E HOSPITALARES ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(107, N'DIRETOR DE EMPRESA FINANCEIRA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(108, N'DIRETOR DE EMPRESA MANUFATUREIRA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(109, N'DIRETOR DE ESTABELECIMENTO DE ENSINO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(110, N'DIRETOR DE ESTABELECIMENTO DE ENSINO SUPERIOR ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(111, N'DIRETORES DE EMPRESAS ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(112, N'ECONOMISTA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(113, N'ECONOMISTA MERCADOLOGIA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(114, N'ECONOMISTA PROGRAMACAO ECONOMICO FINANCEIRA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(115, N'ECONOMISTAS ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(116, N'EDITOR DE LIVROS ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(117, N'ENCARREGADO DE DIGITACAO E OPERACAO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(118, N'ENFERMEIRO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(119, N'ENFERMEIRO DO TRABALHO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(120, N'ENFERMEIROS ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(121, N'ENGENHEIRO AERONAUTICO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(122, N'ENGENHEIRO AGRONOMO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(123, N'ENGENHEIRO CIVIL ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(124, N'ENGENHEIRO DE CONTROLE DE QUALIDADE ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(125, N'ENGENHEIRO DE MANUTENCAO ELETRICIDADE E ELETRONICA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(126, N'ENGENHEIRO DE MINAS ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(127, N'ENGENHEIRO DE ORGANIZACAO E METODOS ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(128, N'ENGENHEIRO DE SEGURANCA DO TRABALHO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(129, N'ENGENHEIRO DE TELECOMUNICACOES ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(130, N'ENGENHEIRO DE TRAFEGO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(131, N'ENGENHEIRO ELETRICISTA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(132, N'ENGENHEIRO ELETRONICO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(133, N'ENGENHEIRO MECANICO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(134, N'ENGENHEIRO QUIMICO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(135, N'ENGENHEIROS ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(136, N'ESCRITURARIO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(137, N'ESCRIVAO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(138, N'ESTATISTICO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(139, N'ESTETICISTA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(140, N'FARMACEUTICO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(141, N'FISIOTERAPEUTA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(142, N'FONOAUDIOLOGO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(143, N'FUNCIONARIO PUBLICO ESTADUAL SUPERIOR ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(144, N'FUNCIONARIO PUBLICO FEDERAL SUPERIOR ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(145, N'FUNCIONARIO PUBLICO MUNICIPAL SUPERIOR ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(146, N'FUNCIONARIO PUBLICO SUPERIOR ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(147, N'GEOLOGO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(148, N'GERENTE ADMINISTRATIVO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(149, N'GERENTE COMERCIAL ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(150, N'GERENTE DE BANCO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(151, N'GERENTE DE BAR ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(152, N'GERENTE DE COMPRA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(153, N'GERENTE DE  EMPRESAS ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(154, N'GERENTE DE HOTEL ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(155, N'GERENTE DE INFORMATICA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(156, N'GERENTE DE LOJA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(157, N'GERENTE DE MARKETING ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(158, N'GERENTE DE OPERACAO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(159, N'GERENTE DE PESQUISA E DESENVOLVIMENTO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(160, N'GERENTE DE PESSOAL ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(161, N'GERENTE DE PLANEJAMENTO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(162, N'GERENTE DE POSTAL E TELECOMUNICACOES ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(163, N'GERENTE DE PRODUCAO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(164, N'GERENTE DE PROPAGANDA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(165, N'GERENTE DE RESTAURANTE ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(166, N'GERENTE DE RH ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(167, N'GERENTE DE TRANSPORTE ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(168, N'GERENTE DE VENDAS ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(169, N'GERENTE EXECUTIVO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(170, N'GERENTE FINANCEIRO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(171, N'GERENTE OPERACIONAL ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(172, N'INSPETOR DE PRODUCAO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(173, N'INSPETOR DE QUALIDADE ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(174, N'INSPETOR DE	SERVICOS DE TRANSPORTE ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(175, N'INSPETOR TECNICO DE VENDAS ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(176, N'INSTRUTOR DE APRENDIZAGEM E TREINAMENTO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(177, N'JORNALISTA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(178, N'LABORATORISTA ANALISES CLINICAS ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(179, N'LABORATORISTA INDUSTRIAL ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(180, N'LOCUTOR ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(181, N'MAITRE ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(182, N'MEDICO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(183, N'MEDICO ANESTESISTA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(184, N'MEDICO CARDIOLOGISTA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(185, N'MEDICO DO TRABALHO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(186, N'MEDICO GINECOLOGISTA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(187, N'MEDICO ORTOPEDISTA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(188, N'MEDICO PEDIATRA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(189, N'MEDICO PSIQUIATRA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(190, N'MEDICO VETERINARIO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(191, N'MESTRE CONTRUCAO CIVIL ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(192, N'MESTRE INDUSTRIAL ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(193, N'MOTOCICLISTA TRANSPORTE DE MERCADORIAS ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(194, N'MOTORISTA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(195, N'MOTORISTA DE CAMINHAO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(196, N'MOTORISTA DE FURGAO OU VEICULO SIMILAR ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(197, N'MOTORISTA DE ONIBUS ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(198, N'MOTORISTA DE TAXI ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(199, N'MUSICO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(200, N'NUTRICIONISTA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(201, N'OPERADOR DE CAMERA DE TELEVISAO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(202, N'OPERADOR DE COMPUTADOR ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(203, N'OPERADOR DE EQUIPAMENTOS DE ENTRADA DE DADOS ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(204, N'OPERADOR DE ESTACAO DE RADIO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(205, N'OPERADOR DE MAQUINAS E VEICULOS ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(206, N'OPERADOR DE MICRO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(207, N'OPERADOR DE PRODUTOS FINANCEIROS ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(208, N'OPERADOR DE RAIOS X ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(209, N'OPERADOR DE TELEMARKETING ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(210, N'ORIENTADOR EDUCACIONAL ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(211, N'OURIVES ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(212, N'PEDAGOGO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(213, N'PILOTO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(214, N'PINTOR ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(215, N'PRODUTOR DE RADIO E TELEVISAO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(216, N'PROFESSOR DE 1A A 4A SERIE ENSINO DE 1O GRAU ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(217, N'PROFESSOR DE ADMINISTRACAO ENSINO SUPERIOR ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(218, N'PROFESSOR DE ALUNOS COM DEFICENCIAS MENTAIS ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(219, N'PROFESSOR DE BIOLOGIA ENSINO DE 2O GRAU ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(220, N'PROFESSOR DE CIENCIAS NATURAIS ENSINO DE 1O GRAU ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(221, N'PROFESSOR DE COMUNICACAO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(222, N'PROFESSOR DE CONTABILIDADE ENSINO SUPERIOR ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(223, N'PROFESSOR DE DIDATICA ENSINO SUPERIOR ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(224, N'PROFESSOR DE DIREITO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(225, N'PROFESSOR DE ECONOMIA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(226, N'PROFESSOR DE EDUCACAO FISICA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(227, N'PROFESSOR DE ENFERMAGEM ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(228, N'PROFESSOR DE ENSINO PRE ESCOLAR ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(229, N'PROFESSOR DE ESTATISTICA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(230, N'PROFESSOR DE ESTUDOS SOCIAIS ENSINO DE 1O GRAU ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(231, N'PROFESSOR DE FISICA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(232, N'PROFESSOR DE FISIOTERAPIA ENSINO SUPERIOR ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(233, N'PROFESSOR DE HISTORIA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(234, N'PROFESSOR DE INGLES ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(235, N'PROFESSOR DE LINGUA PORTUGUESA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(236, N'PROFESSOR DE LINGUAS ESTRANGEIRAS ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(237, N'PROFESSOR DE MATEMATICA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(238, N'PROFESSOR DE ORIENTACAO EDUCACIONAL ENSINO SUPERIOR ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(239, N'PROFESSOR DE PEDAGOGIA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(240, N'PROFESSOR DE PORTUGUES E LITERATURA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(241, N'PROFESSOR DE PRATICA DE ENSINO ENSINO SUPERIOR ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(242, N'PROFESSOR DE PSICOLOGIA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(243, N'PROFESSOR DE QUIMICA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(244, N'PROFESSOR DE SOCIOLOGIA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(245, N'PROFESSOR DE TECNOLOGIA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(246, N'PROFESSORES ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(247, N'PROFESSORES DE BIOLOGIA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(248, N'PROFESSORES DE CIENCIAS HUMANAS ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(249, N'PROFESSORES DE ENSINO DE 2O GRAU ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(250, N'PROFESSORES DE ENSINO DE PRIMEIRO GRAU ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(251, N'PROFESSORES DE ENSINO ESPECIAL ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(252, N'PROFESSORES DE ENSINO PRE ESCOLAR ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(253, N'PROFESSORES DE ENSINO SUPERIOR ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(254, N'PROFESSORES DE PEDAGOGIA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(255, N'PROFESSSOR DE GEOGRAFIA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(256, N'PROGRAMADOR DE COMPUTADOR ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(257, N'PROPAGANDISTA DE PRODUTOS DE LABORATORIO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(258, N'PSICOLOGO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(259, N'QUIMICO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(260, N'QUIMICO ANALISTA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(261, N'QUIMICO INDUSTRIAL ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(262, N'RECEPCIONISTA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(263, N'REDATOR ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(264, N'RELACOES PUBLICAS ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(265, N'REPORTER ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(266, N'REPRESENTANTE COMERCIAL ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(267, N'SECRETARIO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(268, N'SECRETARIO BILINGUE ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(269, N'SECRETARIO EXECUTIVO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(270, N'SERVENTUARIOS DA JUSTICA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(271, N'SOCIOLOGO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(272, N'SUPERVISOR DE COMPRAS ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(273, N'SUPERVISOR DE VENDAS COMERCIO ATACADISTA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(274, N'SUPERVISOR DE VENDAS COMERCIO VAREJISTA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(275, N'SUPERVISOR EDUCACIONAL ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(276, N'SUPERVISORES DE COMPRAS E COMPRADORES ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(277, N'SUPERVISORES DE VENDAS ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(278, N'TECNICO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(279, N'TECNICO AGRICOLA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(280, N'TECNICO AGROPECUARIO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(281, N'TECNICO DE ADMINISTRACAO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(282, N'TECNICO DE CONTABILIDADE ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(283, N'TECNICO DE ENFERMAGEM ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(284, N'TECNICO DE LABORATORIO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(285, N'TECNICO DE MANUTENCAO ELETRICA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(286, N'TECNICO DE MANUTENCAO ELETRONICA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(287, N'TECNICO DE OBRAS CIVIS ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(288, N'TECNICO DE PLANEJAMENTO DE PRODUCAO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(289, N'TECNICO DE SEGURANCA DO TRABALHO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(290, N'TECNICO DE SEGUROS ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(291, N'TECNICO DE TELECOMUNICACOES ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(292, N'TECNICO ELETRONICO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(293, N'TECNICO MECANICO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(294, N'TECNICO MECANICO MAQUINAS ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(295, N'TECNICO METALURGICO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(296, N'TECNICO QUIMICO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(297, N'TECNICOS DE BIOLOGIA  ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(298, N'TECNICOS DE ELETRICIDADE ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(299, N'TECNICOS DE ENFERMAGEM ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(300, N'TECNICOS DE OBRAS CIVIS ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(301, N'TERAPEUTA OCUPACIONAL ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(302, N'TOPOGRAFO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(303, N'TRABALHADORES DAS PROFISSOES CIENTIFICAS ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(304, N'TRABALHADORES DE COMERCIO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(305, N'TRABALHADORES DE SERVICOS ADMINISTRATIVOS ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(306, N'TRABALHADORES DE SERVICOS DE CONTABILIDADE ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(307, N'TRABALHADORES DE SERVICOS DE TURISMO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(308, N'VENDEDOR A DOMICILIO ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(309, N'VENDEDOR AMBULANTE ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(310, N'VENDEDOR DE COMERCIO ATACADISTA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(311, N'VENDEDOR DE COMERCIO VAREJISTA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(312, N'VENDEDOR PRACISTA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(313, N'VENDEDORES DE COMERCIO ATACADISTA E VAREJISTA ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(314, N'VENDEDORES PRACISTAS ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(315, N'VEREADOR ', CAST(N'2022-09-28T17:26:58.803' AS DateTime)),

(316, N'ZOOTECNISTA', CAST(N'2022-09-28T17:26:58.803' AS DateTime))
GO

SET IDENTITY_INSERT [RH].[Profissao] OFF
GO
