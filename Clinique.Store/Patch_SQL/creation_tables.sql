/*   Application : SQL Server Enterprise Manager*/
CREATE TABLE dbo.Veterinaires
	(
 	CodeVeto uniqueidentifier NOT NULL ,
	NomVeto varchar(30) NOT NULL,
	MotPasse varchar(10) NOT NULL,
	Archive bit NOT NULL
	) 

ALTER TABLE dbo.Veterinaires ADD CONSTRAINT
	PK_Veterinaire PRIMARY KEY NONCLUSTERED 
	(
	CodeVeto
	) 


/***********************************************************************************************/
/*   Application : SQL Server Enterprise Manager*/
CREATE TABLE dbo.Vaccins
	(
 	CodeVaccin uniqueidentifier NOT NULL ,
	NomVaccin varchar(30) NOT NULL,
	QuantiteStock integer NOT NULL,
	PeriodeValidite integer NULL,
	Archive bit NOT NULL
	) 

ALTER TABLE dbo.Vaccins ADD CONSTRAINT
	PK_Vaccins PRIMARY KEY NONCLUSTERED 
	(
	CodeVaccin
	) 

/***********************************************************************************************/
/*   Application : SQL Server Enterprise Manager*/
CREATE TABLE dbo.Baremes
	(
 	CodeGroupement char(3) NOT NULL,
	DateVigueur char(8) NOT NULL,
	TypeActe varchar(4) NOT NULL,
	Libelle varchar(30) NULL,
	TarifFixe money NOT NULL,
	TarifMini money NULL,
	TarifMaxi money NULL,
	CodeVaccin uniqueidentifier NULL,
	Archive bit NOT NULL
	) 

ALTER TABLE dbo.Baremes ADD CONSTRAINT
	PK_Baremes PRIMARY KEY NONCLUSTERED 
	(
	CodeGroupement,
	DateVigueur
	) 
ALTER TABLE dbo.Baremes ADD CONSTRAINT
	FK_Baremes FOREIGN KEY 	( CodeVaccin )
	references Vaccins (CodeVaccin )

/**********************************************************************************************/
/*   Application : SQL Server Enterprise Manager*/
CREATE TABLE dbo.Races
	(
 	Race varchar(20) NOT NULL,
	Espece varchar(20) NOT NULL
	) 

ALTER TABLE dbo.Races ADD CONSTRAINT
	PK_Races PRIMARY KEY NONCLUSTERED 
	(
	Race,
	Espece
	) 

/*********************************************************************************************/
/*   Application : SQL Server Enterprise Manager*/
CREATE TABLE dbo.Clients
	(
 	CodeClient uniqueidentifier NOT NULL,
	NomClient varchar(20) NOT NULL,
	PrenomClient varchar(20) NOT NULL,
	Adresse1 varchar(30) NULL,
	Adresse2 varchar(30) NULL,
	CodePostal char(6) NULL,
	Ville varchar(25) NULL,
	NumTel varchar(15) NULL,
	Assurance varchar(30) NULL,
	Email varchar(20) NULL ,
	Remarque text NULL,
	Archive bit NOT NULL
	) 

ALTER TABLE dbo.Clients ADD CONSTRAINT
	PK_Clients PRIMARY KEY NONCLUSTERED 
	(
	codeClient
	) 

/*******************************************************************************************/
/*   Application : SQL Server Enterprise Manager*/
CREATE TABLE dbo.Animaux
	(
 	CodeAnimal uniqueidentifier NOT NULL,
	NomAnimal varchar(30) NOT NULL ,
	Sexe char(1) NOT NULL ,
	Couleur varchar(20) NULL,
	Race varchar(20) NOT NULL,
	Espece varchar(20) NOT NULL,
	CodeClient uniqueidentifier NOT NULL,
	Tatouage varchar(10) NULL,
	Antecedents text NULL,
	Archive bit NOT NULL
	) 

ALTER TABLE dbo.Animaux ADD CONSTRAINT
	PK_Animaux PRIMARY KEY NONCLUSTERED 
	(
	CodeAnimal
	)

ALTER TABLE dbo.Animaux ADD CONSTRAINT
	FK_Animaux FOREIGN KEY 	( CodeClient )
	references Clients (CodeClient )

ALTER TABLE dbo.Animaux ADD CONSTRAINT
	FK_ANIMAUX_RACES FOREIGN KEY (Race,Espece)
	references Races (Race,Espece)
/**********************************************************************************************/
/*   Application : SQL Server Enterprise Manager*/
CREATE TABLE dbo.Agendas
	(
 	CodeVeto uniqueidentifier NOT NULL,
	DateRdv smalldatetime NOT NULL,
	CodeAnimal uniqueidentifier NOT NULL
	) 

