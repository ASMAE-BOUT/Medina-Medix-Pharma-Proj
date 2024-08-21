CREATE TABLE Médicaments (
    MédicamentID INT PRIMARY KEY IDENTITY,
    Photo VARBINARY(MAX),
    Désignation NVARCHAR(100),
    PrixAchat DECIMAL(10, 2),
    PrixVente DECIMAL(10, 2),
    QuantitéMinimale INT,
    QuantitéDisponible INT,
    Utilisations NVARCHAR(500),
    ContreIndications NVARCHAR(500),
    EffetsSecondaires NVARCHAR(500),
    TauxDePriseEnCharge DECIMAL(5, 2),
    CodeÀBarres NVARCHAR(100),
    DateDExpiration DATE
);

CREATE TABLE Stocks (
    StockID INT PRIMARY KEY IDENTITY,
    MédicamentID INT FOREIGN KEY REFERENCES Médicaments(MédicamentID),
    Quantité INT,
    DateEntrée DATE
);

CREATE TABLE Ordonnances (
    OrdonnanceID INT PRIMARY KEY IDENTITY,
    Date DATE,
    ClientID INT FOREIGN KEY REFERENCES Clients(ClientID),
    Total DECIMAL(10, 2)
);

CREATE TABLE Ventes (
    VenteID INT PRIMARY KEY IDENTITY,
    Date DATE,
    ClientID INT,
    Total DECIMAL(10, 2),
    Réduction DECIMAL(10, 2) DEFAULT 0
);

CREATE TABLE Clients (
    ClientID INT PRIMARY KEY IDENTITY,
    Nom NVARCHAR(100),
    Adresse NVARCHAR(255),
    Téléphone NVARCHAR(20),
    Réduction DECIMAL(10, 2) DEFAULT 0
);

CREATE TABLE Fournisseurs (
    FournisseurID INT PRIMARY KEY IDENTITY,
    Nom NVARCHAR(100),
    Contact NVARCHAR(100),
    Adresse NVARCHAR(255)
);

CREATE TABLE Utilisateurs (
    UtilisateurID INT PRIMARY KEY IDENTITY,
    Nom NVARCHAR(100),
    Role NVARCHAR(50),
    MotDePasse NVARCHAR(100)
);
INSERT INTO Utilisateurs (Nom, Role, MotDePasse) VALUES ()


Select * from Clients
Select * from Fournisseurs
Select * from Stocks
Select * from Ventes
Select * from Ordonnances
Select * from Utilisateurs

CREATE TABLE DetailsVente (
    DetailsVenteID INT PRIMARY KEY IDENTITY,
    VenteID INT FOREIGN KEY REFERENCES Ventes(VenteID),
    MédicamentID INT FOREIGN KEY REFERENCES Médicaments(MédicamentID),
    QuantitéVendue INT,
    PrixVenteUnitaire DECIMAL(10, 2)
);

CREATE PROCEDURE AjouterAuStock
    @MédicamentID INT,
    @QuantitéAjoutée INT
AS
BEGIN
    UPDATE Stocks
    SET Quantité = Quantité + @QuantitéAjoutée
    WHERE MédicamentID = @MédicamentID;
END;

CREATE PROCEDURE VendreMedicament
    @MédicamentID INT,
    @QuantitéVendue INT
AS
BEGIN
    UPDATE Stocks
    SET Quantité = Quantité - @QuantitéVendue
    WHERE MédicamentID = @MédicamentID;
END;

CREATE TRIGGER AprèsVente
ON DetailsVente
AFTER INSERT
AS
BEGIN
    DECLARE @MédicamentID INT, @QuantitéVendue INT;
    SELECT @MédicamentID = MédicamentID, @QuantitéVendue = QuantitéVendue FROM inserted;
    EXEC VendreMedicament @MédicamentID, @QuantitéVendue;
END;

CREATE VIEW EtatDesStocks AS
SELECT MédicamentID, SUM(Quantité) as QuantitéTotale
FROM Stocks
GROUP BY MédicamentID;

ALTER PROCEDURE AjouterAuStock
    @MédicamentID INT,
    @QuantitéAjoutée INT,
    @DateEntrée DATE
AS
BEGIN
    INSERT INTO Stocks (MédicamentID, Quantité, DateEntrée) 
    VALUES (@MédicamentID, @QuantitéAjoutée, @DateEntrée);
END;



SELECT 
        V.VenteID, 
        V.Date, 
        V.ClientID, 
        V.Total, 
        V.Réduction, 
        DV.MédicamentID, 
        DV.QuantitéVendue, 
        DV.PrixVenteUnitaire
FROM Ventes V
LEFT JOIN DetailsVente DV ON V.VenteID = DV.VenteID;


GRANT SELECT ON dbo.DetailsVente TO PharmaLogin;

DROP TABLE DetailsVente;

ALTER TABLE Ventes ADD MédicamentID INT;
ALTER TABLE Ventes ADD QuantitéVendue INT;
ALTER TABLE Ventes ADD CONSTRAINT FK_Ventes_Medicaments FOREIGN KEY (MédicamentID) REFERENCES Médicaments(MédicamentID);

