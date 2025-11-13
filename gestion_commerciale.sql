CREATE DATABASE GESTION_COMMERCIALE; 
GO 

USE GESTION_COMMERCIALE; 
GO

CREATE TABLE Statut 
(
    id_statut INT IDENTITY(1,1) PRIMARY KEY,
    nom_statut NVARCHAR(225) NOT NULL
);


CREATE TABLE Categorie
(
    id_categorie INT IDENTITY(1,1) PRIMARY KEY,
    nom_categorie NVARCHAR(225) NOT NULL
);

CREATE TABLE Produit
(
    code_produit INT IDENTITY(1,1) PRIMARY KEY,
    libelle_produit NVARCHAR(255) NOT NULL,
    prix_vente_produit FLOAT NOT NULL,
    id_categorie INT NOT NULL
);
ALTER TABLE Produit
ADD CONSTRAINT FK_Produit_Categorie FOREIGN KEY (id_categorie) REFERENCES Categorie(id_categorie);

CREATE TABLE Client 
( 
 code_client int IDENTITY(1,1) PRIMARY KEY, 
 nom_client nvarchar(255) NOT NULL,
 num_tel_client int NOT NULL,
 num_fax_client int NOT NULL,
 email_client nvarchar(255) NOT NULL,
 num_adr_fact_client int NOT NULL,
 rue_adr_fact_client nvarchar (255) NOT NULL,
 ville_adr_fact_client nvarchar (255) NOT NULL,
 cp_adr_fact_client int NOT NULL,
 num_adr_liv_client int NOT NULL,
 rue_adr_liv_client nvarchar (255) NOT NULL,
 ville_adr_liv_client nvarchar (255) NOT NULL,
 cp_adr_liv_client int NOT NULL
); 
ALTER TABLE Client
ADD CONSTRAINT AK_num_tel_client UNIQUE(num_tel_client);

ALTER TABLE Client
ADD CONSTRAINT AK_num_fax_client UNIQUE(num_fax_client);

ALTER TABLE Client
ADD CONSTRAINT AK_email_client UNIQUE(email_client);

CREATE TABLE Devis
(
    id_devis int IDENTITY(1,1) PRIMARY KEY,
    date_devis date NOT NULL,
    taux_TVA_devis int NOT NULL,
    taux_remise_glo_devis int NOT NULL,
    montant_HT_hors_remis_devise float NOT NULL,
    code_client int NOT NULL,
    id_statut int NOT NULL,
);

ALTER TABLE Devis
ADD CONSTRAINT FK_Devis_code_client FOREIGN KEY (code_client) REFERENCES Client (code_client);

ALTER TABLE Devis
ADD CONSTRAINT FK_Devis_code_statut FOREIGN KEY (id_statut) REFERENCES Statut (id_statut);

CREATE TABLE Contenir
(
    id_devis INT NOT NULL,
    code_produit INT NOT NULL,
    quantite INT NOT NULL,
    pourcentage_remise_ligne FLOAT NOT NULL

);


ALTER TABLE Contenir
ADD CONSTRAINT PK_Contenir_id_devis_code_produit PRIMARY KEY (id_devis, code_produit);

INSERT INTO Statut (nom_statut)
VALUES
('Accepté'),
('Refusé'),
('En attente');

INSERT INTO Categorie (nom_categorie)
VALUES
('Réseau'),
('Consommables'),
('PC'),
('Télévision'),
('Clavier'),
('Souris'),
('écran'),
('Disque'),
('Imprimante'),
('Montre connectée'),
('Tablette'),
('Téléphone'),
('Appareils audio'),
('Appareils photo'),
('Pièces détachées'),
('Accessoires');

INSERT INTO Client (nom_client , num_tel_client, num_fax_client , email_client, num_adr_fact_client , rue_adr_fact_client , ville_adr_fact_client, cp_adr_fact_client, num_adr_liv_client , rue_adr_liv_client , ville_adr_liv_client , cp_adr_liv_client) 
VALUES 
('Le Goffic' , '0769174637', '0123456789' , 'legoffic.n@gmail.com', 18 , 'bis rue du général Leclerc' , 'La neuille en hez', 60600, 22 , 'bis rue de lépine' , 'Cauffry' , 60290),
('Hammer' , '0234567891', '0621345678' , 'hammer.l@gmail.com', 19 , 'rue de Paris' , 'Montataire', 60160, 22 , 'rue de lépine' , 'Cauffry' , 60290),
('Martin' , '0102030405', '0708090102' , 'Martin.f@gmail.com', 31 , 'Grande rue' , 'Clermont', 60600, 10 , 'rue de la fontaine' , 'Breuil-le-sec' , 60106),
('Denes' , '0436729037', '0689053175' , 'denes.j@gmail.com', 45 , 'rue de la fontaine' , 'Senlis', 60300, 14 , 'rue de la Paix' , 'Senlis' , 60300),
('Platel' , '0638407480', '0426839259' , 'platel.k@gmail.com', 30 , 'Rue de Meaux' , 'Senlis', 60300, 23 , 'rue de la Paix' , 'Senlis' , 60300),
('Hammer' , '0234567221', '0621345234' , 'hammer.f@gmail.com', 11 , 'rue de Paris' , 'Montataire', 60160, 22 , 'rue du 14 juillet' , 'Laigneville' , 60290);

INSERT INTO Devis (date_devis , taux_TVA_devis, taux_remise_glo_devis , montant_HT_hors_remis_devise , code_client , id_statut) Values
(convert(date,'2024-10-28') , 1.20, 1.35 , 100 , 1 , 2),
(convert(date,'2024-07-18') , 1.10, 1.20 , 80 , 2 , 2),
(convert(date,'2024-12-19') , 1.06, 1.15 , 125 , 6 , 3),
(convert(date,'2024-11-22') , 1.30, 1.15 , 96 , 3 , 3),
(convert(date,'2025-01-08') , 1.10, 1.30 , 120 , 4 , 3),
(convert(date,'2024-11-30') , 1.21, 1.10 , 145 , 2 , 2),
(convert(date,'2024-07-18') , 1.25, 1.23, 156 , 1 , 2);

INSERT INTO Contenir (id_devis, code_produit, quantite, pourcentage_remise_ligne)
VALUES
(1,2,5, 10),
(7,4,14,20),
(2,3,23, 0),
(3,4,16, 25),
(5,5,30, 0),
(4,6,17, 0),
(7,2,40, 30),
(6,7,30, 0),
(1,8,57,15),
(2,9,40, 10),
(3,10,12, 5);

INSERT INTO Produit (libelle_produit, prix_vente_produit, id_categorie)
VALUES
('Ordinateur portable HP Pavilion 15', 749.99, 16),
('Smartphone Samsung Galaxy S24', 999.50,14),
('Clavier mécanique Logitech G Pro', 129.90,10),
('Souris sans fil Logitech MX Master 3S', 99.99,5),
('Écran Dell UltraSharp 27"', 329.00,9),
('Disque SSD Samsung 1 To', 119.50,3),
('Casque audio Sony WH-1000XM5', 389.00,12),
('Imprimante Canon PIXMA G3420', 229.99,1),
('Tablette Apple iPad Air', 679.00,7),
('Montre connectée Garmin Forerunner 255', 349.95,2);