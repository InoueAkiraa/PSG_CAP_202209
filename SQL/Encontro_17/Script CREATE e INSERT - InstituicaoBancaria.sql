CREATE TABLE InstituicaoBancaria(
	InstituicaoBancariaID INT NOT NULL IDENTITY(1,1),
	CodigoBanco INT NULL,
	Descricao VARCHAR(MAX) NOT NULL,
	SiteWWW VARCHAR(MAX) NOT NULL,
	DataInsert DATETIME NULL DEFAULT GETDATE(),
	CONSTRAINT PK_InstituicaoBancaria PRIMARY KEY (InstituicaoBancariaID)
)

SET IDENTITY_INSERT[dbo].[InstituicaoBancaria]ON

INSERT INTO [dbo].[InstituicaoBancaria] ([InstituicaoBancariaID], [CodigoBanco], [Descricao], [SiteWWW]) VALUES
(1,246,'BancoABCBrasilS.A.','http://www.abcbrasil.com.br/'), 
(2,356,'BancoABNAMRORealS.A.','http://www.abnamro.com.br/'), 
(3,25,'BancoAlfaS.A.','http://www.bancoalfa.com.br/'), 
(4,641,'BancoAlvoradaS.A.','Nãopossuisite'), 
(5,NULL,'BancoAmericanExpressS.A.','http://www.aexp.com/'), 
(6,29,'BancoBanerjS.A.','http://www.banerj.com.br/'), 
(7,38,'BancoBanestadoS.A.','http://www.banestado.com.br/'), 
(8,740,'BancoBarclaysS.A.','http://www.barclays.com/'), 
(9,107,'BancoBBMS.A.','http://www.bbmbank.com.br/'), 
(10,31,'BancoBegS.A.','http://www.itau.com.br/'), 
(11,36,'BancoBemS.A.','Nãopossuisite'), 
(12,394,'BancoBMCS.A.','http://www.bmc.com.br/'), 
(13,318,'BancoBMGS.A.','http://www.bancobmg.com.br/'), 
(14,752,'BancoBNPParibasBrasilS.A.','http://www.bnpparibas.com.br/'), 
(15,248,'BancoBoavistaInteratlânticoS.A.','nãopossuisite'), 
(16,237,'BancoBradescoS.A.','http://www.bradesco.com.br/'), 
(17,225,'BancoBrascanS.A.','http://www.bancobrascan.com.br/'), 
(18,263,'BancoCaciqueS.A.','http://www.bancocacique.com.br/'), 
(19,222,'BancoCalyonBrasilS.A.','http://www.calyon.com.br/'), 
(20,40,'BancoCargillS.A.','http://www.bancocargill.com.br/'), 
(21,745,'BancoCitibankS.A.','http://www.citibank.com/brasil'), 
(22,215,'BancoComercialedeInvestimentoSudamerisS.A.','Nãopossuisite'), 
(23,756,'BancoCooperativodoBrasilS.A.-BANCOOB','http://www.bancoob.com.br/'), 
(24,748,'BancoCooperativoSicrediS.A.-BANSICREDI','http://www.bansicredi.com.br/'), 
(25,505,'BancoCreditSuisse(Brasil)S.A.','http://www.csfb.com/'), 
(26,229,'BancoCruzeirodoSulS.A.','http://www.bcsul.com.br/'), 
(27,3,'BancodaAmazôniaS.A.','http://www.bancoamazonia.com.br/'), 
(28,707,'BancoDaycovalS.A.','http://www.daycoval.com.br/'), 
(29,NULL,'BancodeLageLandenBrasilS.A.','http://www.delagelanden.com/'), 
(30,24,'BancodePernambucoS.A.-BANDEPE','http://www.bandepe.com.br/'), 
(31,456,'BancodeTokyo-MitsubishiBrasilS.A.','http://www.btm.com.br/'), 
(32,214,'BancoDibensS.A.','http://www.bancodibens.com.br/'), 
(33,1,'BancodoBrasilS.A.','http://www.bb.com.br/'), 
(34,27,'BancodoEstadodeSantaCatarinaS.A.','http://www.besc.com.br/'), 
(35,33,'BancodoEstadodeSãoPauloS.A.-Banespa','http://www.banespa.com.br/'), 
(36,47,'BancodoEstadodeSergipeS.A.','http://www.banese.com.br/'), 
(37,37,'BancodoEstadodoParáS.A.','http://www.banparanet.com.br/'), 
(38,41,'BancodoEstadodoRioGrandedoSulS.A.','http://www.banrisul.com.br/'), 
(39,4,'BancodoNordestedoBrasilS.A.','http://www.banconordeste.gov.br/'), 
(40,265,'BancoFatorS.A.','http://www.bancofator.com.br/'), 
(41,NULL,'BancoFiatS.A.','http://www.bancofiat.com.br/'), 
(42,224,'BancoFibraS.A.','http://www.bancofibra.com.br/'), 
(43,175,'BancoFinasaS.A.','nãopossuisite'), 
(44,252,'BancoFininvestS.A.','http://www.fininvest.com.br/'), 
(45,233,'BancoGECapitalS.A.','http://www.bancoge.com.br/'), 
(46,NULL,'BancoGeneralMotorsS.A.','http://www.bancogm.com.br/'), 
(47,734,'BancoGerdauS.A.','http://www.bancogerdau.com.br/'), 
(48,612,'BancoGuanabaraS.A.','nãopossuisite'), 
(49,63,'BancoIbiS.A.BancoMúltiplo','Nãopossuisite'), 
(50,604,'BancoIndustrialdoBrasilS.A.','http://www.bancoindustrial.com.br/'), 
(51,320,'BancoIndustrialeComercialS.A.','http://www.bicbanco.com.br/'), 
(52,653,'BancoIndusvalS.A.','http://www.indusval.com.br/'), 
(53,630,'BancoIntercapS.A.','http://www.intercap.com.br/'), 
(54,249,'BancoInvestcredUnibancoS.A.','Nãopossuisite'), 
(55,48,'BancoItaúBBAS.A.','http://www.itaubba.com.br/'), 
(56,652,'BancoItaúHoldingFinanceiraS.A.','http://www.itau.com.br/'), 
(57,341,'BancoItaúS.A.','http://www.itau.com.br/'), 
(58,NULL,'BancoItaucredFinanciamentosS.A.','http://www.itaucred.com.br/'), 
(59,NULL,'BancoItausagaS.A.','http://www.itau.com.br/'), 
(60,376,'BancoJ.P.MorganS.A.','http://www.jpmorgan.com/'), 
(61,74,'BancoJ.SafraS.A.','http://www.jsafra.com.br/'), 
(62,757,'BancoKEBdoBrasilS.A.','nãopossuisite'), 
(63,600,'BancoLusoBrasileiroS.A.','http://www.lusobrasileiro.com.br/'), 
(64,392,'BancoMercantildeSãoPauloS.A.','nãopossuisite'), 
(65,389,'BancoMercantildoBrasilS.A.','http://www.mercantil.com.br/'), 
(66,755,'BancoMerrillLynchdeInvestimentosS.A.','http://www.ml.com/'), 
(67,151,'BancoNossaCaixaS.A.','http://www.nossacaixa.com.br/'), 
(68,45,'BancoOpportunityS.A.','http://www.opportunity.com.br/'), 
(69,208,'BancoPactualS.A.','http://www.pactual.com.br/'), 
(70,623,'BancoPanamericanoS.A.','http://www.panamericano.com.br/'), 
(71,611,'BancoPaulistaS.A.','http://www.bancopaulista.com.br/'), 
(72,643,'BancoPineS.A.','http://www.bancopine.com.br/'), 
(73,638,'BancoProsperS.A.','http://www.bancoprosper.com.br/'), 
(74,747,'BancoRabobankInternationalBrasilS.A.','http://www.rabobank.com/'), 
(75,633,'BancoRendimentoS.A.','http://www.rendimento.com.br/'), 
(76,72,'BancoRuralMaisS.A.','http://www.rural.com.br/'), 
(77,453,'BancoRuralS.A.','http://www.rural.com.br/'), 
(78,422,'BancoSafraS.A.','http://www.safra.com.br/'), 
(79,353,'BancoSantanderBrasilS.A.','http://www.santander.com.br/'), 
(80,8,'BancoSantanderMeridionalS.A.','http://www.meridional.com.br/'), 
(81,351,'BancoSantanderS.A.','http://www.santander.com.br/'), 
(82,250,'BancoSchahinS.A.','http://www.bancoschahin.com.br/'), 
(83,749,'BancoSimplesS.A.','http://www.bancosimples.com.br/'), 
(84,366,'BancoSociétéGénéraleBrasilS.A.','http://www.sgbrasil.com.br/'), 
(85,637,'BancoSofisaS.A.','http://www.sofisa.com.br/'), 
(86,347,'BancoSudamerisBrasilS.A.','http://www.sudameris.com.br/'), 
(87,464,'BancoSumitomoMitsuiBrasileiroS.A.','http://não%20possue%20site/'), 
(88,634,'BancoTriânguloS.A.','http://www.tribanco.com.br/'), 
(89,247,'BancoUBSS.A.','http://www.ubsw.com/'), 
(90,116,'BancoÚnicoS.A.','http://www.unibanco.com.br/'), 
(91,655,'BancoVotorantimS.A.','http://www.bancovotorantim.com.br/'), 
(92,610,'BancoVRS.A.','http://www.vr.com.br/'), 
(93,370,'BancoWestLBdoBrasilS.A.','http://www.westlb.com.br/'), 
(94,21,'BANESTESS.A.BancodoEstadodoEspíritoSanto','http://www.banestes.com.br/'), 
(95,719,'Banif-BancoInternacionaldoFunchal(Brasil)S.A.','http://www.banif.com.br/'), 
(96,479,'BankBostonBancoMúltiploS.A.','http://www.bankboston.com.br/'), 
(97,744,'BankBostonN.A.','http://www.bankboston.com.br/'), 
(98,NULL,'BBBancoPopulardoBrasilS.A.','http://www.bancopopulardobrasil.com.br/'), 
(99,NULL,'BESInvestimentodoBrasilS.A.-BancodeInvestimento','http://www.besinvestimento.com.br/'), 
(100,70,'BRB-BancodeBrasíliaS.A.','http://www.brb.com.br/'), 
(101,104,'CaixaEconômicaFederal','http://www.caixa.gov.br/'), 
(102,477,'CitibankN.A.','http://www.citibank.com/brasil'), 
(103,NULL,'CredicardBancoS.A.','Nãopossuisite'), 
(104,487,'DeutscheBankS.A.-BancoAlemão','http://www.deutsche-bank.com.br/'), 
(105,751,'DresdnerBankBrasilS.A.-BancoMúltiplo','http://www.drkw.net/'), 
(106,210,'DresdnerBankLateinamerikaAktiengesellschaft','http://www.dbla.com/'), 
(107,62,'HipercardBancoMúltiploS.A.','http://www.banco1.net/'), 
(108,399,'HSBCBankBrasilS.A.-BancoMúltiplo','http://www.hsbc.com.br/'), 
(109,492,'INGBankN.V.','http://www.ing.com/'), 
(110,488,'JPMorganChaseBank','http://www.jpmorganchase.com/'), 
(111,65,'LemonBankBancoMúltiploS.A.','http://www.lemon.com/'), 
(112,409,'UNIBANCO-UniãodeBancosBrasileirosS.A.','http://www.unibanco.com.br/'), 
(113,230,'UnicardBancoMúltiploS.A.','http://www.unicard.com.br/'), 
(117,654,'BancoA.J.RennerS.A.','http://www.bancorenner.com.br/'), 
(118,213,'BancoArbiS.A.','http://www.arbi.com.br/'), 
(119,739,'BancoBGNS.A.','http://www.bgn.com.br/'), 
(120,96,'BancoBM&FdeServiçosdeLiquidaçãoeCustódiaS.A','http://www.bmf.com.br/'), 
(121,218,'BancoBonsucessoS.A.','http://www.bancobonsucesso.com.br/'), 
(122,NULL,'BancoBRJS.A.','http://www.brjbank.com.br/'), 
(123,44,'BancoBVAS.A.','http://www.bancobva.com.br/'), 
(124,412,'BancoCapitalS.A.','http://www.bancocapital.com.br/'), 
(125,266,'BancoCédulaS.A.','http://www.bancocedula.com.br/'), 
(126,241,'BancoClássicoS.A.','Nãopossuisite'), 
(127,NULL,'BancoCNHCapitalS.A.','http://www.bancocnh.com.br/'), 
(128,753,'BancoComercialUruguaiS.A.','http://www.bancocomercial.com.br/'), 
(129,75,'BancoCR2S.A.','Nãopossuisite'), 
(130,721,'BancoCredibelS.A.','http://www.credibel.com.br/'), 
(131,NULL,'BancoDaimlerchryslerS.A.','http://www.bancodaimlerchrysler.com.br/'), 
(132,300,'BancodeLaNacionArgentina','http://www.bna.com.ar/'), 
(133,495,'BancodeLaProvinciadeBuenosAires','http://www.bapro.com.ar/'), 
(134,494,'BancodeLaRepublicaOrientaldelUruguay','Nãopossuisite'), 
(135,35,'BancodoEstadodoCearáS.A.-BEC','http://www.bec.com.br/'), 
(136,39,'BancodoEstadodoPiauíS.A.-BEP','http://www.bep.com.br/'), 
(137,743,'BancoEmblemaS.A.','http://www.bancoemblema.com.br/'), 
(138,626,'BancoFicsaS.A.','http://www.ficsa.com.br/'), 
(139,NULL,'BancoFordS.A.','http://www.bancoford.com.br/'), 
(140,NULL,'BancoHondaS.A.','http://www.bancohonda.com.br/'), 
(141,NULL,'BancoIBMS.A.','http://www.ibm.com/br/financing/'), 
(142,217,'BancoJohnDeereS.A.','http://www.johndeere.com.br/'), 
(143,212,'BancoMatoneS.A.','http://www.bancomatone.com.br/'), 
(144,243,'BancoMáximaS.A.','http://www.bancomaxima.com.br/'), 
(145,NULL,'BancoMaxinvestS.A.','Nãopossuisite'), 
(146,746,'BancoModalS.A.','http://www.bancomodal.com.br/'), 
(147,NULL,'BancoMoneoS.A.','Nãopossuisite'), 
(148,738,'BancoMoradaS.A.','http://www.bancomorada.com.br/'), 
(149,66,'BancoMorganStanleyDeanWitterS.A.','http://www.morganstanley.com.br/'), 
(150,NULL,'BancoOurinvestS.A.','http://www.ourinvest.com.br/'), 
(151,613,'BancoPecúniaS.A.','http://www.bancopecunia.com.br/'), 
(152,724,'BancoPortoSeguroS.A.','Nãopossuisite'), 
(153,735,'BancoPottencialS.A.','http://www.pottencial.com.br/'), 
(154,NULL,'BancoPSAFinanceBrasilS.A.','Nãopossuisite'), 
(155,741,'BancoRibeirãoPretoS.A.','http://www.brp.com.br/'), 
(156,NULL,'BancoRodobensS.A.','http://www.rodobens.com.br/'), 
(157,NULL,'BancoToyotadoBrasilS.A.','http://www.bancotoyota.com.br/'), 
(158,NULL,'BancoTricuryS.A.','http://www.tricury.com.br/'), 
(159,NULL,'BancoVolkswagenS.A.','http://www.bancovw.com.br/'), 
(160,NULL,'BancoVolvo(Brasil)S.A.','Nãopossuisite'), 
(161,NULL,'BPNBrasilBancoMútiploS.A.','Nãopossuisite'), 
(162,64,'GoldmanSachsdoBrasilBancoMúltiploS.A.','http://www.goldmansachs.com/'), 
(163,254,'ParanáBancoS.A.','http://www.paranabanco.com.br/')

SET IDENTITY_INSERT[dbo].[InstituicaoBancaria]OFF
GO