DROP VIEW EtatDesStocks;




ALTER TABLE Fournisseurs
ADD MedicamentID INT;


ALTER TABLE Fournisseurs
ADD CONSTRAINT FK_Fournisseurs_MedicamentID FOREIGN KEY (MedicamentID)
REFERENCES Médicaments(MédicamentID);


UPDATE Fournisseurs
SET MedicamentID = (SELECT TOP 1 MédicamentID FROM Médicaments);


ALTER TABLE Ventes
ADD CONSTRAINT FK_Ventes_ClientID FOREIGN KEY (ClientID)
REFERENCES Clients(ClientID);


UPDATE Ventes
SET ClientID = (SELECT TOP 1 ClientID FROM Clients);


ALTER TABLE Utilisateurs
ADD CONSTRAINT chk_Role CHECK (Role IN ('Pharmacien', 'Manager'));


ALTER TABLE Utilisateurs
DROP CONSTRAINT chk_Role;

ALTER TABLE Utilisateurs
ADD CONSTRAINT chk_Role CHECK (Role IN ('Pharmacien', 'Manager', 'Docteur'));


INSERT INTO Médicaments (Désignation, PrixAchat, PrixVente, QuantitéMinimale, QuantitéDisponible, Utilisations, ContreIndications, EffetsSecondaires, TauxDePriseEnCharge, CodeÀBarres, DateDExpiration)
VALUES 
('Doliprane', 10.50, 15.00, 50, 200, 'Antipyrétique', 'Allergie au paracétamol', 'Nausée', 70.00, '6111234567890', '2025-12-31'),
('Augmentin', 40.00, 60.00, 20, 100, 'Antibiotique', 'Hypersensibilité à la pénicilline', 'Diarrhée', 80.00, '6111234567891', '2024-06-30'),
('Amoxicilline', 20.00, 30.00, 30, 150, 'Antibiotique', 'Insuffisance rénale', 'Éruption cutanée', 75.00, '6111234567892', '2025-03-15'),
('Ventoline', 30.00, 45.00, 15, 80, 'Bronchodilatateur', 'Cardiopathie', 'Tremblement', 90.00, '6111234567893', '2024-11-30'),
('Ibuprofène', 12.00, 18.00, 40, 220, 'Anti-inflammatoire', 'Ulcère gastrique', 'Maux de tête', 65.00, '6111234567894', '2025-09-30'),
('Paracétamol', 8.00, 12.00, 60, 250, 'Analgésique', 'Insuffisance hépatique', 'Vertige', 85.00, '6111234567895', '2025-05-20'),
('Xanax', 50.00, 75.00, 10, 50, 'Anxiolytique', 'Dépression respiratoire', 'Somnolence', 95.00, '6111234567896', '2023-12-31'),
('Levothyrox', 25.00, 40.00, 25, 120, 'Hormone thyroïdienne', 'Thyrotoxicose', 'Palpitation', 70.00, '6111234567897', '2024-10-10');


INSERT INTO Stocks (MédicamentID, Quantité, DateEntrée)
VALUES 
(1, 200, '2023-01-10'),
(2, 100, '2023-02-15'),
(3, 150, '2023-03-20'),
(4, 80, '2023-04-25'),
(5, 220, '2023-05-30'),
(6, 250, '2023-06-05'),
(7, 50, '2023-07-15'),
(8, 120, '2023-08-20');


INSERT INTO Ordonnances (Date, ClientID, Total)
VALUES 
('2023-07-01', 1, 150.00),
('2023-07-05', 2, 220.00),
('2023-07-10', 3, 175.00),
('2023-07-15', 4, 180.00),
('2023-07-20', 5, 130.00),
('2023-07-25', 6, 160.00),
('2023-07-30', 7, 250.00),
('2023-08-05', 8, 190.00);

INSERT INTO Ventes (Date, ClientID, Total, Réduction)
VALUES 
('2023-07-01', 1, 150.00, 0),
('2023-07-05', 2, 220.00, 10.00),
('2023-07-10', 3, 175.00, 5.00),
('2023-07-15', 4, 180.00, 0),
('2023-07-20', 5, 130.00, 0),
('2023-07-25', 6, 160.00, 8.00),
('2023-07-30', 7, 250.00, 15.00),
('2023-08-05', 8, 190.00, 0);

INSERT INTO Clients (Nom, Adresse, Téléphone, Réduction)
VALUES 
('Ahmed El Amrani', 'Rabat', '0612345678', 0),
('Fatima Zahra', 'Casablanca', '0612345679', 10.00),
('Mohamed Chafiq', 'Fès', '0612345680', 5.00),
('Hassan Rachidi', 'Marrakech', '0612345681', 0),
('Samira Belkacem', 'Tanger', '0612345682', 0),
('Youssef Harrach', 'Agadir', '0612345683', 8.00),
('Karima Idrissi', 'Meknès', '0612345684', 15.00),
('Omar Benjelloun', 'Oujda', '0612345685', 0);


