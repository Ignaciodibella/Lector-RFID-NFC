/*Dummy DB para probar interacción RFID/BackEnd/BD*/
CREATE DATABASE PruebaLectorRFID

USE PruebaLectorRFID
/*Cración de Tablas*/
CREATE TABLE Usuarios(
	dni int NOT NULL PRIMARY KEY,
	nombre varchar(100),
	apellido varchar(50),
	UID varchar(10),
	saldo float,
	activa bit,
)

CREATE TABLE Productos(
	id int IDENTITY(1,1) PRIMARY KEY,
	nombre varchar(50),
	precioUnitario float,
	stock float
)

INSERT INTO Usuarios
VALUES (111, 'Ignacio', 'Di Bella', '0620B265', 0, 1),
	   (222, 'Agustin', 'Nabarlaz', 'D64DBE32', 0, 1)

INSERT INTO Productos
VALUES ('Vaso de Fernet', 600, 10),
	   ('Vaso de Campari', 500, 5),
	   ('Botella de Fernet', 5000, 1),
	   ('Botella de Vodka', 3000, 0)