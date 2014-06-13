delete from lignesfactures
go
delete from factures
go
delete from lignesconsultations
go
delete from consultations
go
delete from agendas
go
delete from animaux
go
delete from clients
go
delete from races
go
delete from baremes
go
delete from vaccins
go
delete from veterinaires
go

/* 
	Ajout des vétérinaires dans la base
	5 sont actifs, le dernier est archivé et ne devrait pas 
	apparaître dans l'écran de l'application
*/
exec ajout_veterinaire 'BOSAPIN Edmond','PIN',0
exec ajout_veterinaire 'DE CAJOU Benoît', 'NOIX', 0
exec ajout_veterinaire 'MALALANICH Mélanie','DOG', 0
exec ajout_veterinaire 'AIMONE Anne','FLEUR',0
exec ajout_veterinaire 'TOURNE Sylvan','EOLE',0
exec ajout_veterinaire 'SION Rémy', 'PARDON',1
go
/* Ajout des vaccins */
exec ajout_vaccin 'Vache folle',12,4
exec ajout_vaccin 'ZK36',18,14
exec ajout_vaccin 'Rage',12,0
exec ajout_vaccin 'DT',12,3
go
/* Ajout des barèmes */
declare @date char(8)
select @date=convert(char(8),dateadd(m,-13,getdate()),3)
exec ajout_bareme '103',@date,'VACC','Vaccination DT',10,NULL,NULL,'DT'
exec ajout_bareme '104',@date,'VACC','Vaccination vache folle',13,NULL,NULL,'vache folle'
exec ajout_bareme '105',@date,'VACC','Vaccination rage',22,NULL,NULL,'rage'
exec ajout_bareme '106',@date,'VACC','Vaccination ZK36',22,NULL,NULL,'ZK36'
select @date=convert(char(8),dateadd(m,-6,getdate()),3)
exec ajout_bareme '010',@date,'CONS','Scanner chien',75,NULL,NULL,NULL
exec ajout_bareme '011',@date,'CONS','Echographie',0,50,75,NULL
exec ajout_bareme '012',@date,'CONS','Bobologie',30,NULL,NULL,NULL
exec ajout_bareme '080',@date,'CONS','Révision',29,NULL,NULL,NULL
exec ajout_bareme '403',@date,'TATO','Tatouage',0,15,20,NULL
go
/* Ajout des couples race/espèce */
exec ajout_race 'Batard','Chien'
exec ajout_race 'Bourgogne','Escargot'
exec ajout_race 'Canari','Oiseau'
exec ajout_race 'Marine','Tortue'
exec ajout_race 'Setter','Chien'
exec ajout_race 'Siamois','Chat'
go
/* Ajout des clients */
-- clients "normaux" avec des animaux --
exec ajout_client 'Dupond','Jean','20 rue de la paix',null,'44000','Nantes','02.40.41.42.43','MAAF','JDupont@free.fr',0
exec ajout_animal 'Dupond','Jean','Toby','M','noir','Chien','Batard',0
exec ajout_animal 'Dupond','Jean','Kiki','M','Jaune','Chien','Batard',0
exec ajout_animal 'Dupond','Jean','Kiki 1/2','M','Jaune','Chien','Batard',1
go
-- L'animal à une consultation en cours
declare @dt datetime
select @dt=convert(char(10),getdate(),103) + ' 10:00:00'
exec ajout_client 'Durand','Albert','17 rue des pins',null,'44300','La Baule','02.51.12.45.63','GMF','',0
exec ajout_animal 'Durand','Albert','Rex','M','feu','Chien','Setter',0
exec ajout_agenda 'Durand','Albert','Rex','TOURNE Sylvan',@dt
exec ajout_consultation1 @dt,'TOURNE Sylvan','Rex'
go

