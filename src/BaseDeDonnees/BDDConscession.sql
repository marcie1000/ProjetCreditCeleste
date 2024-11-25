
DROP DATABASE if EXISTS Conscession;
CREATE DATABASE if not EXISTS Conscession;
use Conscession;



CREATE TABLE CLIENT(
   id INT PRIMARY KEY,
   prenom VARCHAR(50),
   nom VARCHAR(50),
   numRue INT,
   rue VARCHAR(50),
   cp INT,
   ville VARCHAR(50),
   numTelephone INT,
   email VARCHAR(50)
);

CREATE TABLE VENDEUR(
   id INT PRIMARY KEY,
   prenom VARCHAR(50),
   nom VARCHAR(50),
   email VARCHAR(50)
);

CREATE TABLE VEHICULE(
   id INT PRIMARY KEY,
   marque VARCHAR(50),
   modèle VARCHAR(50),
   annee INT,
   kilometrage INT,
   carburant VARCHAR(50),
   etat VARCHAR(50),
   prix DECIMAL(7,2),
   id_Vendeur INT REFERENCES VENDEUR(id),
   id_Client INT REFERENCES CLIENT(id)
);

CREATE TABLE LOCATION(
   id INT PRIMARY KEY,
   debutLoc VARCHAR(50),
   finLoc VARCHAR(50),
   id_Vehicule INT REFERENCES VEHICULE(id)
);