ALTER TABLE dbo.Agendas ADD CONSTRAINT
	PK_Agendas PRIMARY KEY NONCLUSTERED 
	(
	CodeVeto,
	CodeAnimal,
	DateRdv
	)
ALTER TABLE dbo.Agendas ADD CONSTRAINT
	FK_Agendas FOREIGN KEY 	( CodeAnimal )
	references Animaux (CodeAnimal ) 

/**********************************************************************************************/
/*   Application : SQL Server Enterprise Manager*/
CREATE TABLE dbo.Factures
	(
 	NumFacture uniqueidentifier NOT NULL,
	DateFacture DateTime NOT NULL,
	CodeClient uniqueidentifier NOT NULL,
	TotalFacture money NULL,
	Archive bit NOT NULL,
	Etat tinyint NOT NULL,
	RappelEnvoye DateTime NULL
	) 

ALTER TABLE dbo.Factures ADD CONSTRAINT
	PK_Factures PRIMARY KEY NONCLUSTERED 
	(
	NumFacture
	)
ALTER TABLE dbo.Factures ADD CONSTRAINT
	FK_Factures_clients FOREIGN KEY 	( CodeClient )
	references Clients (CodeClient )


/**********************************************************************************************/
/*   Application : SQL Server Enterprise Manager*/
CREATE TABLE dbo.LignesFactures
	(
 	NumFacture uniqueidentifier NOT NULL,
	NumLigne uniqueidentifier NOT NULL,
	CodeGroupement char(3) NOT NULL,
	Prix money NULL,
	Archive bit NOT NULL
	) 

ALTER TABLE dbo.LignesFactures ADD CONSTRAINT
	PK_LignesFactures PRIMARY KEY NONCLUSTERED 
	(
	NumFacture,
	NumLigne
	) 
ALTER TABLE dbo.LignesFactures ADD CONSTRAINT
	FK_LignesFactures_facture FOREIGN KEY (NumFacture) 
	references Factures ( NumFacture ) 
/***********************************************************************************************/
/*   Application : SQL Server Enterprise Manager*/
CREATE TABLE dbo.Consultations
	(
 	CodeConsultation uniqueidentifier NOT NULL ,
	DateConsultation DateTime NOT NULL,
	CodeVeto uniqueidentifier NOT NULL,
	CodeAnimal uniqueidentifier NOT NULL,
	Commentaire varchar(50) NULL,
	Etat tinyint NOT NULL,
	NumFacture uniqueidentifier NULL,
	Archive bit NOT NULL
	) 

ALTER TABLE dbo.Consultations ADD CONSTRAINT
	PK_Consultations PRIMARY KEY NONCLUSTERED 
	(
	CodeConsultation
	)
ALTER TABLE dbo.Consultations ADD CONSTRAINT
	FK_Consultations_Veterinaires FOREIGN KEY 	( CodeVeto )
	references Veterinaires (CodeVeto )
ALTER TABLE dbo.Consultations ADD CONSTRAINT
	FK_Consultations_Animaux FOREIGN KEY 	( CodeAnimal )
	references Animaux (CodeAnimal )
ALTER TABLE dbo.Consultations ADD CONSTRAINT
	FK_Consultations_Factures FOREIGN KEY 	( NumFacture )
	references Factures (NumFacture )

/*******************************************************************************************/
/*   Application : SQL Server Enterprise Manager*/
CREATE TABLE dbo.LignesConsultations
	(
 	CodeConsultation uniqueidentifier NOT NULL,
	NumLigne uniqueidentifier NOT NULL,
	CodeGroupement char(3) NOT NULL,
	DateVigueur char(8),
	Prix money NOT NULL,
	RappelEnvoye bit NOT NULL,
	Archive bit NOT NULL
	) 

ALTER TABLE dbo.LignesConsultations ADD CONSTRAINT
	PK_LignesConsultations PRIMARY KEY NONCLUSTERED 
	(
	CodeConsultation,
	NumLigne
	) 
ALTER TABLE dbo.LignesConsultations ADD CONSTRAINT
	FK_LignesConsultations_Consultations FOREIGN KEY (CodeConsultation) 
	references Consultations ( CodeConsultation ) 

ALTER TABLE dbo.LignesConsultations ADD CONSTRAINT
	FK_LignesConsultations_baremes FOREIGN KEY (CodeGroupement,DateVigueur) 
	references Baremes ( CodeGroupement,DateVigueur ) 

