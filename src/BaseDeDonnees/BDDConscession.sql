DROP DATABASE if EXISTS Concession;
CREATE DATABASE if not EXISTS Concession;
use Concession;

CREATE TABLE VEHICULE(
   id INT,
   marque VARCHAR(50) ,
   modèle VARCHAR(50) ,
   annee INT,
   kilometrage INT,
   carburant VARCHAR(50) ,
   etat VARCHAR(50) ,
   prix DECIMAL,
   PRIMARY KEY(id)
);

CREATE TABLE CLIENT(
   id INT,
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
   id INT,
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
   id INT,
   nom VARCHAR(50) ,
   PRIMARY KEY(id)
);

CREATE TABLE GARAGE(
   id INT,
   raisonSociale VARCHAR(50) ,
   locRue VARCHAR(50) ,
   nomRue VARCHAR(50) ,
   codePostal VARCHAR(50) ,
   ville VARCHAR(50) ,
   telephone VARCHAR(50) ,
   id_1 INT ,
   PRIMARY KEY(id),
   FOREIGN KEY(id_1) REFERENCES REGION(id)
);

CREATE TABLE AGENCE_CREDIT_CELESTE(
   id INT,
   raisonSociale VARCHAR(50) ,
   locRue VARCHAR(50) ,
   nomRue VARCHAR(50) ,
   codePostal VARCHAR(50) ,
   ville VARCHAR(50) ,
   id_1 INT ,
   PRIMARY KEY(id),
   FOREIGN KEY(id_1) REFERENCES REGION(id)
);

CREATE TABLE VENTE(
   id INT,
   dateV DATE ,
   montant DECIMAL,
   validee BIT,
   id_1 INT ,
   id_2 INT ,
   id_3 INT ,
   PRIMARY KEY(id),
   FOREIGN KEY(id_1) REFERENCES GARAGE(id),
   FOREIGN KEY(id_2) REFERENCES CLIENT(id),
   FOREIGN KEY(id_3) REFERENCES VEHICULE(id)
);

CREATE TABLE ACHAT(
   id INT,
   dateA DATE,
   montant DECIMAL,
   id_1 INT ,
   id_2 INT ,
   id_3 INT ,
   PRIMARY KEY(id),
   FOREIGN KEY(id_1) REFERENCES VENDEUR(id),
   FOREIGN KEY(id_2) REFERENCES VEHICULE(id),
   FOREIGN KEY(id_3) REFERENCES GARAGE(id)
);

CREATE TABLE LOCATION(
   id INT,
   debutLoc DATE,
   forfaitMensualite INT,
   finLoc DATE,
   kilometrageDebut INT,
   kilometrageFin INT,
   prixRevientKm DECIMAL,
   id_1 INT ,
   id_2 INT ,
   id_3 INT ,
   PRIMARY KEY(id),
   FOREIGN KEY(id_1) REFERENCES CLIENT(id),
   FOREIGN KEY(id_2) REFERENCES VEHICULE(id),
   FOREIGN KEY(id_3) REFERENCES GARAGE(id)
);

CREATE TABLE DEMANDE_PRET(
   id INT,
   montantTotal DECIMAL,
   valide BIT,
   attenteValidation BIT,
   dateOuverture DATE,
   NombreMensualites INT,
   prixMensualite DECIMAL,
   taux FLOAT,
   premierApport DECIMAL,
   id_1 INT ,
   id_2 INT ,
   PRIMARY KEY(id),
   FOREIGN KEY(id_1) REFERENCES AGENCE_CREDIT_CELESTE(id),
   FOREIGN KEY(id_2) REFERENCES VENTE(id)
);