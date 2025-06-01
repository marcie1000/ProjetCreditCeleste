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
INSERT INTO concession.MARQUE(nom) VALUES('Honda');
INSERT INTO concession.MARQUE(nom) VALUES('Ford');
INSERT INTO concession.MARQUE(nom) VALUES('BMW');
INSERT INTO concession.MARQUE(nom) VALUES('Mercedes-Benz');
INSERT INTO concession.MARQUE(nom) VALUES('Volkswagen');
INSERT INTO concession.MARQUE(nom) VALUES('Audi');
INSERT INTO concession.MARQUE(nom) VALUES('Nissan');
INSERT INTO concession.MARQUE(nom) VALUES('Hyundai');
INSERT INTO concession.MARQUE(nom) VALUES('Kia');
INSERT INTO concession.MARQUE(nom) VALUES('Mazda');
INSERT INTO concession.MARQUE(nom) VALUES('Chevrolet');
INSERT INTO concession.MARQUE(nom) VALUES('Subaru');
INSERT INTO concession.MARQUE(nom) VALUES('Dacia');
INSERT INTO concession.MARQUE(nom) VALUES('Fiat');

declare @marqueId as int;
set @marqueId = (select id from concession.MARQUE WHERE nom LIKE 'RENAULT');

  SET @marqueId = (select id from concession.MARQUE WHERE nom LIKE 'Renault');
  INSERT INTO concession.MODELE(nom, id_marque) VALUES
    ('Clio', @marqueId), ('Megane', @marqueId), ('Laguna', @marqueId), ('Twingo', @marqueId), ('Espace', @marqueId), ('Scenic', @marqueId), ('Kangoo', @marqueId), ('Captur', @marqueId),
    ('Kadjar', @marqueId), ('Arkana', @marqueId), ('Austral', @marqueId), ('R5', @marqueId), ('R19', @marqueId), ('R21', @marqueId), ('Fluence', @marqueId), ('Safrane', @marqueId), ('Latitude', @marqueId),
    ('Talisman', @marqueId), ('ZOE', @marqueId), ('Twizy', @marqueId), ('Trafic', @marqueId), ('Master', @marqueId), ('Avantime', @marqueId), ('Vel Satis', @marqueId), ('Alaskan', @marqueId),
    ('Wind', @marqueId), ('Modus', @marqueId), ('Symbol', @marqueId), ('Duster', @marqueId), ('Express', @marqueId);

  SET @marqueId = (select id from concession.MARQUE WHERE nom LIKE 'Citroën');
  INSERT INTO concession.MODELE(nom, id_marque) VALUES
    ('2CV', @marqueId), ('AX', @marqueId), ('BX', @marqueId), ('CX', @marqueId), ('XM', @marqueId), ('ZX', @marqueId), ('Saxo', @marqueId), ('Xantia', @marqueId), ('Xsara', @marqueId), ('Xsara Picasso', @marqueId),
    ('C1', @marqueId), ('C2', @marqueId), ('C3', @marqueId), ('C3 Aircross', @marqueId), ('C3 Picasso', @marqueId), ('C4', @marqueId), ('C4 Cactus', @marqueId), ('C4 Picasso', @marqueId),
    ('C4 SpaceTourer', @marqueId), ('C5', @marqueId), ('C5 Aircross', @marqueId), ('C6', @marqueId), ('C8', @marqueId), ('Berlingo', @marqueId), ('Berlingo Van', @marqueId),
    ('Nemo', @marqueId), ('Jumper', @marqueId), ('Jumpy', @marqueId), ('AMI', @marqueId), ('E-Méhari', @marqueId);

  SET @marqueId = (select id from concession.MARQUE WHERE nom LIKE 'Peugeot');
  INSERT INTO concession.MODELE(nom, id_marque) VALUES
    ('206', @marqueId), ('207', @marqueId), ('208', @marqueId), ('306', @marqueId), ('307', @marqueId), ('308', @marqueId), ('405', @marqueId), ('406', @marqueId), ('407', @marqueId), ('508', @marqueId), ('3008', @marqueId),
    ('5008', @marqueId), ('2008', @marqueId), ('1007', @marqueId), ('607', @marqueId), ('806', @marqueId), ('807', @marqueId), ('Boxer', @marqueId), ('Partner', @marqueId), ('Expert', @marqueId), ('Rifter', @marqueId),
    ('RCZ', @marqueId), ('iOn', @marqueId), ('Bipper', @marqueId), ('Traveller', @marqueId), ('4008', @marqueId), ('405 Mi16', @marqueId), ('204', @marqueId), ('205', @marqueId), ('e-208', @marqueId);

  SET @marqueId = (select id from concession.MARQUE WHERE nom LIKE 'Toyota');
  INSERT INTO concession.MODELE(nom, id_marque) VALUES
    ('Corolla', @marqueId), ('Camry', @marqueId), ('Yaris', @marqueId), ('Prius', @marqueId), ('RAV4', @marqueId), ('Highlander', @marqueId), ('Land Cruiser', @marqueId),
    ('Hilux', @marqueId), ('Tacoma', @marqueId), ('Tundra', @marqueId), ('C-HR', @marqueId), ('Avalon', @marqueId), ('Matrix', @marqueId), ('Venza', @marqueId), ('4Runner', @marqueId),
    ('Sienna', @marqueId), ('Supra', @marqueId), ('Celica', @marqueId), ('Sequoia', @marqueId), ('MR2', @marqueId), ('Echo', @marqueId), ('FJ Cruiser', @marqueId), ('Aygo', @marqueId),
    ('Verso', @marqueId), ('ProAce', @marqueId), ('Urban Cruiser', @marqueId), ('Crown', @marqueId), ('Alphard', @marqueId), ('Fortuner', @marqueId), ('bZ4X', @marqueId);

  SET @marqueId = (select id from concession.MARQUE WHERE nom LIKE 'Honda');
  INSERT INTO concession.MODELE(nom, id_marque) VALUES
    ('Civic', @marqueId), ('Accord', @marqueId), ('Fit', @marqueId), ('CR-V', @marqueId), ('HR-V', @marqueId), ('Pilot', @marqueId), ('Odyssey', @marqueId), ('Ridgeline', @marqueId),
    ('Prelude', @marqueId), ('S2000', @marqueId), ('Insight', @marqueId), ('Element', @marqueId), ('CR-Z', @marqueId), ('Jazz', @marqueId), ('City', @marqueId), ('Legend', @marqueId),
    ('Passport', @marqueId), ('Clarity', @marqueId), ('Crosstour', @marqueId), ('Stream', @marqueId), ('Stepwgn', @marqueId), ('Z', @marqueId), ('FR-V', @marqueId), ('Logo', @marqueId),
    ('Airwave', @marqueId), ('Elysion', @marqueId), ('N-Box', @marqueId), ('Acty', @marqueId), ('Beat', @marqueId), ('Zest', @marqueId);

  SET @marqueId = (select id from concession.MARQUE WHERE nom LIKE 'Ford');
  INSERT INTO concession.MODELE(nom, id_marque) VALUES
    ('Focus', @marqueId), ('Fiesta', @marqueId), ('Fusion', @marqueId), ('Taurus', @marqueId), ('Escape', @marqueId), ('Explorer', @marqueId), ('Edge', @marqueId), ('Expedition', @marqueId),
    ('F-150', @marqueId), ('Ranger', @marqueId), ('Maverick', @marqueId), ('Mustang', @marqueId), ('Bronco', @marqueId), ('Crown Victoria', @marqueId), ('Econoline', @marqueId),
    ('Flex', @marqueId), ('Freestyle', @marqueId), ('Five Hundred', @marqueId), ('Contour', @marqueId), ('C-Max', @marqueId), ('Transit', @marqueId), ('Ka', @marqueId), ('Puma', @marqueId),
    ('S-Max', @marqueId), ('Galaxy', @marqueId), ('Mondeo', @marqueId), ('Probe', @marqueId), ('B-Max', @marqueId), ('EcoSport', @marqueId), ('GT', @marqueId);

  SET @marqueId = (select id from concession.MARQUE WHERE nom LIKE 'BMW');
  INSERT INTO concession.MODELE(nom, id_marque) VALUES
    ('1 Series', @marqueId), ('3 Series', @marqueId), ('5 Series', @marqueId), ('7 Series', @marqueId), ('X1', @marqueId), ('X3', @marqueId), ('X5', @marqueId), ('X6', @marqueId), ('X7', @marqueId),
    ('Z3', @marqueId), ('Z4', @marqueId), ('M3', @marqueId), ('M5', @marqueId), ('i3', @marqueId), ('i8', @marqueId), ('i4', @marqueId), ('iX', @marqueId), ('2 Series', @marqueId), ('4 Series', @marqueId), ('6 Series', @marqueId),
    ('8 Series', @marqueId), ('M4', @marqueId), ('M2', @marqueId), ('M8', @marqueId), ('Gran Coupe', @marqueId), ('X2', @marqueId), ('X4', @marqueId), ('325i', @marqueId), ('740i', @marqueId), ('X5M', @marqueId);

  SET @marqueId = (select id from concession.MARQUE WHERE nom LIKE 'Mercedes-Benz');
  INSERT INTO concession.MODELE(nom, id_marque) VALUES
    ('A-Class', @marqueId), ('B-Class', @marqueId), ('C-Class', @marqueId), ('E-Class', @marqueId), ('S-Class', @marqueId), ('CLA', @marqueId), ('CLS', @marqueId), ('GLA', @marqueId), ('GLB', @marqueId),
    ('GLC', @marqueId), ('GLE', @marqueId), ('GLS', @marqueId), ('G-Class', @marqueId), ('SLK', @marqueId), ('SL', @marqueId), ('SLC', @marqueId), ('EQC', @marqueId), ('EQA', @marqueId), ('EQS', @marqueId), ('EQB', @marqueId),
    ('AMG GT', @marqueId), ('Maybach S-Class', @marqueId), ('V-Class', @marqueId), ('ML', @marqueId), ('CLK', @marqueId), ('190E', @marqueId), ('R-Class', @marqueId), ('Sprinter', @marqueId),
    ('Vaneo', @marqueId), ('GLK', @marqueId), ('Citan', @marqueId);

  SET @marqueId = (select id from concession.MARQUE WHERE nom LIKE 'Volkswagen');
  INSERT INTO concession.MODELE(nom, id_marque) VALUES
    ('Golf', @marqueId), ('Passat', @marqueId), ('Jetta', @marqueId), ('Polo', @marqueId), ('Tiguan', @marqueId), ('Touareg', @marqueId), ('Arteon', @marqueId), ('ID.4', @marqueId), ('ID.3', @marqueId),
    ('Beetle', @marqueId), ('Scirocco', @marqueId), ('Sharan', @marqueId), ('Touran', @marqueId), ('Fox', @marqueId), ('Up!', @marqueId), ('T-Roc', @marqueId), ('T-Cross', @marqueId),
    ('Caddy', @marqueId), ('Transporter', @marqueId), ('Multivan', @marqueId), ('Amarok', @marqueId), ('Corrado', @marqueId), ('Bora', @marqueId), ('Vento', @marqueId), ('Eos', @marqueId),
    ('Phaeton', @marqueId), ('Lupo', @marqueId), ('Atlas', @marqueId), ('Taigo', @marqueId), ('XL1', @marqueId);

  SET @marqueId = (select id from concession.MARQUE WHERE nom LIKE 'Audi');
  INSERT INTO concession.MODELE(nom, id_marque) VALUES
    ('A1', @marqueId), ('A3', @marqueId), ('A4', @marqueId), ('A5', @marqueId), ('A6', @marqueId), ('A7', @marqueId), ('A8', @marqueId), ('Q2', @marqueId), ('Q3', @marqueId), ('Q5', @marqueId), ('Q7', @marqueId), ('Q8', @marqueId), ('TT', @marqueId),
    ('R8', @marqueId), ('S3', @marqueId), ('S4', @marqueId), ('S5', @marqueId), ('S6', @marqueId), ('S7', @marqueId), ('S8', @marqueId), ('RS3', @marqueId), ('RS4', @marqueId), ('RS5', @marqueId), ('RS6', @marqueId), ('RS7', @marqueId),
    ('e-tron', @marqueId), ('Q4 e-tron', @marqueId), ('A6 Allroad', @marqueId), ('80', @marqueId), ('100', @marqueId);

  SET @marqueId = (select id from concession.MARQUE WHERE nom LIKE 'Nissan');
  INSERT INTO concession.MODELE(nom, id_marque) VALUES
    ('Micra', @marqueId), ('Almera', @marqueId), ('Primera', @marqueId), ('Sunny', @marqueId), ('Juke', @marqueId), ('Qashqai', @marqueId), ('X-Trail', @marqueId), ('Pathfinder', @marqueId),
    ('Navara', @marqueId), ('Leaf', @marqueId), ('GT-R', @marqueId), ('370Z', @marqueId), ('350Z', @marqueId), ('Note', @marqueId), ('Pulsar', @marqueId), ('Tiida', @marqueId), ('Maxima', @marqueId),
    ('Altima', @marqueId), ('Rogue', @marqueId), ('Murano', @marqueId), ('Armada', @marqueId), ('Sentra', @marqueId), ('Versa', @marqueId), ('Cube', @marqueId), ('Terrano', @marqueId),
    ('Patrol', @marqueId), ('Cedric', @marqueId), ('Teana', @marqueId), ('Bluebird', @marqueId), ('Laurel', @marqueId);

  SET @marqueId = (select id from concession.MARQUE WHERE nom LIKE 'Hyundai');
  INSERT INTO concession.MODELE(nom, id_marque) VALUES
    ('i10', @marqueId), ('i20', @marqueId), ('i30', @marqueId), ('i40', @marqueId), ('Elantra', @marqueId), ('Sonata', @marqueId), ('Accent', @marqueId), ('Kona', @marqueId), ('Tucson', @marqueId),
    ('Santa Fe', @marqueId), ('Palisade', @marqueId), ('Terracan', @marqueId), ('Creta', @marqueId), ('Venue', @marqueId), ('Genesis', @marqueId), ('Veloster', @marqueId),
    ('Staria', @marqueId), ('Atos', @marqueId), ('Matrix', @marqueId), ('Getz', @marqueId), ('Coupe', @marqueId), ('Xcent', @marqueId), ('Verna', @marqueId), ('Azera', @marqueId), ('Galloper', @marqueId),
    ('Bayon', @marqueId), ('Ioniq', @marqueId), ('Ioniq 5', @marqueId), ('Ioniq 6', @marqueId), ('Nexo', @marqueId);

  SET @marqueId = (select id from concession.MARQUE WHERE nom LIKE 'Kia');
  INSERT INTO concession.MODELE(nom, id_marque) VALUES
    ('Picanto', @marqueId), ('Rio', @marqueId), ('Ceed', @marqueId), ('Sportage', @marqueId), ('Sorento', @marqueId), ('Carens', @marqueId), ('Niro', @marqueId), ('EV6', @marqueId),
    ('Stinger', @marqueId), ('Optima', @marqueId), ('Cerato', @marqueId), ('Soul', @marqueId), ('Carnival', @marqueId), ('Seltos', @marqueId), ('Telluride', @marqueId),
    ('Mohave', @marqueId), ('Amanti', @marqueId), ('Opirus', @marqueId), ('Magentis', @marqueId), ('Shuma', @marqueId), ('Pride', @marqueId), ('Venga', @marqueId), ('Ray', @marqueId),
    ('EV9', @marqueId), ('Besta', @marqueId), ('Elan', @marqueId), ('Mentor', @marqueId), ('Joice', @marqueId), ('Borrego', @marqueId), ('ProCeed', @marqueId);

  SET @marqueId = (select id from concession.MARQUE WHERE nom LIKE 'Mazda');
  INSERT INTO concession.MODELE(nom, id_marque) VALUES
    ('Mazda2', @marqueId), ('Mazda3', @marqueId), ('Mazda6', @marqueId), ('CX-3', @marqueId), ('CX-30', @marqueId), ('CX-5', @marqueId), ('CX-7', @marqueId), ('CX-9', @marqueId), ('MX-5', @marqueId),
    ('RX-8', @marqueId), ('RX-7', @marqueId), ('Tribute', @marqueId), ('323', @marqueId), ('626', @marqueId), ('121', @marqueId), ('Premacy', @marqueId), ('MPV', @marqueId), ('Demio', @marqueId), ('BT-50', @marqueId),
    ('Bongo', @marqueId), ('Capella', @marqueId), ('Familia', @marqueId), ('Lantis', @marqueId), ('Millenia', @marqueId), ('MX-6', @marqueId), ('CX-50', @marqueId), ('CX-60', @marqueId),
    ('CX-90', @marqueId), ('AZ-1', @marqueId), ('Verisa', @marqueId);

  SET @marqueId = (select id from concession.MARQUE WHERE nom LIKE 'Chevrolet');
  INSERT INTO concession.MODELE(nom, id_marque) VALUES
    ('Cruze', @marqueId), ('Malibu', @marqueId), ('Impala', @marqueId), ('Camaro', @marqueId), ('Corvette', @marqueId), ('Spark', @marqueId), ('Aveo', @marqueId), ('Trax', @marqueId),
    ('Equinox', @marqueId), ('Blazer', @marqueId), ('Traverse', @marqueId), ('Tahoe', @marqueId), ('Suburban', @marqueId), ('Sonic', @marqueId), ('Bolt', @marqueId), ('Silverado', @marqueId),
    ('Colorado', @marqueId), ('Caprice', @marqueId), ('Cavalier', @marqueId), ('Cobalt', @marqueId), ('HHR', @marqueId), ('Orlando', @marqueId), ('Trailblazer', @marqueId),
    ('Captiva', @marqueId), ('SS', @marqueId), ('SSR', @marqueId), ('Astro', @marqueId), ('Beretta', @marqueId), ('Lumina', @marqueId), ('Volt', @marqueId);

  SET @marqueId = (select id from concession.MARQUE WHERE nom LIKE 'Subaru');
  INSERT INTO concession.MODELE(nom, id_marque) VALUES
    ('Impreza', @marqueId), ('Legacy', @marqueId), ('Outback', @marqueId), ('Forester', @marqueId), ('Crosstrek', @marqueId), ('Ascent', @marqueId), ('BRZ', @marqueId),
    ('WRX', @marqueId), ('Baja', @marqueId), ('Tribeca', @marqueId), ('Justy', @marqueId), ('Levorg', @marqueId), ('SVX', @marqueId), ('XT', @marqueId), ('Loyale', @marqueId), ('GL', @marqueId),
    ('DL', @marqueId), ('RX', @marqueId), ('Rex', @marqueId), ('Vivio', @marqueId), ('Lucra', @marqueId), ('Sambar', @marqueId), ('Trezia', @marqueId), ('Dias', @marqueId), ('Pleo', @marqueId),
    ('R1', @marqueId), ('R2', @marqueId), ('Stella', @marqueId), ('Exiga', @marqueId), ('Alcyone', @marqueId);

  SET @marqueId = (select id from concession.MARQUE WHERE nom LIKE 'Dacia');
  INSERT INTO concession.MODELE(nom, id_marque) VALUES
    ('Logan', @marqueId), ('Logan MCV', @marqueId), ('Logan Pick-Up', @marqueId), ('Logan Van', @marqueId), ('Sandero', @marqueId), ('Sandero Stepway', @marqueId),
    ('Duster', @marqueId), ('Spring', @marqueId), ('Lodgy', @marqueId), ('Dokker', @marqueId), ('Dokker Van', @marqueId), ('Jogger', @marqueId), ('1300', @marqueId), ('1310', @marqueId),
    ('1100', @marqueId), ('Nova', @marqueId), ('SuperNova', @marqueId), ('Solenza', @marqueId), ('Pick-Up', @marqueId), ('Double Cab', @marqueId), ('Drop Side', @marqueId),
    ('Papuc', @marqueId), ('1310 Break', @marqueId), ('1304', @marqueId), ('Aro 10', @marqueId), ('Estafette', @marqueId),
    ('D6', @marqueId), ('D10', @marqueId), ('Duster Commercial', @marqueId), ('Sandero R.S.', @marqueId);

  SET @marqueId = (select id from concession.MARQUE WHERE nom LIKE 'Fiat');
  INSERT INTO concession.MODELE(nom, id_marque) VALUES
    ('500', @marqueId), ('500L', @marqueId), ('500X', @marqueId), ('Panda', @marqueId), ('Punto', @marqueId), ('Grande Punto', @marqueId), ('Tipo', @marqueId), ('Uno', @marqueId), ('Bravo', @marqueId),
    ('Brava', @marqueId), ('Croma', @marqueId), ('Stilo', @marqueId), ('Multipla', @marqueId), ('Seicento', @marqueId), ('Cinquecento', @marqueId), ('Linea', @marqueId), ('Fiorino', @marqueId),
    ('Doblo', @marqueId), ('Qubo', @marqueId), ('Scudo', @marqueId), ('Ulysse', @marqueId), ('Freemont', @marqueId), ('Marea', @marqueId), ('Palio', @marqueId), ('Siena', @marqueId), ('Idea', @marqueId),
    ('Regata', @marqueId), ('Punto Evo', @marqueId), ('124 Spider', @marqueId), ('126', @marqueId);

