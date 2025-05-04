DROP DATABASE if EXISTS [Concession];
GO
CREATE DATABASE [Concession];
GO
use [Concession];
GO
CREATE SCHEMA [concession] AUTHORIZATION [dbo]
GO

DROP TABLE IF EXISTS concession.DEMANDE_PRET;
DROP TABLE IF EXISTS concession.LES_LOCATIONS;
DROP TABLE IF EXISTS concession.ACHAT;
DROP TABLE IF EXISTS concession.VENTE;
DROP TABLE IF EXISTS concession.AGENCE_CREDIT_CELESTE;
DROP TABLE IF EXISTS concession.VENDEUR;
DROP TABLE IF EXISTS concession.GARAGE;
DROP TABLE IF EXISTS concession.CLIENT;
DROP TABLE IF EXISTS concession.VEHICULE;
DROP TABLE IF EXISTS concession.PERSONNE;
DROP TABLE IF EXISTS concession.ETAT;
DROP TABLE IF EXISTS concession.CARBURANT;
DROP TABLE IF EXISTS concession.MODELE;
DROP TABLE IF EXISTS concession.MARQUE;
DROP TABLE IF EXISTS concession.UTILISATEUR;
DROP TABLE IF EXISTS concession.REGION;


CREATE TABLE concession.REGION(
   id INT NOT NULL IDENTITY,
   nom VARCHAR(50) ,
   PRIMARY KEY(id)
);


CREATE TABLE concession.UTILISATEUR(
	id INT NOT NULL IDENTITY,
	login VARCHAR(50),
	mdp VARCHAR(255),
	sel INT,
	admin_ BIT
	PRIMARY KEY(id)
);

CREATE TABLE concession.MARQUE(
   id INT NOT NULL IDENTITY,
   nom VARCHAR(50) ,
   PRIMARY KEY(id)
);

CREATE TABLE concession.MODELE(
   id INT NOT NULL IDENTITY,
   nom VARCHAR(50) ,
   id_marque INT NOT NULL,
   PRIMARY KEY(id),
   FOREIGN KEY(id_marque) REFERENCES concession.MARQUE(id)
);

CREATE TABLE concession.CARBURANT(
   id INT NOT NULL IDENTITY,
   designation VARCHAR(50) ,
   PRIMARY KEY(id)
);

CREATE TABLE concession.ETAT(
   id INT NOT NULL IDENTITY,
   designation VARCHAR(50) ,
   PRIMARY KEY(id)
);

CREATE TABLE concession.PERSONNE(
   id INT NOT NULL IDENTITY,
   PRIMARY KEY(id)
);

CREATE TABLE concession.VEHICULE(
   id INT NOT NULL IDENTITY,
   annee INT,
   kilometrage INT,
   prix MONEY,
   puissance INT,
   couleur VARCHAR(50),
   id_etat INT NOT NULL,
   id_carburant INT NOT NULL,
   id_modele INT NOT NULL,
   id_personnePossession INT,
   PRIMARY KEY(id),
   FOREIGN KEY(id_etat) REFERENCES concession.ETAT(id),
   FOREIGN KEY(id_carburant) REFERENCES concession.CARBURANT(id),
   FOREIGN KEY(id_modele) REFERENCES concession.MODELE(id),
   FOREIGN KEY(id_personnePossession) REFERENCES concession.PERSONNE(id)
);

CREATE TABLE concession.CLIENT(
   id INT NOT NULL IDENTITY,
   prenom VARCHAR(50) ,
   nom VARCHAR(50) ,
   numRue VARCHAR(50),
   cp INT,
   ville VARCHAR(50) ,
   numTelephone VARCHAR(50),
   rue VARCHAR(50) ,
   email VARCHAR(50) ,
   id_personne INT NOT NULL,
   PRIMARY KEY(id),
   FOREIGN KEY(id_personne) REFERENCES concession.PERSONNE(id)
);

CREATE TABLE concession.GARAGE(
   id INT NOT NULL IDENTITY,
   raisonSociale VARCHAR(50) ,
   locRue VARCHAR(50) ,
   nomRue VARCHAR(50) ,
   codePostal VARCHAR(50) ,
   ville VARCHAR(50) ,
   telephone VARCHAR(50) ,
   id_region INT ,
   id_personne INT ,
   PRIMARY KEY(id),
   FOREIGN KEY(id_region) REFERENCES concession.REGION(id),
      FOREIGN KEY(id_personne) REFERENCES concession.PERSONNE(id)
);