exec ajout_client 'Dupond','Paul','22 rue de la mer',null,'29000','Brest','02.99.27.45.62','MAIF','',0
exec ajout_animal 'Dupond','Paul','Caroline','F','verte','Tortue','Marine',0
go
-- Ce client a un animal archivable (dormé) avec ses consultations et factures --
declare @dt datetime
select @dt=convert(char(10),dateadd(day,-5,getdate()),103) + ' 10:00:00'
exec ajout_client 'Duboulon','Franck','84 rue de Paris',null,'44000','Nantes','','','',0
exec ajout_animal 'Duboulon','Franck','Médor','M','Blanc','Chien','Batard',0
exec ajout_animal 'Duboulon','Franck','Dormé','M','Noir','Chien','Batard',0
exec ajout_agenda 'Duboulon','Franck','Dormé','DE CAJOU Benoît',@dt
exec ajout_consultation3 @dt,'DE CAJOU Benoît','Dormé'
exec ajout_facture @dt,'DE CAJOU Benoît','Dormé',@dt,2
go
exec ajout_client 'Bonnet','Jean','18 rue des fleurs',null,'17000','La Rochelle','','','',0
exec ajout_animal 'Bonnet','Jean','Milou','M','Blanc','Chien','Batard',0
declare @dt datetime
select @dt=convert(char(10),dateadd(day,-30,getdate()),103) + ' 16:00:00'
exec ajout_consultation2 @dt,'DE CAJOU Benoît','Milou'
select @dt=convert(char(10),dateadd(day,-20,getdate()),103) + ' 09:15:00'
exec ajout_consultation2 @dt,'MALALANICH Mélanie','Milou'
select @dt=convert(char(10),dateadd(day,-10,getdate()),103) + ' 10:00:00'
exec ajout_consultation2 @dt,'AIMONE Anne','Milou'
go
exec ajout_client 'Clinton','Bill','1 rue des Fraises',null,'75000','Paris','','','',0
exec ajout_animal 'Clinton','Bill','Titi','M','Jaune','Oiseau','Canari',0
go
-- ce client ne doit pas apparaître dans l'application --
exec ajout_client 'ARCHIVE','Client','1 rue des archives',null,'75000','Paris','','','',1
go
-- ce client est archivable avec son animal, la consultation, et la facture. L'un des ses animaux est déjà archivé --
declare @dt datetime
select @dt=convert(char(10),dateadd(m,-5,getdate()),103) + ' 11:00:00'
exec ajout_client 'A ARCHIVER','Client avec animaux','1 rue des archives',null,'75000','Paris','','','',0
exec ajout_animal 'A ARCHIVER','Client avec animaux','Miaou II','M','','Chat','Siamois',0
exec ajout_animal 'A ARCHIVER','Client avec animaux','Miaou','M','','Chat','Siamois',1
exec ajout_agenda 'A ARCHIVER','Client avec animaux','Miaou II','MALALANICH Mélanie',@dt
exec ajout_consultation3 @dt,'MALALANICH Mélanie','Miaou II'
exec ajout_facture @dt,'MALALANICH Mélanie','Miaou II',@dt,2
go
-- ce client ne peut pas être archivé : facture non réglée --
declare @dt datetime
select @dt=convert(char(10),dateadd(m,-5,getdate()),103) + ' 10:00:00'
exec ajout_client 'A ARCHIVER 2','Client avec animaux','1 rue des archives',null,'75000','Paris','','','',0
exec ajout_animal 'A ARCHIVER 2','Client avec animaux','Meow','M','','Chat','Siamois',0
exec ajout_agenda 'A ARCHIVER 2','Client avec animaux','Meow','MALALANICH Mélanie',@dt
exec ajout_consultation3 @dt,'MALALANICH Mélanie','Meow'
exec ajout_facture @dt,'MALALANICH Mélanie','Meow',@dt,1
go
/* AGENDA */ 
--Rendez-vous ce jour par Anne AIMONE (vérifier sa suppression lors de celle du véto) --
declare @dt datetime
select @dt=convert(char(10),getdate(),103) + ' 15:00:00'
exec ajout_agenda 'Dupond','Paul','Caroline','AIMONE Anne',@dt
go
-- Rendez-vous du lendemain --
declare @dt datetime
select @dt=convert(char(10),getdate()+1,103) + ' 09:00:00'
exec ajout_agenda 'Dupond','Jean','Kiki','DE CAJOU Benoît',@dt
select @dt=convert(char(10),getdate()+1,103) + ' 09:30:00'
exec ajout_agenda 'Dupond','Jean','Toby','DE CAJOU Benoît',@dt
select @dt=convert(char(10),getdate()+1,103) + ' 14:15:00'
exec ajout_agenda 'Dupond','Paul','Caroline','MALALANICH Mélanie',@dt
select @dt=convert(char(10),getdate()+1,103) + ' 15:00:00'
exec ajout_agenda 'Bonnet','Jean','Milou','TOURNE Sylvan',@dt
select @dt=convert(char(10),getdate()+1,103) + ' 16:00:00'
exec ajout_agenda 'Duboulon','Franck','Médor','TOURNE Sylvan',@dt
go