INSERT INTO concession.CARBURANT(designation) VALUES('Essence');
declare @idEssence int = (select SCOPE_IDENTITY());
INSERT INTO concession.CARBURANT(designation) VALUES('Diesel');
declare @idDiesel int = (select SCOPE_IDENTITY());
INSERT INTO concession.CARBURANT(designation) VALUES('Électrique');
declare @idElectrique int = (select SCOPE_IDENTITY());
INSERT INTO concession.CARBURANT(designation) VALUES('Hybride');
declare @idHybride int = (select SCOPE_IDENTITY());

INSERT INTO concession.ETAT(designation) VALUES('Neuf');
declare @idEtatNeuf int = (select SCOPE_IDENTITY());
INSERT INTO concession.ETAT(designation) VALUES('Bon état');
declare @idBonEtat int = (select SCOPE_IDENTITY());
INSERT INTO concession.ETAT(designation) VALUES('Satisfaisant');
declare @idEtatSatisfaisant int = (select SCOPE_IDENTITY());
INSERT INTO concession.ETAT(designation) VALUES('Mauvais état');
declare @idMauvaisEtat int = (select SCOPE_IDENTITY());

declare @idRegion int;
insert into concession.REGION(nom) VALUES('Alsace');
set @idRegion = (SELECT SCOPE_IDENTITY());