CREATE TABLE concession.VENDEUR(
   id INT NOT NULL IDENTITY,
   prenom VARCHAR(50) ,
   nom VARCHAR(50) ,
   email VARCHAR(50) ,
   locRue VARCHAR(50) ,
   rue VARCHAR(50) ,
   codePostal VARCHAR(50) ,
   ville VARCHAR(50) ,
   tel VARCHAR(50) ,
   id_utilisateur INT,
   id_garage INT,
   PRIMARY KEY(id),
   FOREIGN KEY(id_utilisateur) REFERENCES concession.UTILISATEUR(id),
   FOREIGN KEY(id_garage) REFERENCES concession.GARAGE(id)
);

CREATE TABLE concession.AGENCE_CREDIT_CELESTE(
   id INT NOT NULL IDENTITY,
   raisonSociale VARCHAR(50) ,
   locRue VARCHAR(50) ,
   nomRue VARCHAR(50) ,
   codePostal VARCHAR(50) ,
   ville VARCHAR(50) ,
   id_region INT ,
   PRIMARY KEY(id),
   FOREIGN KEY(id_region) REFERENCES concession.REGION(id)
);


CREATE TABLE concession.VENTE(
   id INT NOT NULL IDENTITY,
   dateV DATE ,
   montant DECIMAL,
   validee BIT,
   id_garage INT ,
   id_client INT ,
   id_vehicule INT ,
   PRIMARY KEY(id),
   FOREIGN KEY(id_garage) REFERENCES concession.GARAGE(id),
   FOREIGN KEY(id_client) REFERENCES concession.CLIENT(id),
   FOREIGN KEY(id_vehicule) REFERENCES concession.VEHICULE(id)
);


CREATE TABLE concession.ACHAT(
   id INT NOT NULL IDENTITY,
   dateA DATE,
   montant DECIMAL,
   id_vendeur INT ,
   id_vehicule INT ,
   id_garage INT ,
   id_client INT ,
   PRIMARY KEY(id),
   FOREIGN KEY(id_vendeur) REFERENCES concession.VENDEUR(id),
   FOREIGN KEY(id_vehicule) REFERENCES concession.VEHICULE(id),
   FOREIGN KEY(id_garage) REFERENCES concession.GARAGE(id),
   FOREIGN KEY(id_client) REFERENCES concession.CLIENT(id)
);

CREATE TABLE concession.LES_LOCATIONS(
   id INT NOT NULL IDENTITY,
   debutLoc DATE,
   forfaitMensualite INT,
   finLoc DATE,
   kilometrageDebut INT,
   kilometrageFin INT,
   prixRevientKm DECIMAL,
   id_client INT ,
   id_vehicule INT ,
   id_garage INT ,
   PRIMARY KEY(id),
   FOREIGN KEY(id_client) REFERENCES concession.CLIENT(id),
   FOREIGN KEY(id_vehicule) REFERENCES concession.VEHICULE(id),
   FOREIGN KEY(id_garage) REFERENCES concession.GARAGE(id)
);

CREATE TABLE concession.DEMANDE_PRET(
   id INT NOT NULL IDENTITY,
   montantTotal DECIMAL,
   valide BIT,
   attenteValidation BIT,
   dateOuverture DATE,
   NombreMensualites INT,
   prixMensualite DECIMAL,
   taux FLOAT,
   premierApport DECIMAL,
   id_agenceCreditCeleste INT ,
   id_vente INT ,
   PRIMARY KEY(id),
   FOREIGN KEY(id_agenceCreditCeleste) REFERENCES concession.AGENCE_CREDIT_CELESTE(id),
   FOREIGN KEY(id_vente) REFERENCES concession.VENTE(id)
);

INSERT INTO concession.MARQUE(nom) VALUES('Renault');
INSERT INTO concession.MARQUE(nom) VALUES('Citroën');
INSERT INTO concession.MARQUE(nom) VALUES('Peugeot');
INSERT INTO concession.MARQUE(nom) VALUES('Toyota');

INSERT INTO concession.MODELE(nom, id_marque) VALUES('Clio III', 1);
INSERT INTO concession.MODELE(nom, id_marque) VALUES('C3', 2);
INSERT INTO concession.MODELE(nom, id_marque) VALUES('206', 3);
INSERT INTO concession.MODELE(nom, id_marque) VALUES('Yaris', 4);

INSERT INTO concession.CARBURANT(designation) VALUES('Essence');
INSERT INTO concession.CARBURANT(designation) VALUES('Diesel');
INSERT INTO concession.CARBURANT(designation) VALUES('Électrique');
INSERT INTO concession.CARBURANT(designation) VALUES('Hybride');

INSERT INTO concession.ETAT(designation) VALUES('Neuf');
INSERT INTO concession.ETAT(designation) VALUES('Bon état');
INSERT INTO concession.ETAT(designation) VALUES('Satisfaisant');
INSERT INTO concession.ETAT(designation) VALUES('Mauvais état');

