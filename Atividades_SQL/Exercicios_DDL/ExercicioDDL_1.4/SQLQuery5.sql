
CREATE DATABASE Empresa_Musical

USE Empresa_Musical

CREATE TABLE Artistas(
IdArtista INT PRIMARY KEY IDENTITY NOT NULL,
Nome VARCHAR (15) NOT NULL
)

CREATE TABLE Estilos(
IdEstilo INT PRIMARY KEY IDENTITY NOT NULL,
Nome VARCHAR (20) NOT NULL
)

CREATE TABLE Albuns(
IdAlbum INT PRIMARY KEY IDENTITY,
IdArtista INT FOREIGN KEY REFERENCES Artistas(IdArtista),
Titulo VARCHAR (20) NOT NULL,
DataLancamento DATE NOT NULL,
QDeMinutos FLOAT NOT NULL,
Ativo Bit NOT NULL 
)

CREATE TABLE Usuarios(
IdUsuario INT PRIMARY KEY IDENTITY,
Nome VARCHAR (20) NOT NULL,
Email VARCHAR (30)NOT NULL,
Senha VARCHAR (10)NOT NULL,
Permiss�o Bit

)