-- personnes
declare @idGarage int;

-- Le garage
insert into concession.PERSONNE DEFAULT VALUES;
declare @idPersonneGarage INT = (SELECT SCOPE_IDENTITY()); -- récupérer le dernier ID de PERSONNE
insert into concession.GARAGE(raisonSociale, locRue, nomRue, codePostal, ville, telephone, id_personne, id_region)
VALUES('Garage du Rhin', '26', 'Rue du port du Rhin', 67000, 'STRASBOURG', '0354876521', @idPersonneGarage, @idRegion);
set @idGarage = (SELECT SCOPE_IDENTITY());

-- Le client 1
insert into concession.PERSONNE DEFAULT VALUES;
declare @idPersonneClient1 int = (SELECT SCOPE_IDENTITY()); -- récupérer le dernier ID de PERSONNE
INSERT INTO concession.CLIENT(prenom, nom, numRue, cp, ville, numTelephone, rue, email, id_personne)
VALUES('Alice', 'COLTRANE', '8', '67000', 'STRASBOURG', '0355555555', 'Rue de jsp', 'alice.coltrane@mail.com', @idPersonneClient1);

declare @idUser int;
INSERT INTO concession.UTILISATEUR(login, mdp, sel, admin_) VALUES('admin', 'amodifier', 0, 1);
INSERT INTO concession.UTILISATEUR(login, mdp, sel, admin_) VALUES('vendeurtest', 'amodifier', 0, 0);
set @idUser = (SELECT SCOPE_IDENTITY());

