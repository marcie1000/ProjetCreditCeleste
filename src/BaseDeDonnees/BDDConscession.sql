DROP DATABASE if EXISTS Concession;
CREATE DATABASE if not EXISTS Concession;
use Concession;



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
   modele VARCHAR(50),
   annee INT,
   kilometrage INT,
   carburant VARCHAR(50),
   etat VARCHAR(50),
   prix DECIMAL(7,2),
   id_vendeur INT,
   CONSTRAINT fk_id_vendeur
		FOREIGN KEY (id_vendeur)
		REFERENCES VENDEUR(id)
		ON DELETE CASCADE
		ON UPDATE CASCADE,
   id_client INT
   CONSTRAINT fk_id_client
		FOREIGN KEY (id_client)
		REFERENCES CLIENT(id)
		ON DELETE CASCADE
		ON UPDATE CASCADE
);

CREATE TABLE LOCATION(
   id INT PRIMARY KEY,
   debutLoc VARCHAR(50),
   finLoc VARCHAR(50),
   id_vehicule INT
   CONSTRAINT fk_id_vehicule
		FOREIGN KEY(id_vehicule)
		REFERENCES VEHICULE(id)
		ON DELETE CASCADE
		ON UPDATE CASCADE
);
