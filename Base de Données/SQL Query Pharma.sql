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