INSERT INTO concession.VENDEUR(prenom, nom, email, locRue, rue, codePostal, ville, tel, id_utilisateur, id_garage)
VALUES('Prénom', 'NOMDEFAMILLE', 'prenom.nom@mail.com', '1', 'Rue Schoch', '67000', 'STRASBOURG', '0611111111', @idUser, @idGarage);

-- véhicules appartenant au garage
declare @idModClio int = (select id from concession.MODELE where nom = 'Clio');
declare @idModYaris int = (select id from concession.MODELE where nom = 'Yaris');
declare @idModC3 int = (select id from concession.MODELE where nom = 'C3');
declare @idMod207 int = (select id from concession.MODELE where nom = '207');


insert into concession.VEHICULE(annee, kilometrage, prix, id_etat, id_carburant, id_modele, puissance, couleur, id_personnePossession)
VALUES(2010, 125000, 1200, @idBonEtat, @idDiesel, @idModClio, 80, 'Blanc', @idPersonneGarage);
insert into concession.VEHICULE(annee, kilometrage, prix, id_etat, id_carburant, id_modele, puissance, couleur, id_personnePossession)
VALUES(2009, 287000, 1000, @idEtatSatisfaisant, @idEssence, @idMod207, 100, 'Jaune', @idPersonneGarage);
insert into concession.VEHICULE(annee, kilometrage, prix, id_etat, id_carburant, id_modele, puissance, couleur, id_personnePossession)
VALUES(2015, 95000, 7000, @idBonEtat, @idEssence, @idModC3, 90, 'Noir', @idPersonneGarage);
insert into concession.VEHICULE(annee, kilometrage, prix, id_etat, id_carburant, id_modele, puissance, couleur, id_personnePossession)
VALUES(2025, 100, 21000, @idEtatNeuf, @idElectrique, @idModYaris, 120, 'Bleu', @idPersonneGarage);



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
