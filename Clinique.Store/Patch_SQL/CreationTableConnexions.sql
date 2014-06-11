USE CliniqueVeterinaire;
CREATE TABLE Connexions(
id int identity constraint pk_connexions primary key,
login varchar(20) constraint un_connexions_login unique,
password varchar(20), 
);

INSERT INTO Connexions (login, password) VALUES ('BosapinE', '123');
INSERT INTO Connexions (login, password) VALUES ('DeCajouB', '123');