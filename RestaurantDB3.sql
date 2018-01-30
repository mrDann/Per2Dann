

CREATE TABLE Klanten (
    KlantID int IDENTITY(1,1) PRIMARY KEY,
    Voornaam varchar(255) NOT NULL,
    Achternaam varchar(255),
    Addres varchar(255),
    Stad varchar(255),
    Telnr varchar(255),
    Email varchar(255)
);

CREATE TABLE Menu (
    MenuID int IDENTITY(1,1) PRIMARY KEY,
    Voorgerecht varchar(255),
    Hoofdgerecht varchar(255),
    Nagerecht varchar(255),
    Prijs int 
);

CREATE TABLE Reserveringen (
    ReserveringID int IDENTITY(1,1) PRIMARY KEY,
    KlantID int FOREIGN KEY REFERENCES Klanten(KlantID),
    MenuID int FOREIGN KEY REFERENCES Menu(MenuID),
    AantalPersonen int,
    AantalTafels int,
    Tijd datetime
);