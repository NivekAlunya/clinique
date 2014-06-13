/***************************************************************************************/
/*******************           Ajout d'une facture      ********************************/
/******************* la consultation doit etre creee avant *****************************/
/***************************************************************************************/
/*  	nom du veto
	nom de l'animal
	date de la consulation
*/
CREATE PROCEDURE ajout_facture
	@DateFact datetime,
	@nomVeto varchar(30),
	@nomanimal varchar(30),
	@dateConsultation Datetime,
	@etat int
 AS
declare @cv uniqueidentifier
declare @ca uniqueidentifier
declare @cc uniqueidentifier
declare @tc money
declare @cg char(3)
declare @prix money
declare @ccons uniqueidentifier
declare @nf uniqueidentifier
SET @nf = NEWID()


select @cv=codeveto from veterinaires where nomveto=@nomVeto
select @ca=codeanimal,@cc=codeclient from animaux where nomanimal=@nomAnimal
select @tc=sum(prix),@ccons=consultations.codeconsultation from consultations,lignesconsultations 
	where codeveto=@cv and codeanimal=@ca and dateconsultation=@dateConsultation and consultations.codeconsultation=lignesconsultations.codeconsultation group by consultations.codeconsultation

insert into factures (NumFacture,datefacture,codeclient,totalfacture,archive,etat) 
	values(@nf,@DateFact,@cc,@tc,0,@etat)

INSERT INTO lignesfactures (numfacture,numligne,codegroupement,prix,archive)
  (SELECT @nf,numligne,codegroupement,prix,0 FROM lignesconsultations WHERE codeconsultation=@ccons)
/*Met à jour la consultation correspondante en  lui attribuant le n° de la facture créée */
update consultations set numfacture=@nf where codeconsultation=@ccons
GO

/***************************************************************************************/
/*******************           Ajout d'un client ***************************************/
/***************************************************************************************/
/*	nom
	prenom
	adresse
	code postal
	ville
	tel
	assurance
	mail
	archive
*/
CREATE PROCEDURE ajout_client  
	@nom varchar(20),
	@prenom varchar(20),
	@add varchar(30),
	@add2 varchar(30),
	@cp varchar(6),
	@ville varchar(25),
	@tel varchar(15),
	@ass varchar(30),
	@mail varchar(20),
	@arch int
AS
insert into clients (CodeClient,nomclient,prenomclient,adresse1,adresse2,codepostal,ville,numtel,assurance,email,archive) 
              values(newid(),@nom,@prenom,@add,@add2,@cp,@ville,@tel,@ass,@mail,@arch)
GO

/***************************************************************************************/
/*******************           Ajout d'un animal       *********************************/
/**************** le client et le couple race/espece doivent etre cree avant    ********/
/***************************************************************************************/
/*	nom client
	prenom client
	nom animal
	sexe
	couleur
	espece
	race
	archive
*/
CREATE PROCEDURE  ajout_animal 
	@nomclient varchar(20),
	@prenomclient varchar(20),
	@nomani varchar(30),
	@sexe char(1),
	@couleur varchar(20),
	@espece varchar(20),
	@race varchar(20),
	@archive int
 AS
declare @cc uniqueidentifier
select @cc=codeclient from clients where nomclient=@nomclient and prenomclient=@prenomclient;
insert into animaux (CodeAnimal,nomanimal,sexe,couleur,espece,race,codeclient,archive) values(newid(),@nomani,@sexe,@couleur,@espece,@race,@cc,@archive);
GO

/***************************************************************************************/
/*******************           Ajout d'un bareme       *********************************/
/******************* dans le cas d'un vaccin il doit etre cree avant *******************/
/***************************************************************************************/
/*	code groupement
	date de vigueur
	type d'acte
	libelle
	tarif fixe
	tarif maxi
	tarif mini
	nom du vaccin
*/
CREATE PROCEDURE ajout_bareme 	
	@codegroupement char(3),
	@datevigueur char(8),
	@typeacte char(4),
	@libelle char(30),
	@tfixe money,
	@tmini money,
	@tmaxi money,
	@nomvaccin char(30)
 AS
declare @cv uniqueidentifier
select @cv=codevaccin from vaccins where nomvaccin=@nomvaccin;
insert into baremes values(@codegroupement,@datevigueur,@typeacte,@libelle,@tfixe,@tmini,@tmaxi,@cv,0);
GO


/***************************************************************************************/
/*******************           Ajout d'un vaccin      **********************************/
/***************************************************************************************/
/*	nom du vaccin
	periode de validite
	quantite en stock
*/
CREATE PROCEDURE ajout_vaccin 
	@nomvaccin varchar(30),
	@periodevalidite int,
	@quantite int
 AS
insert into vaccins (CodeVaccin,nomvaccin,periodevalidite,quantitestock,archive) values(newid(),@nomvaccin,@periodevalidite,@quantite,0);
GO

/***************************************************************************************/
/*******************           Ajout d'un veterinaire       ****************************/
/***************************************************************************************/
/* nom du veterinaire
*/
CREATE PROCEDURE ajout_veterinaire 
	@nomveto varchar(30),
	@motpasse varchar(10),
	@archive int
 AS
insert into veterinaires values(newID(),@nomveto,@motpasse,@archive);
GO


