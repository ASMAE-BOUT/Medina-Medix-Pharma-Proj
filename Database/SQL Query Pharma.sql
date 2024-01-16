CREATE TABLE M�dicaments (
    M�dicamentID INT PRIMARY KEY IDENTITY,
    Photo VARBINARY(MAX),
    D�signation NVARCHAR(100),
    PrixAchat DECIMAL(10, 2),
    PrixVente DECIMAL(10, 2),
    Quantit�Minimale INT,
    Quantit�Disponible INT,
    Utilisations NVARCHAR(500),
    ContreIndications NVARCHAR(500),
    EffetsSecondaires NVARCHAR(500),
    TauxDePriseEnCharge DECIMAL(5, 2),
    Code�Barres NVARCHAR(100),
    DateDExpiration DATE
);

CREATE TABLE Stocks (
    StockID INT PRIMARY KEY IDENTITY,
    M�dicamentID INT FOREIGN KEY REFERENCES M�dicaments(M�dicamentID),
    Quantit� INT,
    DateEntr�e DATE
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
    R�duction DECIMAL(10, 2) DEFAULT 0
);

CREATE TABLE Clients (
    ClientID INT PRIMARY KEY IDENTITY,
    Nom NVARCHAR(100),
    Adresse NVARCHAR(255),
    T�l�phone NVARCHAR(20),
    R�duction DECIMAL(10, 2) DEFAULT 0
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