insert into concession.REGION(nom) VALUES('Alsace');

-- Le garage
insert into concession.PERSONNE DEFAULT VALUES;
-- Le client 1
insert into concession.PERSONNE DEFAULT VALUES;

insert into concession.GARAGE(raisonSociale, locRue, nomRue, codePostal, ville, telephone, id_personne, id_region)
VALUES('Garage du Rhin', '26', 'Rue du port du Rhin', 67000, 'STRASBOURG', '0354876521', 1, 1);

INSERT INTO concession.UTILISATEUR(login, mdp, sel, admin_) VALUES('admin', 'amodifier', 0, 1);
INSERT INTO concession.UTILISATEUR(login, mdp, sel, admin_) VALUES('vendeurtest', 'amodifier', 0, 0);

INSERT INTO concession.VENDEUR(prenom, nom, email, locRue, rue, codePostal, ville, tel, id_utilisateur, id_garage) VALUES('Prénom', 'NOMDEFAMILLE', 'prenom.nom@mail.com', '1', 'Rue Schoch', '67000', 'STRASBOURG', '0611111111', 2, 1);

-- véhicules appartenant au garage
insert into concession.VEHICULE(annee, kilometrage, prix, id_etat, id_carburant, id_modele, puissance, couleur, id_personnePossession) VALUES(2010, 125000, 1200, 2, 2, 1, 80, 'Blanc', 1);
insert into concession.VEHICULE(annee, kilometrage, prix, id_etat, id_carburant, id_modele, puissance, couleur, id_personnePossession) VALUES(2009, 287000, 1000, 3, 2, 2, 100, 'Jaune', 1);
insert into concession.VEHICULE(annee, kilometrage, prix, id_etat, id_carburant, id_modele, puissance, couleur, id_personnePossession) VALUES(2015, 95000, 7000, 2, 3, 4, 90, 'Noir', 1);
insert into concession.VEHICULE(annee, kilometrage, prix, id_etat, id_carburant, id_modele, puissance, couleur, id_personnePossession) VALUES(2025, 100, 21000, 1, 3, 4, 120, 'Bleu', 1);

INSERT INTO concession.CLIENT(prenom, nom, numRue, cp, ville, numTelephone, rue, email, id_personne) VALUES('Alice', 'COLTRANE', '8', '67000', 'STRASBOURG', '0355555555', 'Rue de jsp', 'alice.coltrane@mail.com', 2)


-- GRANT SELECT, INSERT, UPDATE, DELETE ON DATABASE :: Concession To cnxEleveSio WITH GRANT OPTION;

-- GO

-- CREATE or ALTER procedure dbo.creerUser(@login varchar(50), @plainTextMdp varchar(255), @estAdmin bit)
-- AS
-- BEGIN
	-- DECLARE @salt int;
	-- DECLARE @HashThis NVARCHAR(MAX);
	-- DECLARE @selEtMdp VARCHAR(MAX);
	-- DECLARE @mdpHashe varchar(255);

	-- SELECT @salt = cast(RAND()*100000 as INT);
	-- SET @selEtMdp = cast(@salt as varchar(10)) + @plainTextMdp;
	-- SET @HashThis = CONVERT(NVARCHAR(MAX), @selEtMdp);
	-- SET @mdpHashe = CONVERT(varchar(255), HASHBYTES('SHA2_512', @HashThis), 2);
	-- insert into UTILISATEUR(login, mdp, admin_, sel) values(@login, @mdpHashe, @estAdmin, @salt);
-- END;

-- GO

-- CREATE or ALTER FUNCTION dbo.verifMotDePasse(@login varchar(50), @plainTextMdp varchar(255))
-- RETURNS BIT
-- AS
-- BEGIN
	-- DECLARE @salt INT;
	-- DECLARE @selEtMdp VARCHAR(MAX);
	-- DECLARE @mdpHashe VARCHAR(255);
	-- DECLARE @HashThis NVARCHAR(MAX);
	-- DECLARE @hashBdd VARCHAR(255);
	-- DECLARE @valRetour BIT;


	-- SELECT @salt = sel FROM UTILISATEUR WHERE login = @login;
	-- SET @selEtMdp = cast(@salt as varchar(10)) + @plainTextMdp;
	-- SET @HashThis = CONVERT(NVARCHAR(MAX), @selEtMdp);
	-- SET @mdpHashe = CONVERT(varchar(255), HASHBYTES('SHA2_512', @HashThis), 2);
	-- SELECT @hashBdd = mdp from UTILISATEUR WHERE login = @login;
	-- IF @hashBdd = @mdpHashe
		-- SET @valRetour = 1;
	-- ELSE
		-- SET @valRetour = 0;
	-- RETURN @valRetour;
-- END;