/***************************************************************************************/
/*******************           Ajout d'un rendez vous      *****************************/
/******************* le client animal et veto doivent etre crees avant *****************/
/***************************************************************************************/
/*	nom du client
	prenom du client
	nom de l'animal
	nom du veto
	date du rendez vous
*/
CREATE PROCEDURE ajout_agenda 
	@nomclient varchar(20),
	@prenomclient varchar(20),
	@nomanimal varchar(30),
	@nomveto varchar(30),
	@daterdv datetime
 AS
declare @cc uniqueidentifier --code client
declare @ca uniqueidentifier --code animal
declare @cv uniqueidentifier --code vétérinaire

select @cc=codeclient from clients where nomclient=@nomclient and prenomclient=@prenomclient;
select @ca=codeanimal from animaux where nomanimal=@nomanimal and codeclient=@cc;
select @cv=codeveto from veterinaires where nomveto=@nomveto;
insert into agendas (codeveto,codeanimal,daterdv) values(@cv,@ca,@daterdv);
GO

/************************************************************************************************/
/*******************           Ajout d'une consultation en cours d'une ligne        *************/
/*******************           le rendez vous doit etre cree avant                  *************/
/************************************************************************************************/
/*	date de la consultation
	nom du veterinaire
	nom de l'animal
	etat
*/
CREATE PROCEDURE  ajout_consultation1 
	@dateconsultation datetime,
	@nomveto varchar(30),
	@nomanimal varchar(30)
 AS
declare @cv uniqueidentifier
declare @ca uniqueidentifier
declare @dv char(8)
declare @cc uniqueidentifier
set @cc=newid()
select @cv=codeveto from veterinaires where nomveto=@nomveto
select @ca=codeanimal from animaux where nomanimal=@nomanimal 
select @dv=datevigueur from baremes where codegroupement='080' and archive=0

insert into consultations (CodeConsultation,dateconsultation,codeveto,codeanimal,commentaire,etat,archive)
values(@cc,@dateconsultation,@cv,@ca,null,0,0)


insert into lignesconsultations(codeconsultation,numligne,codegroupement,datevigueur,prix,archive,rappelenvoye)
values (@cc,newid(),'080',@dv,29,0,0)
GO

/**************************************************************************************************************/
/****************           Ajout d'une consultation de deux lignes terminée, non facturée        *************/
/****************           le rendez vous doit etre cree avant                        ************************/
/**************************************************************************************************************/
/*	date de la consultation
	nom du veterinaire
	nom de l'animal
	etat
*/
CREATE PROCEDURE  ajout_consultation2 
	@dateconsultation datetime,
	@nomveto varchar(30),
	@nomanimal varchar(30)
 AS
declare @cv uniqueidentifier
declare @ca uniqueidentifier
declare @dv char(8)
declare @cc uniqueidentifier
set @cc=newid()
select @cv=codeveto from veterinaires where nomveto=@nomveto
select @ca=codeanimal from animaux where nomanimal=@nomanimal 


insert into consultations (CodeConsultation,dateconsultation,codeveto,codeanimal,commentaire,etat,archive) 
values(@cc,@dateconsultation,@cv,@ca, 'consultation enregistree le ' + convert(char(10),@dateconsultation,103),1,0)

select @dv=datevigueur from baremes where codegroupement='080' and archive=0
insert into lignesconsultations(codeconsultation,numligne,codegroupement,datevigueur,prix,archive,rappelenvoye)
values (@cc,newid(),'080',@dv,29,0,0)
select @dv=datevigueur from baremes where codegroupement='012' and archive=0
insert into lignesconsultations(codeconsultation,numligne,codegroupement,datevigueur,prix,archive,rappelenvoye)
values (@cc,newid(),'012',@dv,30,0,0)
GO


/*************************************************************************************************/
/*******************           Ajout d'une consultation d'une ligne + vaccin facturée    *********/
/*******************           le rendez vous doit etre cree avant                   *************/
/*************************************************************************************************/
/*	date de la consultation
	nom du veterinaire
	nom de l'animal
	etat
*/
CREATE PROCEDURE  ajout_consultation3 
	@dateconsultation datetime,
	@nomveto varchar(30),
	@nomanimal varchar(30)
 AS
declare @cv uniqueidentifier
declare @ca uniqueidentifier
declare @dv char(8)
declare @cc uniqueidentifier
set @cc=newid()
select @cv=codeveto from veterinaires where nomveto=@nomveto
select @ca=codeanimal from animaux where nomanimal=@nomanimal 
select @dv=datevigueur from baremes where codegroupement='105' and archive=0

insert into consultations (CodeConsultation,dateconsultation,codeveto,codeanimal,commentaire,etat,archive)
values(@cc,@dateconsultation,@cv,@ca, 'consultation enregistree le ' + convert(char(10),@dateconsultation,103),2,0)


insert into lignesconsultations(codeconsultation,numligne,codegroupement,datevigueur,prix,archive,rappelenvoye)
values (@cc,newid(),'105',@dv,22,0,0)
GO

/***************************************************************************************/
/*******************           Ajout d'un couple race/espece           *****************/
/***************************************************************************************/
CREATE PROCEDURE ajout_race @race varchar(20),@espece varchar(20)
 AS
insert into races (race,espece) values(@race,@espece)
GO


/***************************************************************************************/
