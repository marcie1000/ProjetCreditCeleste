DROP DATABASE if EXISTS [Concession];
CREATE DATABASE [Concession];
use [Concession];

DROP TABLE IF EXISTS DEMANDE_PRET;
DROP TABLE IF EXISTS LES_LOCATIONS;
DROP TABLE IF EXISTS ACHAT;
DROP TABLE IF EXISTS VENTE;
DROP TABLE IF EXISTS AGENCE_CREDIT_CELESTE;
DROP TABLE IF EXISTS GARAGE;
DROP TABLE IF EXISTS REGION;
DROP TABLE IF EXISTS CLIENT;
DROP TABLE IF EXISTS VENDEUR;
DROP TABLE IF EXISTS VEHICULE;

CREATE TABLE VEHICULE(
   id INT NOT NULL IDENTITY,
   marque VARCHAR(50) ,
   modele VARCHAR(50) ,
   annee INT,
   kilometrage INT,
   carburant VARCHAR(50) ,
   etat VARCHAR(50) ,
   prix DECIMAL,
   PRIMARY KEY(id)
);


CREATE TABLE CLIENT(
   id INT NOT NULL IDENTITY,
   prenom VARCHAR(50) ,
   nom VARCHAR(50) ,
   numRue INT,
   cp INT,
   ville VARCHAR(50) ,
   numTelephone INT,
   rue VARCHAR(50) ,
   email VARCHAR(50) ,
   PRIMARY KEY(id)
);


CREATE TABLE VENDEUR(
   id INT NOT NULL IDENTITY,
   prenom VARCHAR(50) ,
   nom VARCHAR(50) ,
   email VARCHAR(50) ,
   locRue VARCHAR(50) ,
   rue VARCHAR(50) ,
   codePostal VARCHAR(50) ,
   ville VARCHAR(50) ,
   tel VARCHAR(50) ,
   PRIMARY KEY(id)
);


CREATE TABLE REGION(
   id INT NOT NULL IDENTITY,
   nom VARCHAR(50) ,
   PRIMARY KEY(id)
);


CREATE TABLE GARAGE(
   id INT NOT NULL IDENTITY,
   raisonSociale VARCHAR(50) ,
   locRue VARCHAR(50) ,
   nomRue VARCHAR(50) ,
   codePostal VARCHAR(50) ,
   ville VARCHAR(50) ,
   telephone VARCHAR(50) ,
   id_region INT ,
   PRIMARY KEY(id),
   FOREIGN KEY(id_region) REFERENCES REGION(id)
);


CREATE TABLE AGENCE_CREDIT_CELESTE(
   id INT NOT NULL IDENTITY,
   raisonSociale VARCHAR(50) ,
   locRue VARCHAR(50) ,
   nomRue VARCHAR(50) ,
   codePostal VARCHAR(50) ,
   ville VARCHAR(50) ,
   id_region INT ,
   PRIMARY KEY(id),
   FOREIGN KEY(id_region) REFERENCES REGION(id)
);


CREATE TABLE VENTE(
   id INT NOT NULL IDENTITY,
   dateV DATE ,
   montant DECIMAL,
   validee BIT,
   id_garage INT ,
   id_client INT ,
   id_vehicule INT ,
   PRIMARY KEY(id),
   FOREIGN KEY(id_garage) REFERENCES GARAGE(id),
   FOREIGN KEY(id_client) REFERENCES CLIENT(id),
   FOREIGN KEY(id_vehicule) REFERENCES VEHICULE(id)
);


CREATE TABLE ACHAT(
   id INT NOT NULL IDENTITY,
   dateA DATE,
   montant DECIMAL,
   id_vendeur INT ,
   id_vehicule INT ,
   id_garage INT ,
   PRIMARY KEY(id),
   FOREIGN KEY(id_vendeur) REFERENCES VENDEUR(id),
   FOREIGN KEY(id_vehicule) REFERENCES VEHICULE(id),
   FOREIGN KEY(id_garage) REFERENCES GARAGE(id)
);

CREATE TABLE LES_LOCATIONS(
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
   FOREIGN KEY(id_client) REFERENCES CLIENT(id),
   FOREIGN KEY(id_vehicule) REFERENCES VEHICULE(id),
   FOREIGN KEY(id_garage) REFERENCES GARAGE(id)
);

CREATE TABLE DEMANDE_PRET(
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
   FOREIGN KEY(id_agenceCreditCeleste) REFERENCES AGENCE_CREDIT_CELESTE(id),
   FOREIGN KEY(id_vente) REFERENCES VENTE(id)
);

INSERT INTO VEHICULE(marque, modele, annee, kilometrage, carburant, etat, prix) VALUES('TESTMARQUE', 'TESTVEHICULE', 2014, 100000, 'Essence', 'Bon', 4000);

GRANT SELECT, INSERT, UPDATE, DELETE ON DATABASE :: Concession To cnxEleveSio WITH GRANT OPTION;