INSERT INTO Fournisseurs (Nom, Contact, Adresse)
VALUES 
('Pharma Maroc', 'pharma@maroc.com', 'Casablanca'),
('Med Supply', 'med@supply.com', 'Rabat'),
('Lab Pharma', 'lab@pharma.com', 'Fès'),
('Sanofi Maroc', 'contact@sanofi.ma', 'Casablanca'),
('Novartis Maroc', 'info@novartis.ma', 'Marrakech'),
('Pfizer Maroc', 'contact@pfizer.ma', 'Tanger'),
('GSK Maroc', 'service@gsk.ma', 'Agadir'),
('AstraZeneca Maroc', 'support@astrazeneca.ma', 'Oujda');

INSERT INTO Utilisateurs (Nom, Role, MotDePasse)
VALUES 
('Admin', 'Manager', 'admin123'),
('Ahmed Bakkali', 'Pharmacien', 'password123'),
('Fatima Zahra', 'Pharmacien', 'pass456'),
('Youssef Harrach', 'Manager', 'manager789'),
('Samira Idrissi', 'Pharmacien', 'pharma001'),
('Omar Benjelloun', 'Manager', 'manager002'),
('Khadija Safi', 'Pharmacien', 'pharma003'),
('Rachid Talbi', 'Manager', 'manager004');


Select * from Clients
Select * from Fournisseurs
Select * from Stocks
Select * from Ventes
Select * from Ordonnances
Select * from Utilisateurs
Select * from Médicaments

INSERT INTO Médicaments (Désignation, PrixAchat, PrixVente, QuantitéMinimale, QuantitéDisponible, Utilisations, ContreIndications, EffetsSecondaires, TauxDePriseEnCharge, CodeÀBarres, DateDExpiration)
VALUES 
('Efferalgan', 9.50, 14.00, 30, 300, 'Analgésique', 'Allergie au paracétamol', 'Somnolence', 75.00, '6111234567898', '2025-12-31'),
('Aspirine', 7.00, 10.50, 50, 500, 'Anti-inflammatoire', 'Ulcère gastrique', 'Saignement', 60.00, '6111234567899', '2024-05-15'),
('Claritin', 25.00, 35.00, 20, 150, 'Antihistaminique', 'Allergie à la loratadine', 'Sécheresse buccale', 80.00, '6111234567810', '2024-10-30');

INSERT INTO Clients (Nom, Adresse, Téléphone, Réduction)
VALUES 
('Mohamed Lakrimi', 'Marrakech', '0612345686', 5.00),
('Saida Akram', 'Fès', '0612345687', 0),
('Karim Bouziane', 'Casablanca', '0612345688', 10.00);


INSERT INTO Fournisseurs (Nom, Contact, Adresse)
VALUES 
('PharmaPlus', 'contact@pharmaplus.ma', 'Casablanca'),
('BioMed', 'info@biomed.ma', 'Rabat'),
('Lab Innov', 'support@labinnov.ma', 'Fès');

INSERT INTO Stocks (MédicamentID, Quantité, DateEntrée)
VALUES 
(9, 200, '2023-01-01'), -- Efferalgan
(10, 300, '2023-01-15'), -- Aspirine
(11, 150, '2023-02-01'); -- Claritin


INSERT INTO Ventes (Date, ClientID, Total, Réduction)
VALUES 
('2023-09-01', 9, 120.00, 5.00), -- Mohamed Lakrimi
('2023-09-05', 10, 250.00, 0.00), -- Saida Akram
('2023-09-10', 11, 175.00, 10.00); -- Karim Bouziane


INSERT INTO Ordonnances (Date, ClientID, Total)
VALUES 
('2023-09-01', 9, 120.00), -- Mohamed Lakrimi
('2023-09-05', 10, 250.00), -- Saida Akram
('2023-09-10', 11, 175.00); -- Karim Bouziane


INSERT INTO Utilisateurs (Nom, Role, MotDePasse)
VALUES 
('Docteur Amine', 'Docteur', 'doctor001'),
('Docteur Khadija', 'Docteur', 'doctor002'),
('Docteur Ali', 'Docteur', 'doctor003');



INSERT INTO Fournisseurs (Nom, Contact, Adresse, MedicamentID)
VALUES 
('Pharma Marocco', 'info@pharmamarocco.ma', 'Casablanca', 1),
('Med Pharma', 'contact@medpharma.ma', 'Rabat', 2),
('Pharmaceutique Maroc', 'support@pharmaceutiquemaroc.ma', 'Fès', 3);


INSERT INTO Ventes (Date, ClientID, Total, Réduction, MédicamentID, QuantitéVendue)
VALUES 
('2023-09-01', 1, 150.00, 5.00, 1, 10), 
('2023-09-02', 2, 100.00, 0.00, 2, 20), 
('2023-09-03', 3, 175.00, 10.00, 3, 15); 

