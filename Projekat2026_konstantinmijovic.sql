create database Projekat2026_Nikola_Milosevic

USE Projekat2026_Nikola_Milosevic

CREATE TABLE Korisnik(
id INT IDENTITY(1,1) PRIMARY KEY,
email VARCHAR(40),
pass VARCHAR(30),
uloga INT)